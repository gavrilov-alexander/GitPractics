namespace WindowsFormsApp1
{
    partial class QuestionnaireUpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.FacultiesButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.roundPanel1 = new WindowsFormsApp1.RoundPanel();
            this.OkRoundBtn = new WindowsFormsApp1.RoundBtn();
            this.SubjectsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SexComboBox = new System.Windows.Forms.ComboBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BirthdayTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.applicantsDataSet = new WindowsFormsApp1.ApplicantsDataSet();
            this.questionnaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionnaireTableAdapter = new WindowsFormsApp1.ApplicantsDataSetTableAdapters.QuestionnaireTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.ApplicantsDataSetTableAdapters.TableAdapterManager();
            this.selectedSubjectTableAdapter = new WindowsFormsApp1.ApplicantsDataSetTableAdapters.SelectedSubjectTableAdapter();
            this.subjectsTableAdapter = new WindowsFormsApp1.ApplicantsDataSetTableAdapters.SubjectsTableAdapter();
            this.selectedSubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.roundPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionnaireBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedSubjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(56)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.ProfileButton);
            this.panel1.Controls.Add(this.FacultiesButton);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 88);
            this.panel1.TabIndex = 15;
            // 
            // ProfileButton
            // 
            this.ProfileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(58)))));
            this.ProfileButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(58)))));
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.ProfileButton.Location = new System.Drawing.Point(1108, 14);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(163, 53);
            this.ProfileButton.TabIndex = 9;
            this.ProfileButton.Text = "ПРОФИЛЬ";
            this.ProfileButton.UseVisualStyleBackColor = false;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // FacultiesButton
            // 
            this.FacultiesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(58)))));
            this.FacultiesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(58)))));
            this.FacultiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FacultiesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FacultiesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.FacultiesButton.Location = new System.Drawing.Point(558, 14);
            this.FacultiesButton.Name = "FacultiesButton";
            this.FacultiesButton.Size = new System.Drawing.Size(163, 53);
            this.FacultiesButton.TabIndex = 8;
            this.FacultiesButton.Text = "ФАКУЛЬТЕТЫ";
            this.FacultiesButton.UseVisualStyleBackColor = false;
            this.FacultiesButton.Click += new System.EventHandler(this.FacultiesButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Tusur;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.roundPanel1.Controls.Add(this.OkRoundBtn);
            this.roundPanel1.Controls.Add(this.SubjectsCheckedListBox);
            this.roundPanel1.Controls.Add(this.SexComboBox);
            this.roundPanel1.Controls.Add(this.LastNameTextBox);
            this.roundPanel1.Controls.Add(this.label1);
            this.roundPanel1.Controls.Add(this.SurnameTextBox);
            this.roundPanel1.Controls.Add(this.label10);
            this.roundPanel1.Controls.Add(this.BirthdayTextBox);
            this.roundPanel1.Controls.Add(this.label9);
            this.roundPanel1.Controls.Add(this.PhoneTextBox);
            this.roundPanel1.Controls.Add(this.label8);
            this.roundPanel1.Controls.Add(this.NameTextBox);
            this.roundPanel1.Controls.Add(this.label7);
            this.roundPanel1.Controls.Add(this.EmailTextBox);
            this.roundPanel1.Controls.Add(this.label6);
            this.roundPanel1.Controls.Add(this.YearTextBox);
            this.roundPanel1.Controls.Add(this.label5);
            this.roundPanel1.Controls.Add(this.label2);
            this.roundPanel1.Controls.Add(this.label4);
            this.roundPanel1.Controls.Add(this.label3);
            this.roundPanel1.Location = new System.Drawing.Point(76, 141);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Radius = 150;
            this.roundPanel1.Size = new System.Drawing.Size(1128, 635);
            this.roundPanel1.TabIndex = 11;
            // 
            // OkRoundBtn
            // 
            this.OkRoundBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(58)))));
            this.OkRoundBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OkRoundBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.OkRoundBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.OkRoundBtn.Location = new System.Drawing.Point(427, 558);
            this.OkRoundBtn.Name = "OkRoundBtn";
            this.OkRoundBtn.Radius = 30;
            this.OkRoundBtn.Size = new System.Drawing.Size(274, 29);
            this.OkRoundBtn.TabIndex = 43;
            this.OkRoundBtn.Text = "СОХРАНИТЬ";
            this.OkRoundBtn.Click += new System.EventHandler(this.OkRoundBtn_Click);
            // 
            // SubjectsCheckedListBox
            // 
            this.SubjectsCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.SubjectsCheckedListBox.FormattingEnabled = true;
            this.SubjectsCheckedListBox.Items.AddRange(new object[] {
            "Физика",
            "Математика",
            "Информатика",
            "Русский Язык"});
            this.SubjectsCheckedListBox.Location = new System.Drawing.Point(761, 429);
            this.SubjectsCheckedListBox.Name = "SubjectsCheckedListBox";
            this.SubjectsCheckedListBox.Size = new System.Drawing.Size(208, 34);
            this.SubjectsCheckedListBox.TabIndex = 42;
            // 
            // SexComboBox
            // 
            this.SexComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "М",
            "Ж"});
            this.SexComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.5F);
            this.SexComboBox.FormattingEnabled = true;
            this.SexComboBox.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.SexComboBox.Location = new System.Drawing.Point(545, 288);
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.Size = new System.Drawing.Size(60, 52);
            this.SexComboBox.TabIndex = 40;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LastNameTextBox.Location = new System.Drawing.Point(761, 204);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(208, 20);
            this.LastNameTextBox.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 52F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(403, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 59);
            this.label1.TabIndex = 21;
            this.label1.Text = "МОЯ АНКЕТА";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameTextBox.Location = new System.Drawing.Point(159, 204);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(208, 20);
            this.SurnameTextBox.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label10.Location = new System.Drawing.Point(757, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 22);
            this.label10.TabIndex = 37;
            this.label10.Text = "ПРЕДМЕТЫ ЕГЭ";
            // 
            // BirthdayTextBox
            // 
            this.BirthdayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.BirthdayTextBox.Location = new System.Drawing.Point(159, 316);
            this.BirthdayTextBox.Name = "BirthdayTextBox";
            this.BirthdayTextBox.Size = new System.Drawing.Size(208, 20);
            this.BirthdayTextBox.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label9.Location = new System.Drawing.Point(456, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 22);
            this.label9.TabIndex = 36;
            this.label9.Text = "EMAIL*";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.PhoneTextBox.Location = new System.Drawing.Point(159, 429);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(208, 20);
            this.PhoneTextBox.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label8.Location = new System.Drawing.Point(155, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 22);
            this.label8.TabIndex = 35;
            this.label8.Text = "НОМЕР ТЕЛЕФОНА*";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.NameTextBox.Location = new System.Drawing.Point(460, 204);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(208, 20);
            this.NameTextBox.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.Location = new System.Drawing.Point(155, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 22);
            this.label7.TabIndex = 34;
            this.label7.Text = "ДАТА РОЖДЕНИЯ*";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.EmailTextBox.Location = new System.Drawing.Point(460, 429);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(208, 20);
            this.EmailTextBox.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.Location = new System.Drawing.Point(757, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 22);
            this.label6.TabIndex = 33;
            this.label6.Text = "ГОД ОКОНЧАНИЯ ОБУЧЕНИЯ*";
            // 
            // YearTextBox
            // 
            this.YearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.YearTextBox.Location = new System.Drawing.Point(761, 316);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(208, 20);
            this.YearTextBox.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(481, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "ПОЛ*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(155, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "ФАМИЛИЯ*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(757, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "ОТЧЕСТВО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(456, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 30;
            this.label3.Text = "ИМЯ*";
            // 
            // applicantsDataSet
            // 
            this.applicantsDataSet.DataSetName = "ApplicantsDataSet";
            this.applicantsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // questionnaireBindingSource
            // 
            this.questionnaireBindingSource.DataMember = "Questionnaire";
            this.questionnaireBindingSource.DataSource = this.applicantsDataSet;
            // 
            // questionnaireTableAdapter
            // 
            this.questionnaireTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DirectionTableAdapter = null;
            this.tableAdapterManager.FacultyTableAdapter = null;
            this.tableAdapterManager.QuestionnaireTableAdapter = this.questionnaireTableAdapter;
            this.tableAdapterManager.RequiredSubjectsTableAdapter = null;
            this.tableAdapterManager.SelectedSubjectTableAdapter = this.selectedSubjectTableAdapter;
            this.tableAdapterManager.SubjectsTableAdapter = this.subjectsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.ApplicantsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // selectedSubjectTableAdapter
            // 
            this.selectedSubjectTableAdapter.ClearBeforeFill = true;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // selectedSubjectBindingSource
            // 
            this.selectedSubjectBindingSource.DataMember = "SelectedSubject";
            this.selectedSubjectBindingSource.DataSource = this.applicantsDataSet;
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "Subjects";
            this.subjectsBindingSource.DataSource = this.applicantsDataSet;
            // 
            // QuestionnaireUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roundPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuestionnaireUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.QuestionnaireUpdateForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionnaireBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedSubjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RoundPanel roundPanel1;
        private System.Windows.Forms.ComboBox SexComboBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox BirthdayTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox SubjectsCheckedListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button FacultiesButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RoundBtn OkRoundBtn;
        private ApplicantsDataSet applicantsDataSet;
        private System.Windows.Forms.BindingSource questionnaireBindingSource;
        private ApplicantsDataSetTableAdapters.QuestionnaireTableAdapter questionnaireTableAdapter;
        private ApplicantsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ApplicantsDataSetTableAdapters.SelectedSubjectTableAdapter selectedSubjectTableAdapter;
        private System.Windows.Forms.BindingSource selectedSubjectBindingSource;
        private ApplicantsDataSetTableAdapters.SubjectsTableAdapter subjectsTableAdapter;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
    }
}