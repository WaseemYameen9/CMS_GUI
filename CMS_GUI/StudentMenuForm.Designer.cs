﻿
namespace CMS_GUI
{
    partial class StudentMenuForm
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
            this.viewTimetableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printChalanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAttendenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyScholarshipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTimetableToolStripMenuItem,
            this.printChalanToolStripMenuItem,
            this.viewAttendenceToolStripMenuItem,
            this.applyScholarshipToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewTimetableToolStripMenuItem
            // 
            this.viewTimetableToolStripMenuItem.Name = "viewTimetableToolStripMenuItem";
            this.viewTimetableToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.viewTimetableToolStripMenuItem.Text = "View Timetable";
            this.viewTimetableToolStripMenuItem.Click += new System.EventHandler(this.viewTimetableToolStripMenuItem_Click);
            // 
            // printChalanToolStripMenuItem
            // 
            this.printChalanToolStripMenuItem.Name = "printChalanToolStripMenuItem";
            this.printChalanToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.printChalanToolStripMenuItem.Text = "Print Chalan";
            this.printChalanToolStripMenuItem.Click += new System.EventHandler(this.printChalanToolStripMenuItem_Click);
            // 
            // viewAttendenceToolStripMenuItem
            // 
            this.viewAttendenceToolStripMenuItem.Name = "viewAttendenceToolStripMenuItem";
            this.viewAttendenceToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.viewAttendenceToolStripMenuItem.Text = "View Attendence";
            this.viewAttendenceToolStripMenuItem.Click += new System.EventHandler(this.viewAttendenceToolStripMenuItem_Click);
            // 
            // applyScholarshipToolStripMenuItem
            // 
            this.applyScholarshipToolStripMenuItem.Name = "applyScholarshipToolStripMenuItem";
            this.applyScholarshipToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.applyScholarshipToolStripMenuItem.Text = "Apply Scholarship";
            this.applyScholarshipToolStripMenuItem.Click += new System.EventHandler(this.applyScholarshipToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // StudentMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentMenuForm";
            this.Text = "StudentMenuForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewTimetableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printChalanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAttendenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyScholarshipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}