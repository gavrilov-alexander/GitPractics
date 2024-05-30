using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class QuestionnaireForm : Form
    {
        public QuestionnaireForm()
        {
            InitializeComponent();
        }
        
        private void FacultiesButton_Click(object sender, EventArgs e)
        {
            FacultiesForm facultiesForm = new FacultiesForm();
            facultiesForm.Show();
            this.Close();
        }

        private void UpdateRoundBtn_Click(object sender, EventArgs e)
        {
            QuestionnaireUpdateForm questionnaireUpdateForm = new QuestionnaireUpdateForm();
            questionnaireUpdateForm.Show();
            this.Close();
        }

        private void QuestionnaireForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "applicantsDataSet.Questionnaire". При необходимости она может быть перемещена или удалена.
            this.questionnaireTableAdapter.Fill(this.applicantsDataSet.Questionnaire);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "applicantsDataSet.SelectedSubject". При необходимости она может быть перемещена или удалена.
            this.selectedSubjectTableAdapter.Fill(this.applicantsDataSet.SelectedSubject);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "applicantsDataSet.Subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.applicantsDataSet.Subjects);


            if (StaticDataClass.IDQuestionnaire != -1)
            {
                string sqlSelect = @"SELECT ID_анкеты FROM [User] WHERE @id = ID_пользователя";
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.ApplicantsConnectionString);
                SqlCommand command = connection.CreateCommand();
                command.CommandText = sqlSelect;
                try
                {
                    command.Parameters.AddWithValue("@id", StaticDataClass.IDProfile);
                }
                catch
                {
                    MessageBox.Show("", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                List<object> ids = new List<object>();
                foreach (DataRow row in table.Rows)
                {
                    var cells = row.ItemArray;
                    foreach (object cell in cells)
                    {
                        ids.Add(cell);
                    }
                }
                if (ids.Count != 0)
                {
                    List<object> objects = FillBoxes();
                    StaticDataClass.IDQuestionnaire = (int)ids[0];
                    SurnameTextBox.Text = (string)(objects[1]);
                    NameTextBox.Text = (string)objects[2];
                    LastNameTextBox.Text = (string)objects[3];
                    BirthdayTextBox.Text = (string)objects[7];
                    SexTextBox.Text = (string)objects[4];
                    YearTextBox.Text = (string)objects[5];
                    PhoneTextBox.Text = (string)objects[6];
                    EmailTextBox.Text = StaticDataClass.Email;
                    SubjectsComboBox.Items.Clear();
                    foreach (object obj in FillSubjects())
                    {
                        SubjectsComboBox.Items.Add(obj.ToString());
                    }
                }
            }


        }

        private List<object> FillBoxes()
        {
            string sqlSelect = @"SELECT * FROM Questionnaire WHERE @id = ID_анкеты";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.ApplicantsConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            try
            {
                //command.Parameters.AddWithValue("@atribute", atribute);
                command.Parameters.AddWithValue("@id", StaticDataClass.IDProfile);
            }
            catch
            {
                MessageBox.Show("", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            List<object> objects = new List<object>();
            foreach (DataRow row in table.Rows)
            {
                var cells = row.ItemArray;
                foreach (object cell in cells)
                {
                    objects.Add(cell);
                }
            }
            return objects;
        }

        private List<object> FillSubjects()
        {
            string sqlSelect = @"SELECT Название FROM SelectedSubject WHERE @id = ID_анкеты";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.ApplicantsConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            try
            {
                command.Parameters.AddWithValue("@id", StaticDataClass.IDQuestionnaire);
            }
            catch
            {
                MessageBox.Show("", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            List<object> objects = new List<object>();
            foreach (DataRow row in table.Rows)
            {
                var cells = row.ItemArray;
                foreach (object cell in cells)
                {
                    objects.Add((int)cell);
                }
            }
            if (objects.Count != 0)
            {
                return objects;
            }
            return null;
        }

        private void subjectsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.subjectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.applicantsDataSet);

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            StaticDataClass.IDQuestionnaire = -1;
            StaticDataClass.IDProfile = -1;
            StaticDataClass.ShowProfileForm(this);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
