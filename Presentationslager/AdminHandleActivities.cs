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
    public partial class AdminHandleActivities : Form
    {
        public AdminHandleActivities()
        {
            InitializeComponent();
        }

        private void Btn_previous_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            AdminEditActivities adminEditActivities = new AdminEditActivities 
        }
    }
}
