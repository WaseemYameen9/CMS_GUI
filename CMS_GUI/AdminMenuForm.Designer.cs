
namespace CMS_GUI
{
    partial class AdminMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAttendenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAttendenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feeSubmissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promoteStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.attendenceToolStripMenuItem,
            this.feeSubmissionToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.viewStudentToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click_2);
            // 
            // viewStudentToolStripMenuItem
            // 
            this.viewStudentToolStripMenuItem.Name = "viewStudentToolStripMenuItem";
            this.viewStudentToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.viewStudentToolStripMenuItem.Text = "View Student";
            // 
            // attendenceToolStripMenuItem
            // 
            this.attendenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAttendenceToolStripMenuItem,
            this.viewAttendenceToolStripMenuItem});
            this.attendenceToolStripMenuItem.Name = "attendenceToolStripMenuItem";
            this.attendenceToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.attendenceToolStripMenuItem.Text = "Attendence";
            // 
            // addAttendenceToolStripMenuItem
            // 
            this.addAttendenceToolStripMenuItem.Name = "addAttendenceToolStripMenuItem";
            this.addAttendenceToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addAttendenceToolStripMenuItem.Text = "Add Attendence";
            this.addAttendenceToolStripMenuItem.Click += new System.EventHandler(this.addAttendenceToolStripMenuItem_Click);
            // 
            // viewAttendenceToolStripMenuItem
            // 
            this.viewAttendenceToolStripMenuItem.Name = "viewAttendenceToolStripMenuItem";
            this.viewAttendenceToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.viewAttendenceToolStripMenuItem.Text = "View Attendence";
            // 
            // feeSubmissionToolStripMenuItem
            // 
            this.feeSubmissionToolStripMenuItem.Name = "feeSubmissionToolStripMenuItem";
            this.feeSubmissionToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.feeSubmissionToolStripMenuItem.Text = "Fee Submission";
            this.feeSubmissionToolStripMenuItem.Click += new System.EventHandler(this.feeSubmissionToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStaffToolStripMenuItem,
            this.viewStaffToolStripMenuItem,
            this.promoteStaffToolStripMenuItem});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.staffToolStripMenuItem.Text = "Staff";
            // 
            // addStaffToolStripMenuItem
            // 
            this.addStaffToolStripMenuItem.Name = "addStaffToolStripMenuItem";
            this.addStaffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addStaffToolStripMenuItem.Text = "Add Staff";
            this.addStaffToolStripMenuItem.Click += new System.EventHandler(this.addStaffToolStripMenuItem_Click);
            // 
            // viewStaffToolStripMenuItem
            // 
            this.viewStaffToolStripMenuItem.Name = "viewStaffToolStripMenuItem";
            this.viewStaffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewStaffToolStripMenuItem.Text = "View Staff";
            // 
            // promoteStaffToolStripMenuItem
            // 
            this.promoteStaffToolStripMenuItem.Name = "promoteStaffToolStripMenuItem";
            this.promoteStaffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.promoteStaffToolStripMenuItem.Text = "Promote Staff";
            this.promoteStaffToolStripMenuItem.Click += new System.EventHandler(this.promoteStaffToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click_1);
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AdminMenuForm";
            this.Text = "AdminMenuForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAttendenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAttendenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feeSubmissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promoteStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}