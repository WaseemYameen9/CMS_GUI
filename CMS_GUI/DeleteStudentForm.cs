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
    public partial class DeleteStudentForm : AdminMenuForm
    {
        public DeleteStudentForm()
        {
            InitializeComponent();
        }

        private void DeleteStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            bool flag = StudentDL.DeleteStudentForm(Name);
            if (flag)
            {
                MessageBox.Show("Student Deleted Succesfully");
            }
            else
            {
                MessageBox.Show("Invalid");
            }
            this.Close();
            AdminMenuForm f = new AdminMenuForm();
            f.Show();
        }
    }
}
