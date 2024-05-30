using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FacultiesForm : Form
    {
        public FacultiesForm()
        {
            InitializeComponent();
        }

        private void OkRoundBtn_Click(object sender, EventArgs e)
        {
            if (StaticDataClass.IDProfile == -1)
            {
                MessageBox.Show("Ошибка");
                return;
            }
            if (StaticDataClass.IDQuestionnaire == -1)
            {
                MessageBox.Show("Ошибка");
                return;
            }
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;

            string sqlSelect = @"SELECT f.Название FROM Faculty as f, Direction as d, RequiredSubjects as rs, Subjects as s, SelectedSubject as ss
                            WHERE @id = ss.ID_анкеты AND ss.Название = s.Название 
                            AND s.Название = rs.Название AND rs.Код_направления = d.Код_направления 
                            AND d.Название_факультета = f.Название
                            GROUP BY f.Название";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.ApplicantsConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            try
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = StaticDataClass.IDQuestionnaire;
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
            List<string> faculties = new List<string>();
            foreach (DataRow row in table.Rows)
            {
                var cells = row.ItemArray;
                foreach (object cell in cells)
                {
                    faculties.Add(cell.ToString());
                }
            }
            foreach (string faculty in faculties)
            {
                switch (faculty)
                {
                    case "РТФ":
                        {
                            button4.Enabled = true;
                            break;
                        }
                    case "ФВС":
                        {
                            button5.Enabled = true;
                            break;
                        }
                    case "ФЭТ":
                        {
                            button6.Enabled = true;
                            break;
                        }
                    case "ЭФ":
                        {
                            button7.Enabled = true;
                            break;
                        }
                    case "ЮФ":
                        {
                            button8.Enabled = true;
                            break;
                        }
                    case "ФБ":
                        {
                            button9.Enabled = true;
                            break;
                        }
                    case "ГФ":
                        {
                            button10.Enabled = true;
                            break;
                        }
                    case "ФИТ":
                        {
                            button11.Enabled = true;
                            break;
                        }
                    case "ФСУ":
                        {
                            button12.Enabled = true;
                            break;
                        }
                    case "РКФ":
                        {
                            button13.Enabled = true;
                            break;
                        }
                }
            }

            /*ResultForm resultForm = new ResultForm();
            resultForm.Show();
            this.Close();*/
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            StaticDataClass.ShowProfileForm(this);
        }

        private void facultyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facultyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.applicantsDataSet);

        }

        private void FacultiesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "applicantsDataSet.SelectedSubject". При необходимости она может быть перемещена или удалена.
            this.selectedSubjectTableAdapter.Fill(this.applicantsDataSet.SelectedSubject);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "applicantsDataSet.Subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.applicantsDataSet.Subjects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "applicantsDataSet.RequiredSubjects". При необходимости она может быть перемещена или удалена.
            this.requiredSubjectsTableAdapter.Fill(this.applicantsDataSet.RequiredSubjects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "applicantsDataSet.Questionnaire". При необходимости она может быть перемещена или удалена.
            this.questionnaireTableAdapter.Fill(this.applicantsDataSet.Questionnaire);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "applicantsDataSet.Faculty". При необходимости она может быть перемещена или удалена.
            this.facultyTableAdapter.Fill(this.applicantsDataSet.Faculty);

        }

        private void roundBtn1_Click(object sender, EventArgs e)
        {
            OkRoundBtn_Click(sender, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
