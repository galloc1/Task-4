using System.ComponentModel;

namespace School_Manager
{
    public partial class Roll_Call : Form
    {
        private Start_Page startPage;
        public BindingList<Student> students;
        public Roll_Call(Start_Page startPage_)
        {
            InitializeComponent();
            startPage = startPage_;
        }

        //Gives the selected student the status 'Present' and moves selection to next student
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Student student = students.ElementAt(listBox1.SelectedIndex);
                student.status = " (Present)";
                student.statusName = student.fullName + student.status;

                students[listBox1.SelectedIndex] = students.ElementAt(listBox1.SelectedIndex);
                if (listBox1.Items.Count > listBox1.SelectedIndex + 1)
                {
                    listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
                }
            }
            else
            {
                MessageBox.Show("No student selected", "Null Student");
            }
        }

        //Gives the selected student the status 'Absent' and moves selection to next student
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Student student = students.ElementAt(listBox1.SelectedIndex);
                student.status = " (Absent)";
                student.statusName = student.fullName + student.status;

                students[listBox1.SelectedIndex] = students.ElementAt(listBox1.SelectedIndex);
                if (listBox1.Items.Count > listBox1.SelectedIndex + 1)
                {
                    listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
                }
            }
            else
            {
                MessageBox.Show("No student selected", "Null Student");
            }
        }

        //Closes the application
        private void Roll_Call_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<students.Count; i++)
            {
                Student student = students[i];
                student.status = "";
                student.statusName = student.fullName + student.status;
                students[i] = student;
            }
            listBox1.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter stream = new StreamWriter(listBox2.Text + " " + dateTimePicker1.Value.Day.ToString() + " " + dateTimePicker1.Value.Month.ToString() + " " + dateTimePicker1.Value.Year.ToString()+".txt");

            stream.WriteLine(DateTime.Now.ToString());
            for (int i = 0; i < students.Count; i++)
            {
                stream.WriteLine(students[i].statusName);
                Console.WriteLine(students[i].statusName);
            }
            stream.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new FormFns().SwitchForms(this, startPage.teacherHomePage);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(listBox2.Text + " " + dateTimePicker1.Value.Day.ToString() + " " + dateTimePicker1.Value.Month.ToString() + " " + dateTimePicker1.Value.Year.ToString() + ".txt");

                sr.ReadLine();
                for (int i = 0; i < students.Count; i++)
                {
                    students[i].statusName = sr.ReadLine();
                }
                sr.Close();
            }
            catch (FileNotFoundException)
            {

            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            students = startPage.classes.ElementAt(listBox2.SelectedIndex).students;
            listBox1.DataSource = students;
            listBox1.DisplayMember = "statusName";

            try
            {
                StreamReader sr = new StreamReader(listBox2.Text +" "+ dateTimePicker1.Value.Day.ToString() + " " + dateTimePicker1.Value.Month.ToString() + " " + dateTimePicker1.Value.Year.ToString() + ".txt");

                sr.ReadLine();
                for (int i = 0; i<students.Count; i++)
                {
                    students[i].statusName = sr.ReadLine();
                }
                sr.Close();
            }
            catch (FileNotFoundException)
            {

            }
        }
    }
}
