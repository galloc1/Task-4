//SACE: 933898F, 9/03/2023

namespace School_Manager
{
    public partial class Teacher_Home_Page : Form
    {
        private Start_Page startPage;
        public Teacher_Home_Page(Start_Page startPage_)
        {
            InitializeComponent();
            startPage = startPage_;
        }

        //Handles user asking to log out
        private void button1_Click(object sender, EventArgs e)
        {
            //Asks user if they are sure they want to log out
            DialogResult logOut = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo);

            //If yes, open the start page and close this form
            if (logOut == DialogResult.Yes)
            {
                FormFns.SwitchForms(this, startPage);
            }
        }

        //Opens class editor and closes this form
        private void button2_Click(object sender, EventArgs e)
        {
        }

        //Closes the application
        private void Teacher_Home_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormFns.SwitchForms(this, startPage.rollCall);
        }
    }
}
