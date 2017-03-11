using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBasedProgramming.Forms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Shut down application
            Application.Exit();
        }

        private void btn_block_based_programming_Click(object sender, EventArgs e)
        {

        }

        private void btn_test_based_programming_Click(object sender, EventArgs e)
        {
            Hide();
            TestDropboxAPIForm testDropboxAPIForm = new TestDropboxAPIForm();
            testDropboxAPIForm.ShowDialog();
        }
    }
}
