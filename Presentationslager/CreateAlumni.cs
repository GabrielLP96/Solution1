using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Layer;
using Business_Layer;

namespace Presentationslager
{
    public partial class CreateAlumni : Form
    {


        public CreateAlumni()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateAdmin_Load(object sender, EventArgs e)
        {

        }

        private void Btn_previous_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (password_txtbox.Text == Cpassword_txtbox.Text)
            {
                               
                     
            string username = UserN_txtbox.Text;
            string password = password_txtbox.Text;
            string email = Fname_txtbox.Text;
            string fname = Fname_txtbox.Text;
            string lname = Lname_txtbox.Text;
            string snumber = Snr_txtbox.Text;
            string persCode = Pnr_txtbox.Text;

                Alumnus alumnus = new Alumnus();
                alumnus.Username = username;
                alumnus.PassW = password;
                alumnus.PersonCode = persCode;
                alumnus.FirstName = fname;
                alumnus.LastName = lname;
                alumnus.Email = email;
                
                
            }


        }
    }
}
