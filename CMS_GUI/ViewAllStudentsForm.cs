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
    public partial class ViewAllStudentsForm : AdminMenuForm
    {
        public ViewAllStudentsForm()
        {

           
            InitializeComponent();
            
        }

        private void ViewAllStudentsForm_Load(object sender, EventArgs e)
        {
            GV1.DataSource = StudentDL.StudentList.Select(c => new {c.Name,c.Rollno,c.Class_,c.Marks,c.Percertage1 }).ToList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void GV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
