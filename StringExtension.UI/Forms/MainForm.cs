using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StringExtension.Library;

namespace StringExtension.UI.Forms
{
    public partial class MainForm : Form
    {
        #region Constructor(s)

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Menu Item Events

        private void miSystemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Form Button Events
        private void btnPopulateTestData_Click(object sender, EventArgs e)
        {
            txtText.Text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea.";
            txtSubtext.Text = "Polly";
        }

        private void btnGetIndexes_Click(object sender, EventArgs e)
        {
            List<int> indexes = txtText.Text.IndexesOf(txtSubtext.Text);

            txtOutput.Text = string.Empty;
            foreach (int i in indexes)
            {
                txtOutput.Text += string.Format("{0},", i);
            }
            txtOutput.Text = txtOutput.Text.TrimEnd(',');
        }

        #endregion

        #region Form Events
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult drExit = MessageBox.Show("Are you sure you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drExit == DialogResult.No)
                e.Cancel = true;
        }

        #endregion
    }
}
