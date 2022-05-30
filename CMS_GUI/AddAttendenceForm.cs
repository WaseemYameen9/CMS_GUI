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
    public partial class AddAttendenceForm : AdminMenuForm
    {
        public AddAttendenceForm()
        {
            InitializeComponent();
        }

        private void AddAttendenceForm_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string Name = txt1.Text;
            int attendedclasses = int.Parse(txt2.Text);
           bool flag =  StudentDL.EnterAttendence(Name,attendedclasses);
            if (flag)
            {
                MessageBox.Show("Attendence Added");
            }
            else
            {
                MessageBox.Show("Invalid Student Name");
            }
            this.Hide();
            AdminMenuForm f = new AdminMenuForm();
            f.Show();
        }
    }
}
