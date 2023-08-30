using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace School_Manager
{
    public partial class Student_Editor : Form
    {
        //Reference to the start page
        private Start_Page startPage;
        string filePath = @".\students.txt";
        public Student_Editor(Start_Page startPage_)
        {
            InitializeComponent();
            startPage = startPage_;

            //Reading from "students.txt" to extract and store student info
            StreamReader sr = new StreamReader(filePath);
            for (int i = 1; i < 31; i++)
            {
                string studentID = sr.ReadLine();
                string firstName = sr.ReadLine();
                string lastName = sr.ReadLine();
                string middleName = sr.ReadLine();
                string gender = sr.ReadLine();
                string DOB = sr.ReadLine();
                string email = sr.ReadLine();
                string mobile = sr.ReadLine();
                Student tempStudent = new Student(studentID, firstName, lastName, middleName, gender, DOB, email, mobile, "");
                Start_Page.startPage.students.Add(tempStudent);
            }
            sr.Close();
            listBox1.DataSource = Start_Page.startPage.students;
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

        //Save Button
        private void button2_Click(object sender, EventArgs e)
        {
            //Changes the student's information based on the input fields
            Start_Page.startPage.students[listBox1.SelectedIndex].firstName = textBox1.Text;
            Start_Page.startPage.students[listBox1.SelectedIndex].lastName = textBox2.Text;
            Start_Page.startPage.students[listBox1.SelectedIndex].middleName = textBox3.Text;
            Start_Page.startPage.students[listBox1.SelectedIndex].gender = textBox4.Text;
            Start_Page.startPage.students[listBox1.SelectedIndex].dateOfBirth = textBox5.Text;
            Start_Page.startPage.students[listBox1.SelectedIndex].email = textBox6.Text;
            Start_Page.startPage.students[listBox1.SelectedIndex].phone = textBox7.Text;
            Start_Page.startPage.students[listBox1.SelectedIndex].fullName = Start_Page.startPage.students[listBox1.SelectedIndex].firstName + " " + Start_Page.startPage.students[listBox1.SelectedIndex].lastName;
            Start_Page.startPage.students[listBox1.SelectedIndex].statusName = Start_Page.startPage.students[listBox1.SelectedIndex].fullName + Start_Page.startPage.students[listBox1.SelectedIndex].status;

            //Writes the student's information to students.txt
            FileStream fcreate = File.Open(filePath, FileMode.Create);
            StreamWriter stream = new StreamWriter(fcreate);
            for(int i = 0; i< Start_Page.startPage.students.Count; i++)
            {
                stream.WriteLine(Start_Page.startPage.students[i].studentID);
                stream.WriteLine(Start_Page.startPage.students[i].firstName);
                stream.WriteLine(Start_Page.startPage.students[i].lastName);
                stream.WriteLine(Start_Page.startPage.students[i].middleName);
                stream.WriteLine(Start_Page.startPage.students[i].gender);
                stream.WriteLine(Start_Page.startPage.students[i].dateOfBirth);
                stream.WriteLine(Start_Page.startPage.students[i].email);
                stream.WriteLine(Start_Page.startPage.students[i].phone);
            }
            stream.Close();

            listBox1.DisplayMember = null;
            listBox1.DisplayMember = "fullName";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Displays the info of the currently selected student in each of the input fields
            textBox1.Text = Start_Page.startPage.students[listBox1.SelectedIndex].firstName;
            textBox2.Text = Start_Page.startPage.students[listBox1.SelectedIndex].lastName;
            textBox3.Text = Start_Page.startPage.students[listBox1.SelectedIndex].middleName;
            textBox4.Text = Start_Page.startPage.students[listBox1.SelectedIndex].gender;
            textBox5.Text = Start_Page.startPage.students[listBox1.SelectedIndex].dateOfBirth;
            textBox6.Text = Start_Page.startPage.students[listBox1.SelectedIndex].email;
            textBox7.Text = Start_Page.startPage.students[listBox1.SelectedIndex].phone;
        }
    }
}
