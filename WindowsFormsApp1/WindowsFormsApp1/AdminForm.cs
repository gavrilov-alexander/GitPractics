using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "applicantsDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.applicantsDataSet.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "applicantsDataSet.Questionnaire". При необходимости она может быть перемещена или удалена.
            this.questionnaireTableAdapter.Fill(this.applicantsDataSet.Questionnaire);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "applicantsDataSet.SelectedSubject". При необходимости она может быть перемещена или удалена.
            this.selectedSubjectTableAdapter.Fill(this.applicantsDataSet.SelectedSubject);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "applicantsDataSet.Subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.applicantsDataSet.Subjects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "applicantsDataSet.RequiredSubjects". При необходимости она может быть перемещена или удалена.
            this.requiredSubjectsTableAdapter.Fill(this.applicantsDataSet.RequiredSubjects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "applicantsDataSet.Direction". При необходимости она может быть перемещена или удалена.
            this.directionTableAdapter.Fill(this.applicantsDataSet.Direction);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "applicantsDataSet.Faculty". При необходимости она может быть перемещена или удалена.
            this.facultyTableAdapter.Fill(this.applicantsDataSet.Faculty);

        }

        private void toolStripButton42_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.applicantsDataSet);
        }

        private void toolStripButton35_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.questionnaireBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.applicantsDataSet);
        }

        private void toolStripButton28_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.selectedSubjectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.applicantsDataSet);
        }

        private void toolStripButton21_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.subjectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.applicantsDataSet);
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.requiredSubjectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.applicantsDataSet);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.directionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.applicantsDataSet);
        }

        private void facultyBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.facultyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.applicantsDataSet);
        }
    }
}
