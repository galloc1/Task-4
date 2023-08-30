/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace School_Manager
{
    public class Student
    {
        public string studentID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string fullName { get; set; }
        public string gender { get; set; }
        public string dateOfBirth { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string status { get; set; }
        public string statusName { get; set; }
        public Student(string studentID, string firstName, string lastName, string middleName, string gender, string dateOfBirth, string email, string phone, string status)
        {
            this.studentID = studentID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.middleName = middleName;
            this.fullName = firstName + " " + lastName;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.email = email;
            this.phone = phone;
            this.status = status;
            this.statusName = this.fullName + status;
        }

        public string GetStudentInfoAsString()
        {
            string s = studentID;
            s += "\n";
            s += firstName;
            s += "\n";
            s += lastName;
            s += "\n";
            s += middleName;
            s += "\n";
            s += gender;
            s += "\n";
            s += dateOfBirth;
            s += "\n";
            s += email;
            s += "\n";
            s += phone;
            return s;
        }
    }
}
