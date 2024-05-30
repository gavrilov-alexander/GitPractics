using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AdminButton.Visible = StaticDataClass.IsAdmin;
        }

        private void FacultiesButton_Click(object sender, EventArgs e)
        {
            FacultiesForm facultiesForm = new FacultiesForm();
            facultiesForm.Show();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            StaticDataClass.ShowProfileForm(this);
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminButton.Visible = StaticDataClass.IsAdmin;
        }
    }
}
