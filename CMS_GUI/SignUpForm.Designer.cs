
namespace CMS_GUI
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.74757F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.25243F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt3, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.32099F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.67901F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(270, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(284, 33);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "College Management System";
            // 
            // lbl2
            // 
            this.lbl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(128, 108);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(136, 20);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Enter UserName :";
            // 
            // lbl3
            // 
            this.lbl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(135, 186);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(129, 20);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Enter Password :";
            // 
            // lbl4
            // 
            this.lbl4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(171, 271);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(93, 20);
            this.lbl4.TabIndex = 4;
            this.lbl4.Text = "Enter Role :";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(270, 326);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "ADD";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txt1
            // 
            this.txt1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(270, 105);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(224, 26);
            this.txt1.TabIndex = 6;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(270, 183);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(224, 26);
            this.txt2.TabIndex = 7;
            // 
            // txt3
            // 
            this.txt3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt3.Location = new System.Drawing.Point(270, 268);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(224, 26);
            this.txt3.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}