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
    public partial class EditClass : Form
    {
        private Class_Editor classEditor;
        private Class selectedClass;
        private BindingList<Student> studentsNotInClass;
        private BindingList<Student> studentsInClass;

        public EditClass(Class_Editor classEditor)
        {
            InitializeComponent();
            this.classEditor = classEditor;

            selectedClass = Start_Page.startPage.classes.ElementAt(classEditor.listBox1.SelectedIndex);
            studentsNotInClass = new BindingList<Student>();
            studentsInClass = selectedClass.students;

            textBox1.Text = selectedClass.name;
            listBox2.DataSource = studentsInClass;
            listBox2.DisplayMember = "fullName";

            for (int i = 0; i < Start_Page.startPage.students.Count; i++)
            {
                studentsNotInClass.Add(Start_Page.startPage.students.ElementAt(i));
            }

            for (int i = 0; i < studentsInClass.Count; i++)
            {
                studentsNotInClass.Remove(studentsInClass.ElementAt(i));
            }

            listBox1.DataSource = studentsNotInClass;
            listBox1.DisplayMember = "fullName";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fcreate = File.Open("./classes.txt", FileMode.Create);
            StreamWriter stream = new StreamWriter(fcreate);
            for(int i = 0; i<Start_Page.startPage.classes.Count; i++)
            {
                stream.WriteLine(Start_Page.startPage.classes.ElementAt(i).name);
                for (int j = 0; j < Start_Page.startPage.classes.ElementAt(i).students.Count; j++)
                {
                    stream.Write(Start_Page.startPage.classes.ElementAt(i).students.ElementAt(j).studentID);
                    if (j != Start_Page.startPage.classes.ElementAt(i).students.Count - 1)
                    {
                        stream.Write(",");
                        
                    }
                }
                stream.Write("-\n");
            }
            stream.Close();

            classEditor.listBox1.DisplayMember = null;
            classEditor.listBox1.DisplayMember = "name";
            classEditor.Show();
            this.Close();
        }

        private void EditClass_FormClosing(object sender, FormClosingEventArgs e)
        {
            classEditor.listBox1.DisplayMember = null;
            classEditor.listBox1.DisplayMember = "name";
            classEditor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count > 0)
            {
                studentsNotInClass.Add(studentsInClass.ElementAt(listBox2.SelectedIndex));
                studentsInClass.RemoveAt(listBox2.SelectedIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                studentsInClass.Add(studentsNotInClass.ElementAt(listBox1.SelectedIndex));
                studentsNotInClass.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            selectedClass.name = textBox1.Text;
        }
    }
}
