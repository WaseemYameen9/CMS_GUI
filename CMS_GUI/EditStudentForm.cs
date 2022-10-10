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
    public partial class EditStudentForm : AdminMenuForm
    {
        student s;
        public EditStudentForm()
        {
            InitializeComponent();
        }

        private void EditStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string  Name = txtName.Text;
             s = StudentDL.GetStudentObject(Name);
            lblOname.Text = s.Name;
            lblOrollno.Text = s.Rollno.ToString();
            lblOMarks.Text = s.Marks.ToString();
            lblOclass.Text = s.Class_.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            s.Name = txtName.Text;
            s.Rollno = int.Parse(txtNrollno.Text);
            s.Marks = float.Parse(txtNmarks.Text);
            s.Class_ = int.Parse(txtNclass.Text);

            this.Close();
            AdminMenuForm f = new AdminMenuForm();
            f.Show();
            
        }
    }
}
