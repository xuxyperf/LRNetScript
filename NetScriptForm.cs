using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Fiddler;
using System.Text.RegularExpressions;

namespace LRNetScript
{
    public partial class NetScriptForm :UserControl
    {
        public static bool editControl = true;
        public NetScriptForm()
        {
            this.InitializeComponent();
            NetScriptForm.IsEditControl = true;
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            String saveFileName = string.Empty,content = string.Empty;
            try
            {
                content = this.netScriptRichTextBox.Text;
                if (content.Length > 0 && !content.Contains("Please select one or more sessions..."))
                {
                    saveDestFileDialog.Title = "Save .NET Script to file";
                    saveDestFileDialog.Filter = ".NET Script File(*.cs)|*.cs";
                    saveDestFileDialog.RestoreDirectory = true;
                    saveDestFileDialog.FileName = null;
                    saveDestFileDialog.ShowDialog();
                    saveDestFileDialog.ValidateNames = true;
                    if (!string.IsNullOrEmpty(saveDestFileDialog.FileName))
                    {
                        saveFileName = saveDestFileDialog.FileName;
                        string processContent = ProcessNetScript(content);
                        int ret = WirteScript(processContent, saveFileName);
                        if (ret == 0)
                        {
                            MessageBox.Show("Save sucessful!");
                        }
                        else
                        {
                            MessageBox.Show("Save failed!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No script codes!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int WirteScript(string content, string fileName)
        {
            try
            {
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(fileName);
                if (fileInfo.Exists)
                {
                    System.IO.File.Delete(fileName);
                }
                if (true)
                {
                    System.IO.StreamWriter writer = new System.IO.StreamWriter(fileName, true, Encoding.Default);
                    writer.WriteLine(content);
                    writer.Flush();
                    writer.Close();
                }

                return 0;
            }
            catch
            {
                return 1;
            }
        }

        private static string ProcessNetScript(string content)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                string desc = "using BocBancsLinkPfLib;" + "\r\n" +
                   "using BOC;" + "\r\n" +
                   "namespace Script" + "\r\n" +
                   "{" + "\r\n" +
                   "    public partial class VuserClass" + "\r\n" +
                   "    {" + "\r\n" +
                   "        public int Action()" + "\r\n" +
                   "        {";
                sb.AppendLine(desc);
                sb.AppendLine("         string responseText = \"\",errRes = \"\",uploadMsg = \"\",hash = \"\";");
                sb.AppendLine("");
                sb.AppendLine("         BancsLinkHttpPf blpf = new BancsLinkHttpPf();");
                sb.AppendLine("");
                sb.AppendLine(content);
                sb.AppendLine("        " + "return 0;");
                sb.AppendLine("");
                sb.AppendLine("        }");
                sb.AppendLine("    }");
                sb.AppendLine("}");

                return sb.ToString();
            }
            catch
            {
                return "1";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String saveFileName = string.Empty, content = string.Empty;
            try
            {
                content = this.netScriptRichTextBox.Text;
                if (content.Length > 0 && !content.Contains("Please select one or more sessions..."))
                {
                    saveDestFileDialog.Title = "Save .NET Script to file";
                    saveDestFileDialog.Filter = ".NET Script File(*.cs)|*.cs";
                    saveDestFileDialog.RestoreDirectory = true;
                    saveDestFileDialog.FileName = null;
                    saveDestFileDialog.ShowDialog();
                    saveDestFileDialog.ValidateNames = true;
                    if (!string.IsNullOrEmpty(saveDestFileDialog.FileName))
                    {
                        saveFileName = saveDestFileDialog.FileName;
                        string processContent = ProcessNetScript(content);
                        int ret = WirteScript(processContent, saveFileName);
                        if (ret == 0)
                        {
                            MessageBox.Show("Save sucessful!");
                        }
                        else
                        {
                            MessageBox.Show("Save failed!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No script codes!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.netScriptRichTextBox.Focus();
            this.netScriptRichTextBox.SelectAll();
        }

        private void copyAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.netScriptRichTextBox.Copy();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.netScriptRichTextBox.Clear();
        }

        private void copyAllToolStripButton_Click(object sender, EventArgs e)
        {
            this.netScriptRichTextBox.Copy();
        }

        private void selectAllToolStripButton_Click(object sender, EventArgs e)
        {
            this.netScriptRichTextBox.Focus();
            this.netScriptRichTextBox.SelectAll();
        }

        public static bool IsEditControl
        {
            get
            {
                return editControl;
            }
            set
            {
                editControl = value;
            }
        }

        private void enterEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.cancelEditToolStripMenuItem.Enabled = true;
            this.enterEditToolStripMenuItem.Enabled = false;
            NetScriptForm.IsEditControl = false;
            this.saveToolStripMenuItem.Enabled = true;
            this.saveToolStripButton.Enabled = true;
            this.selectAllToolStripMenuItem.Enabled = true;
            this.selectAllToolStripButton.Enabled = true;
            this.clearAllToolStripMenuItem.Enabled = true;
            this.copyAllToolStripMenuItem.Enabled = true;
            this.copyAllToolStripButton.Enabled = true;
            this.addEndTransactionToolStripMenuItem.Enabled = true;
            this.addStartTransactionToolStripMenuItem.Enabled = true;
            this.startTrasactionToolStripButton.Enabled = true;
            this.endTrasactionToolStripButton.Enabled = true;
        }

        private void cancelEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to cancel edit script? The script will be not save!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.enterEditToolStripMenuItem.Enabled = true;
                this.cancelEditToolStripMenuItem.Enabled = false;
                NetScriptForm.IsEditControl = true;
                this.saveToolStripMenuItem.Enabled = false;
                this.saveToolStripButton.Enabled = false;
                this.selectAllToolStripMenuItem.Enabled = false;
                this.selectAllToolStripButton.Enabled = false;
                this.clearAllToolStripMenuItem.Enabled = false;
                this.copyAllToolStripMenuItem.Enabled = false;
                this.copyAllToolStripButton.Enabled = false;
                this.addEndTransactionToolStripMenuItem.Enabled = false;
                this.addStartTransactionToolStripMenuItem.Enabled = false;
                this.startTrasactionToolStripButton.Enabled = false;
                this.endTrasactionToolStripButton.Enabled = false;
            }
        }

        private void addStartTrasactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            AddTrasaction at = new AddTrasaction();
            at.ShowDialog();
            AddTransactionName(0);
        }

        private void startTrasactionToolStripButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            AddTrasaction at = new AddTrasaction();
            at.ShowDialog();
            AddTransactionName(0);
        }

        private void endTrasactionToolStripButton_Click(object sender, EventArgs e)
        {
            AddTrasaction at = new AddTrasaction();
            at.ShowDialog();
            AddTransactionName(1);
        }

        private void addEndTrasactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTrasaction at = new AddTrasaction();
            at.ShowDialog();
            AddTransactionName(1);
        }

        private void searchToolStripButton_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Clicks == 1 && e.Button == MouseButtons.Left)
            {
                this.SearchText(this.searchToolStripTextBox.Text);
            }
        }

        public void SearchText(String searchText)
        {
            if (!string.IsNullOrEmpty(searchText))
            {
                this.netScriptRichTextBox.Focus();
                if (searchText.Length > 0)
                {
                    int start = this.netScriptRichTextBox.SelectionStart;
                    int position = -1;
                    if (start >= 0)
                    {
                        switch (TextSearch.ActionSearchNum)
                        {
                            case 0:
                                position = this.netScriptRichTextBox.Find(searchText, start, RichTextBoxFinds.MatchCase);
                                break;
                            case 1:
                                position = this.netScriptRichTextBox.Find(searchText, start, RichTextBoxFinds.WholeWord);
                                break;
                            case 2:
                                position = this.netScriptRichTextBox.Find(searchText, start, RichTextBoxFinds.None);
                                break;
                            case 3:
                                position = this.netScriptRichTextBox.Find(searchText, start, RichTextBoxFinds.Reverse);
                                break;
                            default:
                                position = this.netScriptRichTextBox.Find(searchText, start, RichTextBoxFinds.MatchCase);
                                break;
                        }
                        if (position != -1)
                        {
                            this.netScriptRichTextBox.Select(position + searchText.Length, 0);
                        }
                        else
                        {
                            MessageBox.Show("The search string was not found.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The search string was not found.");
                    }
                }
            }
        }
        public void AddTransactionName(int control)
        {
            string ins = string.Empty;
            if (AddTrasaction.GetTransactionControl)
            {
                DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Text);
                if (this.netScriptRichTextBox.CanPaste(myFormat))
                {
                    int i = this.netScriptRichTextBox.SelectionStart;
                    this.netScriptRichTextBox.Focus();
                    if (control == 0)
                    {
                        ins = "lr.start_transaction(\"" + Clipboard.GetText() + "\");";
                        this.netScriptRichTextBox.Text = this.netScriptRichTextBox.Text.Insert(i, ins);
                        this.netScriptRichTextBox.Select(i + ins.Length, 0);
                    }
                    else if (control == 1)
                    {
                        ins = "lr.end_transaction(\"" + Clipboard.GetText() + "\",lr.PASS);";
                        this.netScriptRichTextBox.Text = this.netScriptRichTextBox.Text.Insert(i, ins);
                        this.netScriptRichTextBox.Select(i + ins.Length, 0);
                        Clipboard.Clear();
                    }
                }
            }
        }

        private void advanceSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextSearch ts = new TextSearch();
            ts.ShowDialog();
            if (!string.IsNullOrEmpty(TextSearch.ActionSearchText))
            {
                this.SearchText(TextSearch.ActionSearchText);
            }
        }

       // public void netScriptRichTextBox_KeyDown(object sender, KeyEventArgs e)
       // {
       //     this.SelectKeyWord();
       // }

       // public void SelectKeyWord()
       // {
       //     string word = GetLastWord(netScriptRichTextBox.Text, netScriptRichTextBox.SelectionStart);

       //     if (AllClass().IndexOf("Message=") > -1)
       //     {
       //         TextSelect(netScriptRichTextBox, netScriptRichTextBox.SelectionStart, word, Color.CadetBlue, true);
       //     }
       // }

       //public static List<string> AllClass()
       //  {
       //     List<string> list = new List<string>();
       //     list.Add("function");
       //     list.Add("return");
       //     list.Add("class");
       //     list.Add("new");
       //     list.Add("extends");
       //     list.Add("var");
       //     list.Add("Message=");

       //     return list;
       //  }

       // public static string GetLastWord(string word,int i)
       //  {
       //      string tmpWord = word;
       //     Regex reg= new Regex(@"/s+[a-z]+/s*",RegexOptions.RightToLeft);
       //     tmpWord = reg.Match(tmpWord).Value;

       //     Regex reg2 = new Regex(@"/s");
       //     tmpWord = reg2.Replace(tmpWord, "");

       //     return tmpWord;
       //  }

       //public static void TextSelect(System.Windows.Forms.RichTextBox rTextBox, int i, string word, Color color,bool font)
       //  {
       //      rTextBox.Select(i - word.Length, word.Length);
       //      rTextBox.SelectionColor = color;
       //     if(font)
       //         rTextBox.SelectionFont = new Font("微软雅黑", 9, (FontStyle.Bold));
       //     else
       //         rTextBox.SelectionFont = new Font("微软雅黑", 9, (FontStyle.Regular));
       //     rTextBox.Select(i, 0);
       //     rTextBox.SelectionFont = new Font("微软雅黑", 9, (FontStyle.Regular));
       //     rTextBox.SelectionColor = Color.Black;
       //}

        //private void netScriptRichTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    updateLabelRowIndex();
        //}

        //private void netScriptRichTextBox_SizeChanged(object sender, EventArgs e)
        //{
        //    updateLabelRowIndex();
        //}

        //private void netScriptRichTextBox_Resize(object sender, EventArgs e)
        //{
        //    netScriptRichTextBox_VScroll(null, null);
        //}

        //private void netScriptRichTextBox_VScroll(object sender, EventArgs e)
        //{
        //    int p = netScriptRichTextBox.GetPositionFromCharIndex(0).Y % (netScriptRichTextBox.Font.Height + 1);

        //    labelRowIndex.Location = new Point(0, p);

        //    updateLabelRowIndex();
        //}

        //private void netScriptRichTextBox_FontChanged(object sender, EventArgs e)
        //{
        //    updateLabelRowIndex();
        //    netScriptRichTextBox_VScroll(null, null);
        //} 

        //private void updateLabelRowIndex()
        //{
        //    Point pos = new Point(0, 0);
        //    int firstIndex = this.netScriptRichTextBox.GetCharIndexFromPosition(pos);
        //    int firstLine = this.netScriptRichTextBox.GetLineFromCharIndex(firstIndex);
        //    pos.X += this.netScriptRichTextBox.ClientRectangle.Width;
        //    pos.Y += this.netScriptRichTextBox.ClientRectangle.Height;
        //    int lastIndex = this.netScriptRichTextBox.GetCharIndexFromPosition(pos);
        //    int lastLine = this.netScriptRichTextBox.GetLineFromCharIndex(lastIndex);
        //    pos = this.netScriptRichTextBox.GetPositionFromCharIndex(lastIndex);
        //    labelRowIndex.Text = "";
        //    for (int i = firstLine; i <= lastLine + 1; i++)
        //    {
        //        labelRowIndex.Text += i + 1 + "\r\n";
        //    }
        //}
    }
}
