using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Manager
{
    public partial class Admin_Home_Page : Form
    {
        private Start_Page startPage;
        public Admin_Home_Page(Start_Page startPage_)
        {
            InitializeComponent();
            startPage = startPage_;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Asks user if they are sure they want to log out
            DialogResult logOut = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo);

            //If yes, open the start page and close this form
            if (logOut == DialogResult.Yes)
            {
                FormFns.SwitchForms(this, startPage);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormFns.SwitchForms(this, startPage.studentEditor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormFns.SwitchForms(this, startPage.classEditor);
        }
    }
}
