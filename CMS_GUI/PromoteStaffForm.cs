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
    public partial class PromoteStaffForm : AdminMenuForm
    {
        public PromoteStaffForm()
        {
            InitializeComponent();
        }

        private void PromoteStaffForm_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
           string name = txt1.Text;
            foreach (StaffBL s in StaffDL.StaffList)
            {
                if(s.Name == name)
                {
                    lbl3.Text = s.Department;
                    lbl4.Text = s.Post;
                    lbl5.Text = s.Salary.ToString();
                }
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string name = txt1.Text;
            bool flag = false;
            foreach (StaffBL s in StaffDL.StaffList)
            {
                if (s.Name == name)
                {
                    s.Department = txt2.Text;
                    s.Post = txt3.Text;
                    s.Salary = float.Parse(txt4.Text);
                    flag = true;
                    
                }
               
            }
            if (flag)
            {
                MessageBox.Show("Action Completed");
            }
            else
            {
                MessageBox.Show("invalid");
            }
            this.Hide();
            AdminMenuForm f = new AdminMenuForm();
            f.Show();


        }
    }
}
