
namespace CMS_GUI
{
    partial class AdminViewAttendenceForm
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(106, 93);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(102, 20);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Enter Name :";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(107, 184);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(112, 20);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Total Classes :";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(106, 263);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(143, 20);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "Attended Classes :";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(107, 333);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(186, 20);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "Attendence Percentage :";
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(269, 93);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(225, 23);
            this.txt1.TabIndex = 8;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(576, 93);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "Done";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(306, 393);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "Ok";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(405, 191);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(0, 20);
            this.lbl5.TabIndex = 11;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(405, 268);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(0, 20);
            this.lbl6.TabIndex = 12;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(405, 338);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(0, 20);
            this.lbl7.TabIndex = 13;
            // 
            // AdminViewAttendenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "AdminViewAttendenceForm";
            this.Text = "AdminViewAttendenceForm";
            this.Load += new System.EventHandler(this.AdminViewAttendenceForm_Load);
            this.Controls.SetChildIndex(this.lbl1, 0);
            this.Controls.SetChildIndex(this.lbl2, 0);
            this.Controls.SetChildIndex(this.lbl3, 0);
            this.Controls.SetChildIndex(this.lbl4, 0);
            this.Controls.SetChildIndex(this.txt1, 0);
            this.Controls.SetChildIndex(this.btn1, 0);
            this.Controls.SetChildIndex(this.btn2, 0);
            this.Controls.SetChildIndex(this.lbl5, 0);
            this.Controls.SetChildIndex(this.lbl6, 0);
            this.Controls.SetChildIndex(this.lbl7, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
    }
}