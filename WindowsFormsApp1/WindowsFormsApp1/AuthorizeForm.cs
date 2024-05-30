using System;
using System.Windows.Forms;

namespace ApplicantsWindowsFormsApp
{
    public partial class AuthorizeForm : Form
    {
        public AuthorizeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm openForm = new MainForm();
            openForm.Show();
            Visible = false;
        }

        private void roundBtn1_Click(object sender, EventArgs e)
        {
            MainForm openForm = new MainForm();
            openForm.Show();
            Visible = false;
        }
    }
}
