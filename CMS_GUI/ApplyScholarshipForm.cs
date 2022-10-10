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
    public partial class ApplyScholarshipForm : StudentMenuForm
    {
        public ApplyScholarshipForm()
        {
            InitializeComponent();
        }

        private void ApplyScholarshipForm_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main f = new Main();
            MessageBox.Show("Applied Successfully");
            f.Show();
        }
    }
}
