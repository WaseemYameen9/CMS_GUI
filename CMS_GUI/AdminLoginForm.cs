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
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string userName = txt1.Text;
            string userPassword = txt2.Text;
            bool flag = false;
          
                foreach (User u in UserDL.UserList)
                {
                    if (u.getuserName() == userName && u.getuserPassword() == userPassword && u.getRole() == "admin")
                    {
                        AdminMenuForm f = new AdminMenuForm();
                        this.Hide();
                        f.Show();
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    MessageBox.Show("Invalid User");
                }
            }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            Main f = new Main();
            f.Show();
        }
    }
}
