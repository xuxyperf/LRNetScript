namespace LRNetScript
{
    partial class NetScriptForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetScriptForm));
            this.netScriptTabControl = new System.Windows.Forms.TabControl();
            this.netScriptTabPage = new System.Windows.Forms.TabPage();
            this.labelRowIndex = new System.Windows.Forms.Label();
            this.netScriptRichTextBox = new System.Windows.Forms.RichTextBox();
            this.netScriptContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStartTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEndTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netScriptToolStrip = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.selectAllToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyAllToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.startTrasactionToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.endTrasactionToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.searchToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.netScriptStatusStrip = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveDestFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.advanceSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netScriptTabControl.SuspendLayout();
            this.netScriptTabPage.SuspendLayout();
            this.netScriptContextMenuStrip.SuspendLayout();
            this.netScriptToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // netScriptTabControl
            // 
            this.netScriptTabControl.Controls.Add(this.netScriptTabPage);
            this.netScriptTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.netScriptTabControl.Location = new System.Drawing.Point(0, 0);
            this.netScriptTabControl.Name = "netScriptTabControl";
            this.netScriptTabControl.SelectedIndex = 0;
            this.netScriptTabControl.Size = new System.Drawing.Size(741, 315);
            this.netScriptTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.netScriptTabControl.TabIndex = 4;
            // 
            // netScriptTabPage
            // 
            this.netScriptTabPage.AllowDrop = true;
            this.netScriptTabPage.AutoScroll = true;
            this.netScriptTabPage.Controls.Add(this.labelRowIndex);
            this.netScriptTabPage.Controls.Add(this.netScriptRichTextBox);
            this.netScriptTabPage.Location = new System.Drawing.Point(4, 22);
            this.netScriptTabPage.Name = "netScriptTabPage";
            this.netScriptTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.netScriptTabPage.Size = new System.Drawing.Size(733, 289);
            this.netScriptTabPage.TabIndex = 0;
            this.netScriptTabPage.Text = ".Net Script";
            this.netScriptTabPage.UseVisualStyleBackColor = true;
            // 
            // labelRowIndex
            // 
            this.labelRowIndex.AutoSize = true;
            this.labelRowIndex.BackColor = System.Drawing.Color.Transparent;
            this.labelRowIndex.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRowIndex.ForeColor = System.Drawing.Color.Maroon;
            this.labelRowIndex.Location = new System.Drawing.Point(7, 7);
            this.labelRowIndex.Name = "labelRowIndex";
            this.labelRowIndex.Size = new System.Drawing.Size(0, 17);
            this.labelRowIndex.TabIndex = 6;
            // 
            // netScriptRichTextBox
            // 
            this.netScriptRichTextBox.AutoWordSelection = true;
            this.netScriptRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.netScriptRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.netScriptRichTextBox.ContextMenuStrip = this.netScriptContextMenuStrip;
            this.netScriptRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.netScriptRichTextBox.EnableAutoDragDrop = true;
            this.netScriptRichTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.netScriptRichTextBox.ForeColor = System.Drawing.Color.Green;
            this.netScriptRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.netScriptRichTextBox.Name = "netScriptRichTextBox";
            this.netScriptRichTextBox.Size = new System.Drawing.Size(727, 283);
            this.netScriptRichTextBox.TabIndex = 5;
            this.netScriptRichTextBox.Text = "";
            // 
            // netScriptContextMenuStrip
            // 
            this.netScriptContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.copyAllToolStripMenuItem,
            this.clearAllToolStripMenuItem,
            this.enterEditToolStripMenuItem,
            this.cancelEditToolStripMenuItem,
            this.addStartTransactionToolStripMenuItem,
            this.addEndTransactionToolStripMenuItem,
            this.advanceSearchToolStripMenuItem});
            this.netScriptContextMenuStrip.Name = "netScriptContextMenuStrip";
            this.netScriptContextMenuStrip.Size = new System.Drawing.Size(244, 224);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.saveToolStripMenuItem.Text = "Save .NETScript";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Enabled = false;
            this.selectAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectAllToolStripMenuItem.Image")));
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // copyAllToolStripMenuItem
            // 
            this.copyAllToolStripMenuItem.Enabled = false;
            this.copyAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyAllToolStripMenuItem.Image")));
            this.copyAllToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.copyAllToolStripMenuItem.Name = "copyAllToolStripMenuItem";
            this.copyAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.copyAllToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.copyAllToolStripMenuItem.Text = "Copy All";
            this.copyAllToolStripMenuItem.Click += new System.EventHandler(this.copyAllToolStripMenuItem_Click);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Enabled = false;
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // enterEditToolStripMenuItem
            // 
            this.enterEditToolStripMenuItem.Name = "enterEditToolStripMenuItem";
            this.enterEditToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F2)));
            this.enterEditToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.enterEditToolStripMenuItem.Text = "Enter Edit";
            this.enterEditToolStripMenuItem.Click += new System.EventHandler(this.enterEditToolStripMenuItem_Click);
            // 
            // cancelEditToolStripMenuItem
            // 
            this.cancelEditToolStripMenuItem.Enabled = false;
            this.cancelEditToolStripMenuItem.Name = "cancelEditToolStripMenuItem";
            this.cancelEditToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3)));
            this.cancelEditToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.cancelEditToolStripMenuItem.Text = "Cancel Edit";
            this.cancelEditToolStripMenuItem.Click += new System.EventHandler(this.cancelEditToolStripMenuItem_Click);
            // 
            // addStartTransactionToolStripMenuItem
            // 
            this.addStartTransactionToolStripMenuItem.Enabled = false;
            this.addStartTransactionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addStartTransactionToolStripMenuItem.Image")));
            this.addStartTransactionToolStripMenuItem.Name = "addStartTransactionToolStripMenuItem";
            this.addStartTransactionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F11)));
            this.addStartTransactionToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.addStartTransactionToolStripMenuItem.Text = "Add Start Transaction";
            this.addStartTransactionToolStripMenuItem.Click += new System.EventHandler(this.addStartTrasactionToolStripMenuItem_Click);
            // 
            // addEndTransactionToolStripMenuItem
            // 
            this.addEndTransactionToolStripMenuItem.Enabled = false;
            this.addEndTransactionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addEndTransactionToolStripMenuItem.Image")));
            this.addEndTransactionToolStripMenuItem.Name = "addEndTransactionToolStripMenuItem";
            this.addEndTransactionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F12)));
            this.addEndTransactionToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.addEndTransactionToolStripMenuItem.Text = "Add End Transaction";
            this.addEndTransactionToolStripMenuItem.Click += new System.EventHandler(this.addEndTrasactionToolStripMenuItem_Click);
            // 
            // netScriptToolStrip
            // 
            this.netScriptToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.selectAllToolStripButton,
            this.copyAllToolStripButton,
            this.startTrasactionToolStripButton,
            this.endTrasactionToolStripButton,
            this.toolStripSeparator1,
            this.searchToolStripTextBox,
            this.searchToolStripButton});
            this.netScriptToolStrip.Location = new System.Drawing.Point(0, 0);
            this.netScriptToolStrip.Name = "netScriptToolStrip";
            this.netScriptToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.netScriptToolStrip.Size = new System.Drawing.Size(741, 25);
            this.netScriptToolStrip.TabIndex = 1;
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Enabled = false;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "Save .NETScript";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // selectAllToolStripButton
            // 
            this.selectAllToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectAllToolStripButton.Enabled = false;
            this.selectAllToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("selectAllToolStripButton.Image")));
            this.selectAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectAllToolStripButton.Name = "selectAllToolStripButton";
            this.selectAllToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.selectAllToolStripButton.Text = "Select All";
            this.selectAllToolStripButton.Click += new System.EventHandler(this.selectAllToolStripButton_Click);
            // 
            // copyAllToolStripButton
            // 
            this.copyAllToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyAllToolStripButton.Enabled = false;
            this.copyAllToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyAllToolStripButton.Image")));
            this.copyAllToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.copyAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyAllToolStripButton.Name = "copyAllToolStripButton";
            this.copyAllToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyAllToolStripButton.Text = "Copy All";
            this.copyAllToolStripButton.Click += new System.EventHandler(this.copyAllToolStripButton_Click);
            // 
            // startTrasactionToolStripButton
            // 
            this.startTrasactionToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startTrasactionToolStripButton.Enabled = false;
            this.startTrasactionToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("startTrasactionToolStripButton.Image")));
            this.startTrasactionToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startTrasactionToolStripButton.Name = "startTrasactionToolStripButton";
            this.startTrasactionToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.startTrasactionToolStripButton.Text = "Add Start Transaction";
            this.startTrasactionToolStripButton.Click += new System.EventHandler(this.startTrasactionToolStripButton_Click);
            // 
            // endTrasactionToolStripButton
            // 
            this.endTrasactionToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.endTrasactionToolStripButton.Enabled = false;
            this.endTrasactionToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("endTrasactionToolStripButton.Image")));
            this.endTrasactionToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.endTrasactionToolStripButton.Name = "endTrasactionToolStripButton";
            this.endTrasactionToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.endTrasactionToolStripButton.Text = "Add End Transaction";
            this.endTrasactionToolStripButton.Click += new System.EventHandler(this.endTrasactionToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // searchToolStripTextBox
            // 
            this.searchToolStripTextBox.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.searchToolStripTextBox.Name = "searchToolStripTextBox";
            this.searchToolStripTextBox.Size = new System.Drawing.Size(200, 25);
            // 
            // searchToolStripButton
            // 
            this.searchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripButton.Image")));
            this.searchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchToolStripButton.Name = "searchToolStripButton";
            this.searchToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.searchToolStripButton.Text = "SearchText";
            this.searchToolStripButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.searchToolStripButton_MouseDown);
            // 
            // netScriptStatusStrip
            // 
            this.netScriptStatusStrip.Location = new System.Drawing.Point(0, 340);
            this.netScriptStatusStrip.Name = "netScriptStatusStrip";
            this.netScriptStatusStrip.Size = new System.Drawing.Size(741, 22);
            this.netScriptStatusStrip.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.netScriptTabControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 315);
            this.panel1.TabIndex = 5;
            // 
            // advanceSearchToolStripMenuItem
            // 
            this.advanceSearchToolStripMenuItem.Name = "advanceSearchToolStripMenuItem";
            this.advanceSearchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3)));
            this.advanceSearchToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.advanceSearchToolStripMenuItem.Text = "Advance Search";
            this.advanceSearchToolStripMenuItem.Click += new System.EventHandler(this.advanceSearchToolStripMenuItem_Click);
            // 
            // NetScriptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.netScriptStatusStrip);
            this.Controls.Add(this.netScriptToolStrip);
            this.Name = "NetScriptForm";
            this.Size = new System.Drawing.Size(741, 362);
            this.netScriptTabControl.ResumeLayout(false);
            this.netScriptTabPage.ResumeLayout(false);
            this.netScriptTabPage.PerformLayout();
            this.netScriptContextMenuStrip.ResumeLayout(false);
            this.netScriptToolStrip.ResumeLayout(false);
            this.netScriptToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TabControl netScriptTabControl;
        public System.Windows.Forms.TabPage netScriptTabPage;
        public System.Windows.Forms.RichTextBox netScriptRichTextBox;
        private System.Windows.Forms.ToolStrip netScriptToolStrip;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.StatusStrip netScriptStatusStrip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip netScriptContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveDestFileDialog;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton copyAllToolStripButton;
        private System.Windows.Forms.ToolStripButton selectAllToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem enterEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStartTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEndTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton startTrasactionToolStripButton;
        private System.Windows.Forms.ToolStripButton endTrasactionToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox searchToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchToolStripButton;
        private System.Windows.Forms.Label labelRowIndex;
        private System.Windows.Forms.ToolStripMenuItem advanceSearchToolStripMenuItem;
    }
}