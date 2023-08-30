﻿//SACE: 933898F, 9/03/2023
using System.ComponentModel;
using System.Windows.Forms;

namespace School_Manager
{
    public partial class Start_Page : Form
    {
        //Objects
        public List<Teacher> teachers;
        public BindingList<Student> students = new BindingList<Student>();
        public BindingList<Class> classes;

        //Forms
        public static Start_Page startPage;
        public Teacher_Login teacherLogin;
        public Teacher_Home_Page teacherHomePage;
        public Roll_Call rollCall;
        public Admin_Login adminLogin;
        public Admin_Home_Page adminHomePage;
        public Student_Editor studentEditor;
        public Class_Editor classEditor;

        public Start_Page()
        {
            InitializeComponent();
        }

        //Opens teacher login form and closes this form
        private void button1_Click(object sender, EventArgs e)
        {
            FormFns.SwitchForms(this, teacherLogin);
        }

        private void Start_Page_Load(object sender, EventArgs e)
        {
            //Creating instances of each form
            startPage = this;
            teacherLogin = new Teacher_Login(this);
            teacherHomePage = new Teacher_Home_Page(this);
            rollCall = new Roll_Call(this);
            adminLogin = new Admin_Login(this);
            adminHomePage = new Admin_Home_Page(this);
            studentEditor = new Student_Editor(this);
            classEditor = new Class_Editor(this);

            //Assigning lists to store objects, i.e. students, classes, etc
            teachers = new List<Teacher>();
            classes = new BindingList<Class>();

            //Reading from file to reference teachers information
            StreamReader credentials = new StreamReader("credentials.txt");
            while (!credentials.EndOfStream)
            {
                Teacher newTeacherTemp = new Teacher(credentials.ReadLine(), credentials.ReadLine());
                teachers.Add(newTeacherTemp);
            }

            //Reading from file to reference students information
            StreamReader studentsStream = new StreamReader("students.txt");
            while (!studentsStream.EndOfStream)
            {
                Student newStudentTemp = new Student(studentsStream.ReadLine(), studentsStream.ReadLine(), studentsStream.ReadLine(), studentsStream.ReadLine(), studentsStream.ReadLine(), studentsStream.ReadLine(), studentsStream.ReadLine(), studentsStream.ReadLine(), "");
                students.Add(newStudentTemp);
            }

            //Reading from file to reference classes information
            StreamReader classesStream = new StreamReader("classes.txt");
            while (!classesStream.EndOfStream)
            {
                string newClassNameTemp = classesStream.ReadLine();
                BindingList<Student> newClassStudentsTemp = new BindingList<Student>();
                bool reading = true;
                string nextStudent = "";
                while (reading)
                {
                    Char nextChar = Convert.ToChar(classesStream.Read());

                    if (Char.IsNumber(nextChar))
                    {
                        nextStudent += Char.ToString(nextChar);
                    }
                    else if (nextChar.Equals(','))
                    {
                        newClassStudentsTemp.Add(students[Convert.ToInt32(nextStudent) - 1]);
                        nextStudent = "";
                    }
                    else if (nextChar.Equals('-'))
                    {
                        if (nextStudent != "")
                        {
                            newClassStudentsTemp.Add(students[Convert.ToInt32(nextStudent) - 1]);
                        }
                        classesStream.ReadLine();
                        reading = false;
                    }
                }
                classes.Add(new Class(newClassNameTemp, newClassStudentsTemp));
            }

            //Closing streamreaders
            credentials.Close();
            studentsStream.Close();
            classesStream.Close();

            //Populates listboxes
            rollCall.listBox2.DataSource = classes;
            rollCall.listBox2.DisplayMember = "name";
            classEditor.listBox1.DataSource = classes;
            classEditor.listBox1.DisplayMember = "name";
        }

        //Closes the application
        private void Start_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormFns.SwitchForms(this, adminLogin);
        }
    }
}