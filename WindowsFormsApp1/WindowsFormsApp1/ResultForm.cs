﻿using System;
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
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            StaticDataClass.ShowProfileForm(this);
        }

        private void FacultiesButton_Click(object sender, EventArgs e)
        {
            FacultiesForm facultiesForm = new FacultiesForm();
            facultiesForm.Show();
            this.Close();
        }
    }
}
