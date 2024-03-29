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
    public partial class AdminMenuForm : Form
    {
        public AdminMenuForm()
        {
            InitializeComponent();
        }

        private void attendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addStudentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           

        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllStudentsForm f = new ViewAllStudentsForm();
            this.Hide();
            f.Show();
            
        }

        private void addStudentToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            AddStudentForm f = new AddStudentForm();
            f.Show();

        }

        private void addAttendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAttendenceForm f = new AddAttendenceForm();
            f.Show();
        }

        private void feeSubmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FeeSubmissionForm f = new FeeSubmissionForm();
            f.Show();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Main f = new Main();
            f.Show();

        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStaffForm f = new AddStaffForm();
            f.Show();
        }

        private void promoteStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PromoteStaffForm f = new PromoteStaffForm();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void viewStudentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ViewAllStudentsForm f = new ViewAllStudentsForm();
            f.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewAttendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminViewAttendenceForm f = new AdminViewAttendenceForm();
            f.Show();
        }

        private void viewStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewStaffForm f = new ViewStaffForm();
            f.Show();
        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            DeleteStudentForm f = new DeleteStudentForm();
            f.Show();
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            EditStudentForm f = new EditStudentForm();
            f.Show();
        }
    }
}
