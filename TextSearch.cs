using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LRNetScript
{
    public partial class TextSearch : Form
    {
        private static string searchText = string.Empty;
        private static int searchNum = 0;
        public TextSearch()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string ActionSearchText
        {
            get
            {
                return searchText;
            }
            set
            {
                searchText = value;
            }
        }

        public static int ActionSearchNum
        {
            get
            {
                return searchNum;
            }
            set
            {
                searchNum = value;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.searchTextBox.Text))
            {
                ActionSearchText = this.searchTextBox.Text;
                if(matchCaseCheckBox.Checked)
                {
                     searchNum = 0;
                }
                if (wholeWordCheckBox.Checked)
                {
                    searchNum = 1;
                }
                if (noneCheckBox.Checked)
                {
                    searchNum = 2;
                }
                if (reverseCheckBox.Checked)
                {
                    searchNum = 3;
                }
            }
            this.Close();
        }
    }
}
