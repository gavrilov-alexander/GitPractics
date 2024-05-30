using System;
using System.Windows.Forms;

namespace ApplicantsWindowsFormsApp
{
    public partial class QuestionnaireUpdateForm : Form
    {
        public QuestionnaireUpdateForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            QuestionnaireForm openForm = new QuestionnaireForm();
            openForm.Show();
            Visible = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

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
            QuestionnaireForm openForm = new QuestionnaireForm();
            openForm.Show();
            Visible = false;
        }
    }
}
