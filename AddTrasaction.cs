using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Fiddler;

namespace LRNetScript
{
    public partial class AddTrasaction:Form
    {
        public AddTrasaction()
        {
            InitializeComponent();
            string transfer = Clipboard.GetText();
            this.transactionNameTextBox.Text = transfer;
        }

        public static bool trasactionControl =  true;

        private void cancelButton_Click(object sender, EventArgs e)
        {
            GetTransactionControl = false;
            this.Close();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            GetTransactionControl = true;
            this.transactionNameTextBox.SelectAll(); 
            this.transactionNameTextBox.Copy();
            this.Close();
        }

        public static bool  GetTransactionControl
        {
            get
            {
                return trasactionControl;
            }
            set
            {
                trasactionControl = value;
            }
        }
    }
}
