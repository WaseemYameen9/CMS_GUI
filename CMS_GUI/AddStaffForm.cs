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
    public partial class AddStaffForm : AdminMenuForm
    {
        public AddStaffForm()
        {
            InitializeComponent();
        }

        private void AddStaffForm_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string name = txt1.Text;
            string Department = txt2.Text;
            string post = txt3.Text;
            float salary = int.Parse(txt4.Text);

            StaffBL s = new StaffBL(name,Department,post,salary);
            StaffDL.AddStaffIntoList(s);
            MessageBox.Show("Action Completed");
            this.Hide();
            AdminMenuForm f = new AdminMenuForm();
            f.Show();
        }
    }
}
