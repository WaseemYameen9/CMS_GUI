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
    public partial class GetChallanForm : StudentMenuForm
    {
        public GetChallanForm()
        {
            InitializeComponent();
        }

        private void GetChallanForm_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            string name = txt1.Text;
            foreach (student s in StudentDL.StudentList)
            {
                if (s.getName() == name)
                {
                    lbl5.Text = s.GetFee().ToString();
                    lbl6.Text = s.getDuedate();
                    lbl7.Text = "0019087654214";
                }
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentMenuForm f = new StudentMenuForm();
            f.Show();
        }
    }
}
