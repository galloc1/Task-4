using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace School_Manager
{
    public partial class Admin_Login : Form
    {
        private Start_Page startPage;
        public Admin_Login(Start_Page startPage_)
        {
            InitializeComponent();
            startPage = startPage_;
        }

        //Opens the start page and closes this form
        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            new FormFns().SwitchForms(this, startPage);
        }

        //Opens the teacher home page and closes this form if entered credentials are correct
        private void button2_Click(object sender, EventArgs e)
        {
            bool valid = false;
            Teacher newTeacherTemp = new Teacher(textBox1.Text, textBox2.Text);
            for (int i = 0; i < startPage.teachers.Count; i++)
            {
                if (newTeacherTemp.staffID == startPage.teachers[i].staffID && newTeacherTemp.password == startPage.teachers[i].password)
                {
                    valid = true;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    new FormFns().SwitchForms(this, startPage.teacherHomePage);
                }
            }
            if (!valid)
            {
                MessageBox.Show("Invalid ID and/or password.", "Invalid Credentials", MessageBoxButtons.OK);
            }
        }

        private void Admin_Login_Load(object sender, EventArgs e)
        {

        }

        private void Admin_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
