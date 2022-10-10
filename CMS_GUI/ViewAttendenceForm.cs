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
    public partial class ViewAttendenceForm : StudentMenuForm
    {
        public ViewAttendenceForm()
        {
            InitializeComponent();
        }

        private void ViewAttendenceForm_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string name = txt1.Text;
            student s = StudentDL.GetStudentObject(name);
            
            lbl5.Text = "30";
            lbl6.Text = s.getAttendedClasses().ToString();
            lbl7.Text = s.getAttendencePercentage().ToString();
         
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentMenuForm f = new StudentMenuForm();
            f.Show();
        }
    }
}
