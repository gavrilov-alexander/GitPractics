using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class QuestionnaireUpdateForm : Form
    {
        public QuestionnaireUpdateForm()
        {
            InitializeComponent();
        }

        private void OkRoundBtn_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == String.Empty || SurnameTextBox.Text == String.Empty || LastNameTextBox.Text == String.Empty
                || BirthdayTextBox.Text == String.Empty || YearTextBox.Text == String.Empty || PhoneTextBox.Text == String.Empty
                || EmailTextBox.Text == String.Empty || SubjectsCheckedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("");
                return;
            }
            DateTime birthday;
            int year;
            try
            {
                birthday = DateTime.Now; //(DateTime)(object)BirthdayTextBox.Text;
                year = int.Parse(YearTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка");
                return;
            }
            string pattern = @"^\+[\d]{11}$";
            if (!(Regex.Match(PhoneTextBox.Text, pattern)).Success)
            {
                MessageBox.Show("Ошибка");
                return;
            }

            if (StaticDataClass.IDQuestionnaire == -1)
            {
                string sqlInsert = @"INSERT INTO [Questionnaire] (Фамилия, Имя, Отчество, Пол, Год_окончания_обучения, Номер_телефона, Дата_рождения)
                                VALUES (@surname, @name, @lastname, @sex, @year, @phone, @birthday)";
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.ApplicantsConnectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = sqlInsert;
                command.Parameters.AddWithValue("@surname", SurnameTextBox.Text);
                command.Parameters.AddWithValue("@name", NameTextBox.Text);
                command.Parameters.AddWithValue("@lastname", LastNameTextBox.Text);
                command.Parameters.AddWithValue("@sex", SexComboBox.SelectedItem.ToString());
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@phone", PhoneTextBox.Text);
                command.Parameters.AddWithValue("@birthday", birthday);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
                //this.questionnaireTableAdapter.Fill(this.applicantsDataSet.Questionnaire);
                FindIdQuestionnaire();
                foreach (string obj in SubjectsCheckedListBox.CheckedItems)
                {
                    sqlInsert = @"INSERT INTO [SelectedSubject] (Название, ID_анкеты)
                                VALUES (@name, @id)";
                    connection = new SqlConnection(Properties.Settings.Default.ApplicantsConnectionString);
                    connection.Open();
                    SqlCommand command2 = connection.CreateCommand();
                    command2.CommandText = sqlInsert;
                    command2.Parameters.AddWithValue("@name", obj.ToString());
                    command2.Parameters.AddWithValue("@id", StaticDataClass.IDQuestionnaire);
                    try
                    {
                        command2.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    connection.Close();
                }
            }
            else
            {
                string sqlUpdate = "UPDATE Questionnaire SET {0} WHERE ID_анкеты = @id";

                SqlConnection connection = new SqlConnection(Properties.Settings.Default.ApplicantsConnectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                string sqlValues = "";
                sqlValues += "Фамилия=@surname ";
                sqlValues += "Имя=@name ";
                sqlValues += "Отчество=@lastname ";
                sqlValues += "Пол=@sex ";
                sqlValues += "Год_окончания_обучения=@year ";
                sqlValues += "Номер_телефона=@phone ";
                sqlValues += "Дата_рождения=@birthday ";


                command.CommandText = String.Format(sqlUpdate, sqlValues);
                command.Parameters.AddWithValue("@surname", SurnameTextBox.Text);
                command.Parameters.AddWithValue("@name", NameTextBox.Text);
                command.Parameters.AddWithValue("@lastname", LastNameTextBox.Text);
                command.Parameters.AddWithValue("@sex", SexComboBox.SelectedText);
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@phone", PhoneTextBox.Text);
                command.Parameters.AddWithValue("@birthday", birthday);
                command.Parameters.AddWithValue("@Id", StaticDataClass.IDQuestionnaire);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
                this.questionnaireTableAdapter.Fill(this.applicantsDataSet.Questionnaire);

                foreach (string obj in SubjectsCheckedListBox.CheckedItems)
                {
                    sqlUpdate = "UPDATE SelectedSubject SET {0} WHERE ID_анкеты = @id";

                    connection = new SqlConnection(Properties.Settings.Default.ApplicantsConnectionString);
                    connection.Open();
                    SqlCommand command2 = connection.CreateCommand();
                    sqlValues = "";
                    sqlValues += "Название=@name ";
                    command.CommandText = String.Format(sqlUpdate, sqlValues);
                    command2.Parameters.AddWithValue("@name", obj.ToString());
                    command2.Parameters.AddWithValue("@id", StaticDataClass.IDQuestionnaire);
                    try
                    {
                        command2.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    connection.Close();
                }
            }

            /*QuestionnaireForm questionnaireForm = new QuestionnaireForm();
            questionnaireForm.Show();*/
            this.Close();
        }

        private void FacultiesButton_Click(object sender, EventArgs e)
        {
            FacultiesForm facultiesForm = new FacultiesForm();
            facultiesForm.Show();
            this.Close();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            QuestionnaireForm questionnaireForm = new QuestionnaireForm();
            questionnaireForm.Show();
            this.Close();
        }

        private void questionnaireBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.questionnaireBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.applicantsDataSet);

        }

        private void QuestionnaireUpdateForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "applicantsDataSet.Subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.applicantsDataSet.Subjects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "applicantsDataSet.SelectedSubject". При необходимости она может быть перемещена или удалена.
            this.selectedSubjectTableAdapter.Fill(this.applicantsDataSet.SelectedSubject);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "applicantsDataSet.Questionnaire". При необходимости она может быть перемещена или удалена.
            this.questionnaireTableAdapter.Fill(this.applicantsDataSet.Questionnaire);

            if (StaticDataClass.IsAdmin)
            {
                return;
            }

            FillAllVariants();

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
                    StaticDataClass.IDQuestionnaire = (int)ids[0];
                    SurnameTextBox.Text = (string)FillBoxes("Фамилия")[0];
                    NameTextBox.Text = (string)FillBoxes("Имя")[0];
                    LastNameTextBox.Text = (string)FillBoxes("Отчество")[0];
                    BirthdayTextBox.Text = (string)FillBoxes("Дата_рождения")[0];
                    SexComboBox.SelectedItem = (string)FillBoxes("Пол")[0];
                    YearTextBox.Text = (string)FillBoxes("Год_окончания_обучения")[0];
                    PhoneTextBox.Text = (string)FillBoxes("Номер_телефона")[0];
                    EmailTextBox.Text = StaticDataClass.Email;
                    SubjectsCheckedListBox.Items.Clear();
                    foreach (object obj in FillSubjects())
                    {
                        SubjectsCheckedListBox.SetItemChecked(SubjectsCheckedListBox.Items.IndexOf(obj.ToString()), true);
                    }
                }
            }
        }
        private List<object> FillBoxes(string atribute)
        {
            string sqlSelect = @"SELECT @atribute FROM Questionnaire WHERE @id = ID_анкеты";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.ApplicantsConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            try
            {
                command.Parameters.AddWithValue("@atribute", atribute);
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
                    objects.Add((int)cell);
                }
            }
            if (objects.Count != 0)
            {
                return objects;
            }
            return null;
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
        private void FillAllVariants()
        {
            SexComboBox.Items.Clear();
            SubjectsCheckedListBox.Items.Clear();
            SexComboBox.Items.Add("Мужской");
            SexComboBox.Items.Add("Женский");
            string sqlSelect = @"SELECT Название FROM [Subjects]";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.ApplicantsConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
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
            if (objects.Count != 0)
            {
                foreach (object obj in objects)
                {
                    SubjectsCheckedListBox.Items.Add(obj.ToString());
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FindIdQuestionnaire()
        {
            string sqlSelect = @"SELECT * FROM [Questionnaire] WHERE Номер_телефона = @phone AND Имя = @name AND Фамилия = @surname";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.ApplicantsConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            try
            {
                command.Parameters.AddWithValue("@phone", PhoneTextBox.Text);
                command.Parameters.AddWithValue("@name", NameTextBox.Text);
                command.Parameters.AddWithValue("@surname", SurnameTextBox.Text);
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
            if (ids.Count == 0)
            {
                MessageBox.Show("");
                return;
            }
            StaticDataClass.IDQuestionnaire = (int)ids[0];
        }
    }
}
