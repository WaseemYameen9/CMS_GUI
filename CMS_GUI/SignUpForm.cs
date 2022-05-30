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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string userName = txt1.Text;
            string userPassword = txt2.Text;
            string role = txt3.Text;
            if (UserDL.isValid(userName))
            { 
                if(role == "admin")
                {
                admin user = new admin(userName,userPassword,role);
                UserDL.AddIntoList(user);
                }
               else if(role == "student")
               {
                UserStudent user = new UserStudent(userName,userPassword,role);
                UserDL.AddIntoList(user);
               }
               else
               {
                MessageBox.Show("Invalid");
               }

               this.Hide();
              Main f = new Main();
               f.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username");
            }
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
