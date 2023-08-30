﻿//SACE: 933898F, 9/03/2023

namespace School_Manager
{
    public partial class Class_Editor : Form
    {
        private Start_Page startPage;
        public Class_Editor(Start_Page startPage_)
        {
            InitializeComponent();
            startPage = startPage_;
        }

        //Opens teacher home page and closes this form
        private void button1_Click(object sender, EventArgs e)
        {
            FormFns.SwitchForms(this, startPage.adminHomePage);
        }

        //Opens roll call for selected class
        private void button6_Click(object sender, EventArgs e)
        {
            /*
            startPage.rollCall.students = startPage.classes.ElementAt(listBox1.SelectedIndex).students;
            startPage.rollCall.listBox1.DataSource = startPage.classes.ElementAt(listBox1.SelectedIndex).students;

            startPage.rollCall.listBox1.DisplayMember = "statusName";

            FormFns.SwitchForms(this, startPage.rollCall);
            */
        }

        //Closes the application
        private void Class_Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditClass editClass = new EditClass(this);
            editClass.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            New_Class newClass = new New_Class(this);
            newClass.Show();
        }
    }
}