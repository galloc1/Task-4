//SACE: 933898F, 9/03/2023
using System.ComponentModel;

namespace School_Manager
{
    public static class FormFns
    {
        public static void SwitchForms(Form thisForm, Form targetForm)
        {
            targetForm.Show();
            thisForm.Hide();
        }
    }
    public class Teacher
    {
        public string staffID { get; set; }
        public string password { get; set; }
        public Teacher(string staffID, string password)
        {
            this.staffID = staffID;
            this.password = password;
        }
    }
    public class Class
    {
        public string name { get; set; }
        public BindingList<Student> students { get; set; }
        public Class(string name, BindingList<Student> students)
        {
            this.name = name;
            this.students = students;
        }
    }
}
