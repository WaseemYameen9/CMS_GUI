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
    public partial class ViewStaffForm : AdminMenuForm
    {
        public ViewStaffForm()
        {
            InitializeComponent();
        }

        private void ViewStaffForm_Load(object sender, EventArgs e)
        {
            GV1.DataSource = StaffDL.StaffList.Select(c => new{c.Name,c.Department,c.Post,c.Salary }).ToList();
        }
    }
}
