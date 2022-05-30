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
    public partial class FeeSubmissionForm : AdminMenuForm
    {
        public FeeSubmissionForm()
        {
            InitializeComponent();
        }

        private void FeeSubmissionForm_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string name = txt1.Text;
            float fee = float.Parse(txt2.Text);
            string DueDate = txt3.Text;

           bool flag =  StudentDL.AddFee(name,fee,DueDate);
            if (flag)
            {
                MessageBox.Show("Fee Added");
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
