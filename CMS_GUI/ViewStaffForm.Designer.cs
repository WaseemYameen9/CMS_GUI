
namespace CMS_GUI
{
    partial class ViewStaffForm
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
            this.GV1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GV1)).BeginInit();
            this.SuspendLayout();
            // 
            // GV1
            // 
            this.GV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV1.Location = new System.Drawing.Point(0, 76);
            this.GV1.Name = "GV1";
            this.GV1.Size = new System.Drawing.Size(531, 377);
            this.GV1.TabIndex = 4;
            // 
            // ViewStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GV1);
            this.Name = "ViewStaffForm";
            this.Text = "ViewStaffForm";
            this.Load += new System.EventHandler(this.ViewStaffForm_Load);
            this.Controls.SetChildIndex(this.GV1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV1;
    }
}