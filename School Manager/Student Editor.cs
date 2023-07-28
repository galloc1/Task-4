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
    public partial class Student_Editor : Form
    {
        //Reference to the start page
        private Start_Page startPage;
        public Student_Editor(Start_Page startPage_)
        {
            InitializeComponent();
            startPage = startPage_;
        }

        //End the application if this form is closed
        private void Student_Editor_Form_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Back button
        private void button1_Click(object sender, EventArgs e)
        {
            FormFns.SwitchForms(this, startPage.adminHomePage);
        }
        ///////////////////////////////
        ///To reference another form, use startPage.form, i.e. startPage.adminLogin or startPage.classEditor
    }
}
