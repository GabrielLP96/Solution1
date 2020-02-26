using System;
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
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Btn_admin_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            LogInadmin logInadmin = new LogInadmin();
            if (logInadmin.ShowDialog() == DialogResult.OK)
                this.Visible = !this.Visible;
                      
        }

        private void Btn_alumni_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            Log_in_Alumni log_In_Alumni = new Log_in_Alumni();
            if (log_In_Alumni.ShowDialog() == DialogResult.OK)
                this.Visible = !this.Visible;
                      
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_createNewAdmin_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            CreateAdmin createAdmin = new CreateAdmin();
            if (createAdmin.ShowDialog() == DialogResult.OK)
                this.Visible = !this.Visible;
            
           
        }

        private void Btn_createnewAlumni_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            CreateAlumni createAlumni = new CreateAlumni();
            if (createAlumni.ShowDialog() == DialogResult.OK)
                this.Visible = !this.Visible;
        }
    }
}
