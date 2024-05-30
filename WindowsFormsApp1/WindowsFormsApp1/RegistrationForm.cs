using System.Data.SqlClient;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

namespace WindowsFormsApp1
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void OkRoundBtn_Click(object sender, System.EventArgs e)
        {
            if ((StaticDataClass.IDProfile != -1))
            {
                MessageBox.Show("Ошибка");
                return;
            }
            if (EmailTextBox.Text == String.Empty)
            {
                MessageBox.Show("Ошибка");
                return;
            }
            if (PasswordTextBox.Text == String.Empty)
            {
                MessageBox.Show("Ошибка");
                return;
            }
            if (PasswordTextBox.Text != RepeatPasswordTextBox.Text)
            {
                MessageBox.Show("Ошибка");
                return;
            }

            string sqlInsert = @"INSERT INTO [User] (Админ, Email, Пароль)
                                VALUES (@admin, @email, @password)";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.ApplicantsConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;
            command.Parameters.AddWithValue("@admin", false);
            command.Parameters.AddWithValue("@email", EmailTextBox.Text);
            command.Parameters.AddWithValue("@password", PasswordTextBox.Text);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();


            string sqlSelect = @"SELECT ID_пользователя FROM [User] WHERE @email = Email";
            SqlConnection connection2 = new SqlConnection(Properties.Settings.Default.ApplicantsConnectionString);
            SqlCommand command2 = connection2.CreateCommand();
            command2.CommandText = sqlSelect;
            try
            {
                command2.Parameters.AddWithValue("@email", EmailTextBox.Text);
            }
            catch
            {
                MessageBox.Show("", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command2;
            DataTable table = new DataTable();
            adapter.Fill(table);
            List<int> ids = new List<int>();
            foreach (DataRow row in table.Rows)
            {
                var cells = row.ItemArray;
                foreach (object cell in cells)
                {
                    ids.Add((int)cell);
                }
            }
            StaticDataClass.IDProfile = ids[0];
            StaticDataClass.Email = EmailTextBox.Text;

            QuestionnaireUpdateForm questionnaireUpdateForm = new QuestionnaireUpdateForm();
            questionnaireUpdateForm.Show();
            this.Close();
        }

        private void RegistrationForm_Load(object sender, System.EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "applicantsDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.applicantsDataSet.User);

        }
    }
}
