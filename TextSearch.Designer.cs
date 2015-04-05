namespace LRNetScript
{
    partial class TextSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.matchCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.wholeWordCheckBox = new System.Windows.Forms.CheckBox();
            this.reverseCheckBox = new System.Windows.Forms.CheckBox();
            this.noneCheckBox = new System.Windows.Forms.CheckBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Text:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchTextBox.Location = new System.Drawing.Point(111, 21);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(335, 21);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(463, 20);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // matchCaseCheckBox
            // 
            this.matchCaseCheckBox.AutoSize = true;
            this.matchCaseCheckBox.Location = new System.Drawing.Point(111, 58);
            this.matchCaseCheckBox.Name = "matchCaseCheckBox";
            this.matchCaseCheckBox.Size = new System.Drawing.Size(78, 16);
            this.matchCaseCheckBox.TabIndex = 8;
            this.matchCaseCheckBox.Text = "MatchCase";
            this.matchCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // wholeWordCheckBox
            // 
            this.wholeWordCheckBox.AutoSize = true;
            this.wholeWordCheckBox.Location = new System.Drawing.Point(111, 81);
            this.wholeWordCheckBox.Name = "wholeWordCheckBox";
            this.wholeWordCheckBox.Size = new System.Drawing.Size(78, 16);
            this.wholeWordCheckBox.TabIndex = 9;
            this.wholeWordCheckBox.Text = "WholeWord";
            this.wholeWordCheckBox.UseVisualStyleBackColor = true;
            // 
            // reverseCheckBox
            // 
            this.reverseCheckBox.AutoSize = true;
            this.reverseCheckBox.Location = new System.Drawing.Point(211, 81);
            this.reverseCheckBox.Name = "reverseCheckBox";
            this.reverseCheckBox.Size = new System.Drawing.Size(66, 16);
            this.reverseCheckBox.TabIndex = 12;
            this.reverseCheckBox.Text = "Reverse";
            this.reverseCheckBox.UseVisualStyleBackColor = true;
            // 
            // noneCheckBox
            // 
            this.noneCheckBox.AutoSize = true;
            this.noneCheckBox.Location = new System.Drawing.Point(211, 58);
            this.noneCheckBox.Name = "noneCheckBox";
            this.noneCheckBox.Size = new System.Drawing.Size(48, 16);
            this.noneCheckBox.TabIndex = 10;
            this.noneCheckBox.Text = "None";
            this.noneCheckBox.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(544, 20);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // TextSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 127);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.reverseCheckBox);
            this.Controls.Add(this.noneCheckBox);
            this.Controls.Add(this.wholeWordCheckBox);
            this.Controls.Add(this.matchCaseCheckBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TextSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.CheckBox matchCaseCheckBox;
        private System.Windows.Forms.CheckBox wholeWordCheckBox;
        private System.Windows.Forms.CheckBox reverseCheckBox;
        private System.Windows.Forms.CheckBox noneCheckBox;
        private System.Windows.Forms.Button closeButton;
    }
}