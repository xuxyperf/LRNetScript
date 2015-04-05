using System;
using System.Collections.Generic;
using System.Text;
using Fiddler;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

[assembly: Fiddler.RequiredVersion("2.3.5.0")]

namespace LRNetScript
{
    public class LRNetScript :IFiddlerExtension
    {
        private TabPage netScriptTabPage;
        private NetScriptForm netScriptView;
        private string[] mimeArray;
        StringBuilder sb = new StringBuilder();

        private void ViewNetScript(Session[] arrSessions)
        {
            //int i = 0;
            if (FiddlerApplication.UI.tabsViews.SelectedTab == this.netScriptTabPage && NetScriptForm.IsEditControl)
            {
                this.EnsureView();
                if (arrSessions.Length < 1)
                {
                    this.netScriptView.netScriptRichTextBox.Visible = true;
                    this.netScriptView.netScriptRichTextBox.Font = new System.Drawing.Font(this.netScriptView.netScriptRichTextBox.Font, FontStyle.Italic);
                    this.netScriptView.netScriptRichTextBox.ForeColor = System.Drawing.Color.OrangeRed;
                    this.netScriptView.netScriptRichTextBox.Text = "                                Please select one or more sessions...";
                }
                else
                {
                    this.netScriptView.netScriptRichTextBox.Visible = true;
                    this.netScriptView.netScriptRichTextBox.Font = new System.Drawing.Font(this.netScriptView.netScriptRichTextBox.Font, FontStyle.Regular);
                    this.netScriptView.netScriptRichTextBox.Text = string.Empty;
                    this.netScriptView.netScriptRichTextBox.ForeColor = System.Drawing.Color.Green;
                    //sb.AppendLine("           /* 本代码通过Fiddler .NET插件自动产生，复制到.NET协议模板使用*/");
                    foreach (Session session in arrSessions)
                    {
                        //i++;
                        string netScript = BuildNetScript(session,session.id);
                        sb.Append(netScript);
                    }
                    this.netScriptView.netScriptRichTextBox.Text = sb.ToString();
                    sb.Remove(0, sb.Length);
                }
            }
        }


        public void OnLoad()
        {
            netScriptTabPage = new TabPage("LRNetScripts");
            netScriptTabPage.ImageIndex = (int)Fiddler.SessionIcons.Script;
            netScriptView = new NetScriptForm();
            netScriptTabPage.Controls.Add(netScriptView);
            netScriptView.Dock = DockStyle.Fill;
            mimeArray = ReadConfig();
            FiddlerApplication.UI.tabsViews.TabPages.Add(netScriptTabPage);
            FiddlerApplication.CalculateReport += new CalculateReportHandler(this.ViewNetScript);
        }
        public void OnBeforeUnload()
        {
            if (null != netScriptView) netScriptView.Dispose();
        }

        private void EnsureView()
        {
            if (this.netScriptView == null)
            {
                this.netScriptView = new NetScriptForm();
                this.netScriptTabPage.Controls.Add(this.netScriptView);
                this.netScriptView.Dock = DockStyle.Fill;
            }
        }

        public String BuildNetScript(Session session,int i)
        {
            string uri = string.Empty, content = string.Empty, mothod = string.Empty, referer = string.Empty, attachmentMetadata = string.Empty, octetStream=string.Empty,soapAction = string.Empty, contentType = string.Empty, xmlMsg = string.Empty;
            string fileName = string.Empty,uploadXmlMsg = string.Empty,fileExtendName = string.Empty;
            HTTPRequestHeaders requestHeaders;
            HTTPHeaders headers;
            try
            {
                requestHeaders = session.oRequest.headers;
                headers = session.oRequest.headers;
                uri = session.fullUrl;
                mothod = requestHeaders.HTTPMethod;   
                string[] headerArray= headers.ToString().Split('\r');
                for (int x = 0; x < headerArray.Length; x++)
                {
                    if (headerArray[x].Contains("Content-Type:"))
                    {
                        contentType = headerArray[x].Substring(headerArray[x].IndexOf("Content-Type:") + 13).Trim();
                    }
                    if (contentType.Contains("text/xml; charset=utf-8") && headerArray[x].Contains("SOAPAction:"))
                    {
                        soapAction = headerArray[x].Substring(headerArray[x].IndexOf("SOAPAction:") + 11).Trim();
                    }
                    if (headerArray[x].Contains("Referer:"))
                    {
                        referer = headerArray[x].Substring(headerArray[x].IndexOf("Referer:") + 8).Trim();
                        break;
                    }
                }
                if(string.IsNullOrEmpty(contentType))
                {
                    string resHeaders = session.oResponse.headers.ToString();
                    string[] resHeadersArray = resHeaders.Split('\r');
                    for (int y = 0; y < resHeadersArray.Length; y++)
                    {
                        if (resHeadersArray[y].Contains("Content-Type:"))
                        {
                            contentType = resHeadersArray[y].Substring(resHeadersArray[y].IndexOf("Content-Type:") + 13).Trim();
                            if (contentType.Contains(";"))
                            {
                                contentType = contentType.Substring(0, contentType.IndexOf(";"));
                            }
                            break;
                        }
                    }

                    if (string.IsNullOrEmpty(contentType))
                    {
                        if (mimeArray.Length > 0)
                        {
                            for (int m = 0; m < mimeArray.Length; m++)
                            {
                                string fileType = mimeArray[m].Substring(0, mimeArray[m].IndexOf("|")).ToLower();
                                if (uri.Contains("." + fileType))
                                {
                                    fileExtendName = uri.Substring(uri.IndexOf("." + fileType)+1).ToLower();
                                    if (fileExtendName.CompareTo(fileType) == 0)
                                    {
                                        contentType = mimeArray[m].Substring(mimeArray[m].IndexOf("|") + 1);
                                        break;
                                    }
                                }
                            }
                        }
                        //if(uri.Contains("."))
                        //{
                        //    fileExtendName = uri.Substring(uri.IndexOf(".")+1).ToLower();
                        //}
                        //switch(fileExtendName)
                        //{
                        //    case "css":
                        //        contentType = "text/css";
                        //        break;
                        //    case "js":
                        //        contentType = "application/x-javascript";
                        //        break;
                        //    case "jpg":
                        //        contentType = "image/jpeg";
                        //        break;
                        //    case "gif":
                        //        contentType = "image/gif";
                        //        break;
                        //    case "png":
                        //        contentType = "text/plain";
                        //        break;
                        //    case "jsp":
                        //        contentType = "text/html";
                        //        break;
                        //}
                    }
                }
                xmlMsg = session.GetRequestBodyAsString();
                if (contentType.Contains("multipart/form-data") && uri.Contains("AttachmentItem.aspx"))
                {
                    attachmentMetadata = xmlMsg.Substring(xmlMsg.IndexOf("<Attachments>"), xmlMsg.IndexOf("</Attachments>") + 14 - xmlMsg.IndexOf("<Attachments>")).Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\r\n", "\\r\\n").Replace("\\\\n", "\\n");
                    octetStream = xmlMsg.Substring(xmlMsg.IndexOf("<transactionState"), xmlMsg.IndexOf("</transactionState>") + 19 - xmlMsg.IndexOf("<transactionState")).Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\r\n", "\\r\\n").Replace("\\\\n", "\\n");
                }
                if ((xmlMsg.Contains("\"") || xmlMsg.Contains("\\") || xmlMsg.Contains("\r\n")) && !contentType.Contains("multipart/form-data"))
                {
                    //xmlMsg = xmlMsg.Replace("\\\\", "\\\\\\\\").Replace("\"", "\\\"").Replace("\r\n","\\r\\n");
                    xmlMsg = xmlMsg.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\r\n", "\\r\\n").Replace("\\\\n","\\n");
                }
                //if(xmlMsg.Contains("\"") && xmlMsg.Contains("<fileName>"))
                //{
                //    xmlMsg = xmlMsg.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\r\n", "\\r\\n"); 
                //}
                if (uri.Contains("server.aspx"))
                {
                    uri = uri.Replace("server.aspx","engine.aspx");
                    contentType = "application/octet-stream";
                }
                if (contentType.Contains("multipart/form-data"))
                {
                    contentType = "multipart/form-data";
                }
                if (contentType.Contains("application/x-www-form-urlencoded"))
                {
                    contentType = "text/html";
                }
                if (uri.Contains("&hash="))
                {
                    fileName = "C:\\\\Bsms\\\\SubmitFiles\\\\" + uri.Substring(uri.IndexOf("FileName=") + 9, uri.IndexOf("&hash=") - uri.IndexOf("FileName=") - 9);
                    uri = uri.Substring(0, uri.IndexOf("&hash=")+6);
                    contentType = "application/upload";
                    string res = BuilderHttpUploadFileName(fileName, i);
                    content += res + "\r\n";
                }
                switch (contentType)
                {
                    case "text/xml; charset=utf-8":
                        {
                            contentType = "text/xml";
                            string res = BuilderHttpSoap(xmlMsg, uri, mothod, contentType, referer, soapAction, i);
                            if (res.CompareTo("1") == 0)
                            {
                                return "1";
                            }
                            else
                            {
                                content += res + "\r\n";
                            }
                            break;
                        }
                    case "application/upload":
                        {
                            contentType = "";
                            string res = BuilderHttpUploadFile(uri, i);
                            if (res.CompareTo("1") == 0)
                            {
                                return "1";
                            }
                            else
                            {
                                content += res + "\r\n";
                            }
                            break;
                        }
                    case "multipart/form-data":
                        {
                            xmlMsg = string.Empty;
                            string res = BuilderMultipart(xmlMsg, uri, mothod, contentType, referer, attachmentMetadata, octetStream, i);
                            if (res.CompareTo("1") == 0)
                            {
                                return "1";
                            }
                            else
                            {
                                content += res + "\r\n";
                            }
                            break;
                        }
                    default:
                        {
                            string res = BuilderHttpCompress(xmlMsg, uri, mothod, contentType, referer, i);
                            if (res.CompareTo("1") == 0)
                            {
                                return "1";
                            }
                            else
                            {
                                content += res + "\r\n";
                            }
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return content;
        }

        private static string BuilderHttpCompress(string xmlMsg, string uri, string mothod, string contentType, string referer, int i)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("         " + "responseText = blpf.BLPHttpBot(");
                sb.AppendLine("           " + "\"Message=" + xmlMsg + "\",");
                sb.AppendLine("           " + "\"URL=" + uri + "\",");
                sb.AppendLine("           " + "\"Method=" + mothod + "\",");
                sb.AppendLine("           " + "\"ContentType=" + contentType + "\",");
                sb.AppendLine("           " + "\"Referer=" + referer + "\"");
                sb.AppendLine("           " + ");");
                sb.AppendLine("");
                sb.AppendLine("         lr.output_message(\"" + i.ToString("0000") + "--------\" +" + " responseText);");


                return sb.ToString();
            }
            catch
            {
                return "1";
            }
        }

        private static string BuilderHttpUploadFileName(string fileName, int i)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("         " + "responseText = blpf.BLPHttpReadUploadFile(" + "\"" + fileName + "\"");
                sb.Append("" + ");");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("         lr.output_message(\"" + i.ToString("0000") + "--------\" +" + " responseText);");
                sb.AppendLine("");
                sb.AppendLine("         if (responseText.Contains(\"SecretID=\"))");
                sb.AppendLine("         {");
                sb.AppendLine("             uploadMsg = responseText.Substring(0, responseText.IndexOf(\"|\"));");
                sb.AppendLine("             hash = responseText.Substring(responseText.IndexOf(\"|\") + 1);");
                sb.AppendLine("         }");


                return sb.ToString();
            }
            catch
            {
                return "1";
            }
        }

        private static string BuilderHttpUploadFile(string uri, int i)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("         " + "responseText = blpf.BLPHttpBot(");
                sb.AppendLine("           " + "\"Message=\"+ uploadMsg +\"\",");
                sb.AppendLine("           " + "\"URL=" + uri + "\"+ hash +\"\",");
                sb.AppendLine("           " + "\"Method=POST\",");
                sb.AppendLine("           " + "\"ContentType=\",");
                sb.AppendLine("           " + "\"Referer=\"");
                sb.AppendLine("           " + ");");
                sb.AppendLine("");
                sb.AppendLine("         lr.output_message(\"" + i.ToString("0000") + "--------\" +" + " responseText);");


                return sb.ToString();
            }
            catch
            {
                return "1";
            }
        }

        private static string BuilderHttpUploadAsyncHandler(string fileName, string uri, string mothod, string contentType, string referer, int i)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("         " + "responseText = blpf.BLPHttpUploadAsyncHandler(");
                sb.AppendLine("           " + "\"FileName=" + fileName + "\",");
                sb.AppendLine("           " + "\"URL=" + uri + "\",");
                sb.AppendLine("           " + "\"Method=" + mothod + "\",");
                sb.AppendLine("           " + "\"ContentType=" + contentType + "\",");
                sb.AppendLine("           " + "\"Referer=" + referer + "\"");
                sb.AppendLine("           " + ");");
                sb.AppendLine("");
                sb.AppendLine("         lr.output_message(\"" + i.ToString("0000") + "--------\" +" + " responseText);");


                return sb.ToString();
            }
            catch
            {
                return "1";
            }
        }

        private static string BuilderMultipart(string xmlMsg, string uri, string mothod, string contentType, string referer, string attachmentMetadata, string octetStream, int i)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("         " + "responseText = blpf.BLPHttpMultipart(");
                sb.AppendLine("           " + "\"Message=" + xmlMsg + "\",");
                sb.AppendLine("           " + "\"URL=" + uri + "\",");
                sb.AppendLine("           " + "\"Method=" + mothod + "\",");
                sb.AppendLine("           " + "\"ContentType=" + contentType + "\",");
                sb.AppendLine("           " + "\"Referer=" + referer + "\",");
                sb.AppendLine("           " + "\"AttachmentMetadata=" + attachmentMetadata + "\",");
                sb.AppendLine("           " + "\"OctetStream=" + octetStream + "\"");
                sb.AppendLine("           " + ");");
                sb.AppendLine("");
                sb.AppendLine("         lr.output_message(\"" + i.ToString("0000") + "--------\"+" + " responseText);");

                return sb.ToString();
            }
            catch
            {
                return "1";
            }
        }

        private static string BuilderHttpSoap(string xmlMsg, string uri, string mothod, string contentType, string referer, string soapAction, int i)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("         " + "responseText = blpf.BLPHttpSoap(");
                sb.AppendLine("           " + "\"Message=" + xmlMsg + "\",");
                sb.AppendLine("           " + "\"URL=" + uri + "\",");
                sb.AppendLine("           " + "\"Method=" + mothod + "\",");
                sb.AppendLine("           " + "\"ContentType=" + contentType + "\",");
                sb.AppendLine("           " + "\"Referer=" + referer + "\",");
                sb.AppendLine("           " + "\"SOAPAction=" + soapAction + "\"");
                sb.AppendLine("           " + ");");
                sb.AppendLine("");
                sb.AppendLine("         lr.output_message(\"" + i.ToString("0000") + "--------\" +" + " responseText);");

                return sb.ToString();
            }
            catch
            {
                return "1";
            }
        }

        private static string BuilderHttpProtocol(string scDesc, string xmlMsg, string uri, string mothod, string contentType, string referer, string encType)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("   " + "web_custom_request(" + "\"" + scDesc + "\",");
                sb.AppendLine("      " + "\"URL=" + uri + "\",");
                sb.AppendLine("      " + "\"Method=" + mothod + "\",");
                sb.AppendLine("      " + "\"Resource=0" + "\",");
                sb.AppendLine("      " + "\"RecContentType=" + contentType + "\",");
                sb.AppendLine("      " + "\"Referer=" + referer + "\",");
                sb.AppendLine("      " + "\"Snapshot=t01.inf" + "\",");
                sb.AppendLine("      " + "\"Mode=HTTP" + "\",");
                sb.AppendLine("      " + "\"EncType=" + encType + "\",");
                if (mothod.CompareTo("POST") == 0)
                {
                    sb.AppendLine("      " + "\"Body=" + xmlMsg + "\",");
                }
                sb.AppendLine("      " + "LAST);");

                return sb.ToString();
            }
            catch
            {
                return "1";
            }
        }

        public string[] ReadConfig()
        {
            string content = string.Empty;
            string[] configArray = { "" };
            using (TextReader tr = new StreamReader("Scripts/LRMimeConfig.txt", Encoding.UTF8))
            {
                try
                {
                    if (tr != null)
                    {
                        content = tr.ReadLine();
                        tr.Close();
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tr.Close();
                }
            }
            if (content.Contains(","))
            {
                configArray = content.Split(',');
            }

            return configArray;
        }
    }
}
