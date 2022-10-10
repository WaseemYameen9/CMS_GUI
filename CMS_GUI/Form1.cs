using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS_GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            UserDL.LoadUser();
            StudentDL.LoadstudentsFromFile();
            StaffDL.LoadStaffFormFile();
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLoginForm f = new AdminLoginForm();
            f.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm f = new SignUpForm();
            f.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentLoginForm f = new StudentLoginForm();
            f.Show();

        }

        private void btn4_Click(object sender, EventArgs e)
        {

            
            UserDL.StoreUserIntoFile();
            StudentDL.StoreStudentIntoFile();
            StaffDL.storeStaffIntoFile();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
