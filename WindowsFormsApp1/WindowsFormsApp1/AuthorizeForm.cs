using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AuthorizeForm : Form
    {
        public AuthorizeForm()
        {
            InitializeComponent();
        }

        private void OkRoundBtn_Click(object sender, EventArgs e)
        {
            string sqlSelect = @"SELECT * FROM [User] WHERE Email = @email AND Пароль = @password";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.ApplicantsConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            try
            {
                command.Parameters.AddWithValue("@email", EmailTextBox.Text);
                command.Parameters.AddWithValue("@password", PasswordTextBox.Text);
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
            StaticDataClass.IDProfile = (int)ids[0];
            StaticDataClass.Email = EmailTextBox.Text;
            StaticDataClass.IsAdmin = (bool)ids[1];
            FindIdQuestionnaire();
            try
            {
                
            }
            catch { }


            this.Close();
        }

        private void RegistrationRoundBtn_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Close();
        }

        private void AuthorizeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "applicantsDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.applicantsDataSet.User);

        }
        private void FindIdQuestionnaire()
        {
            string sqlSelect = @"SELECT ID_анкеты FROM [User] WHERE ID_пользователя = @id";
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
            if (ids.Count == 0)
            {
                MessageBox.Show("Ошибка");
                return;
            }
            try
            {
                StaticDataClass.IDQuestionnaire = (int)ids[0];
            }
            catch
            {

            }
        }
    }
}
