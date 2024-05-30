using System;
using System.Windows.Forms;

namespace ApplicantsWindowsFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FacultiesForm openForm = new FacultiesForm();
            openForm.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuestionnaireForm openForm = new QuestionnaireForm();
            openForm.Show();
            Visible = false;
        }
    }
}
