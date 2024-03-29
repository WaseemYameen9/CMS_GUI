﻿using System;
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
    public partial class StudentMenuForm : Form
    {
        public StudentMenuForm()
        {
            InitializeComponent();
        }

        private void viewTimetableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void printChalanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetChallanForm f = new GetChallanForm();
            f.Show();
        }

        private void viewAttendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAttendenceForm f = new ViewAttendenceForm();
            f.Show();
        }

        private void applyScholarshipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplyScholarshipForm f = new ApplyScholarshipForm();
            f.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void StudentMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main f = new Main();
            f.Show();
        }
    }
}
