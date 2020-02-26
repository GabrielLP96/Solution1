﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentationslager
{
    public partial class LoggInForm : Form
    {
        public LoggInForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Btn_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInadmin f1 = new LogInadmin();
            f1.ShowDialog();
        }

        private void Btn_alumni_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_in_Alumni f2 = new Log_in_Alumni();
            f2.ShowDialog();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_createNewAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}
