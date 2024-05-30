namespace WindowsFormsApp1
{
    partial class FacultiesForm
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
            this.OkRoundBtn = new WindowsFormsApp1.RoundBtn();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.applicantsDataSet = new WindowsFormsApp1.ApplicantsDataSet();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultyTableAdapter = new WindowsFormsApp1.ApplicantsDataSetTableAdapters.FacultyTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.ApplicantsDataSetTableAdapters.TableAdapterManager();
            this.questionnaireTableAdapter = new WindowsFormsApp1.ApplicantsDataSetTableAdapters.QuestionnaireTableAdapter();
            this.requiredSubjectsTableAdapter = new WindowsFormsApp1.ApplicantsDataSetTableAdapters.RequiredSubjectsTableAdapter();
            this.selectedSubjectTableAdapter = new WindowsFormsApp1.ApplicantsDataSetTableAdapters.SelectedSubjectTableAdapter();
            this.subjectsTableAdapter = new WindowsFormsApp1.ApplicantsDataSetTableAdapters.SubjectsTableAdapter();
            this.questionnaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requiredSubjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectedSubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionnaireBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requiredSubjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedSubjectBindingSource)).BeginInit();
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
            this.panel1.TabIndex = 31;
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
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Tusur;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(226, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // OkRoundBtn
            // 
            this.OkRoundBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(58)))));
            this.OkRoundBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OkRoundBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.OkRoundBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.OkRoundBtn.Location = new System.Drawing.Point(390, 759);
            this.OkRoundBtn.Name = "OkRoundBtn";
            this.OkRoundBtn.Radius = 30;
            this.OkRoundBtn.Size = new System.Drawing.Size(500, 29);
            this.OkRoundBtn.TabIndex = 23;
            this.OkRoundBtn.Text = "ПОСМОТРЕТЬ СВОЙ РЕЗУЛЬТАТЫ";
            this.OkRoundBtn.Click += new System.EventHandler(this.OkRoundBtn_Click);
            // 
            // button9
            // 
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(135)))), ((int)(((byte)(152)))));
            this.button9.Image = global::WindowsFormsApp1.Properties.Resources.FB;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(701, 609);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(321, 89);
            this.button9.TabIndex = 30;
            this.button9.Text = "ФАКУЛЬТЕТ БЕЗОПАСНОСТИ";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(176)))), ((int)(((byte)(239)))));
            this.button10.Image = global::WindowsFormsApp1.Properties.Resources.GF;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(701, 519);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(321, 89);
            this.button10.TabIndex = 29;
            this.button10.Text = "ГУМАНИТАРНЫЙ ФАКУЛЬТЕТ";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(37)))), ((int)(((byte)(143)))));
            this.button11.Image = global::WindowsFormsApp1.Properties.Resources.FIT;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(701, 429);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(321, 89);
            this.button11.TabIndex = 28;
            this.button11.Text = "ФАКУЛЬТЕТ\nИННОВАЦИОННЫХ ТЕХНОЛОГИЙ";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(14)))));
            this.button12.Image = global::WindowsFormsApp1.Properties.Resources.FSU;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(701, 327);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(305, 89);
            this.button12.TabIndex = 27;
            this.button12.Text = "ФАКУЛЬТЕТ СИСТЕМ УПРАВЛЕНИЯ";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(75)))));
            this.button13.Image = global::WindowsFormsApp1.Properties.Resources.RKF;
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(701, 231);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(391, 89);
            this.button13.TabIndex = 26;
            this.button13.Text = "РАДИОКОНСТРУКТОРСКИЙ ФАКУЛЬТЕТ";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.button8.Image = global::WindowsFormsApp1.Properties.Resources.URF;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(214, 609);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(321, 89);
            this.button8.TabIndex = 25;
            this.button8.Text = "ЮРИДИЧЕСКИЙ ФАКУЛЬТЕТ";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(171)))), ((int)(((byte)(173)))));
            this.button7.Image = global::WindowsFormsApp1.Properties.Resources.EF;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(214, 519);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(321, 89);
            this.button7.TabIndex = 24;
            this.button7.Text = "ЭКОНОМИЧЕСКИЙ ФАКУЛЬТЕТ";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.button6.Image = global::WindowsFormsApp1.Properties.Resources.FET;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(214, 429);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(321, 89);
            this.button6.TabIndex = 23;
            this.button6.Text = "ФАКУЛЬТЕТ\nЭЛЕКТРОННОЙ ТЕХНИКИ";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(41)))));
            this.button5.Image = global::WindowsFormsApp1.Properties.Resources.FVS;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(214, 327);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(321, 89);
            this.button5.TabIndex = 22;
            this.button5.Text = "ФАКУЛЬТЕТ\nВЫЧИСЛИТЕЛЬНЫХ СИСТЕМ";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(57)))), ((int)(((byte)(144)))));
            this.button4.Image = global::WindowsFormsApp1.Properties.Resources.RTF;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(214, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(321, 89);
            this.button4.TabIndex = 21;
            this.button4.Text = "РАДИОТЕХНИЧЕСКИЙ\r\nФАКУЛЬТЕТ";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // applicantsDataSet
            // 
            this.applicantsDataSet.DataSetName = "ApplicantsDataSet";
            this.applicantsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataMember = "Faculty";
            this.facultyBindingSource.DataSource = this.applicantsDataSet;
            // 
            // facultyTableAdapter
            // 
            this.facultyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DirectionTableAdapter = null;
            this.tableAdapterManager.FacultyTableAdapter = this.facultyTableAdapter;
            this.tableAdapterManager.QuestionnaireTableAdapter = this.questionnaireTableAdapter;
            this.tableAdapterManager.RequiredSubjectsTableAdapter = this.requiredSubjectsTableAdapter;
            this.tableAdapterManager.SelectedSubjectTableAdapter = this.selectedSubjectTableAdapter;
            this.tableAdapterManager.SubjectsTableAdapter = this.subjectsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.ApplicantsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // questionnaireTableAdapter
            // 
            this.questionnaireTableAdapter.ClearBeforeFill = true;
            // 
            // requiredSubjectsTableAdapter
            // 
            this.requiredSubjectsTableAdapter.ClearBeforeFill = true;
            // 
            // selectedSubjectTableAdapter
            // 
            this.selectedSubjectTableAdapter.ClearBeforeFill = true;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // questionnaireBindingSource
            // 
            this.questionnaireBindingSource.DataMember = "Questionnaire";
            this.questionnaireBindingSource.DataSource = this.applicantsDataSet;
            // 
            // requiredSubjectsBindingSource
            // 
            this.requiredSubjectsBindingSource.DataMember = "RequiredSubjects";
            this.requiredSubjectsBindingSource.DataSource = this.applicantsDataSet;
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "Subjects";
            this.subjectsBindingSource.DataSource = this.applicantsDataSet;
            // 
            // selectedSubjectBindingSource
            // 
            this.selectedSubjectBindingSource.DataMember = "SelectedSubject";
            this.selectedSubjectBindingSource.DataSource = this.applicantsDataSet;
            // 
            // FacultiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.OkRoundBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacultiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FacultiesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionnaireBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requiredSubjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedSubjectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button FacultiesButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RoundBtn OkRoundBtn;
        private ApplicantsDataSet applicantsDataSet;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private ApplicantsDataSetTableAdapters.FacultyTableAdapter facultyTableAdapter;
        private ApplicantsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ApplicantsDataSetTableAdapters.QuestionnaireTableAdapter questionnaireTableAdapter;
        private System.Windows.Forms.BindingSource questionnaireBindingSource;
        private ApplicantsDataSetTableAdapters.RequiredSubjectsTableAdapter requiredSubjectsTableAdapter;
        private System.Windows.Forms.BindingSource requiredSubjectsBindingSource;
        private ApplicantsDataSetTableAdapters.SubjectsTableAdapter subjectsTableAdapter;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private ApplicantsDataSetTableAdapters.SelectedSubjectTableAdapter selectedSubjectTableAdapter;
        private System.Windows.Forms.BindingSource selectedSubjectBindingSource;
    }
}