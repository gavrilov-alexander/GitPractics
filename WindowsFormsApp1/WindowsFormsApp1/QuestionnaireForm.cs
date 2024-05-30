using System;
using System.Windows.Forms;

namespace ApplicantsWindowsFormsApp
{
    public partial class QuestionnaireForm : Form
    {
        public QuestionnaireForm()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            QuestionnaireUpdateForm openForm = new QuestionnaireUpdateForm();
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

        private void roundBtn1_Click(object sender, EventArgs e)
        {
            QuestionnaireUpdateForm openForm = new QuestionnaireUpdateForm();
            openForm.Show();
            Visible = false;
        }
    }
}
