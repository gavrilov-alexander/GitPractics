using System;
using System.Windows.Forms;

namespace ApplicantsWindowsFormsApp
{
    public partial class FacultiesForm : Form
    {
        public FacultiesForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuestionnaireForm openForm = new QuestionnaireForm();
            openForm.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FacultiesForm openForm = new FacultiesForm();
            openForm.Show();
            Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FacultiesForm openForm = new FacultiesForm();
            openForm.Show();
            Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            QuestionnaireForm openForm = new QuestionnaireForm();
            openForm.Show();
            Visible = false;
        }
    }
}
