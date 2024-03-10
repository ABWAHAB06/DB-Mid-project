namespace MidprojectDB
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SignOut = new System.Windows.Forms.Button();
            this.Assestment = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.RubricLevel = new System.Windows.Forms.Button();
            this.Rubric = new System.Windows.Forms.Button();
            this.CLO = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.panelholder = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SignOut);
            this.panel1.Controls.Add(this.Assestment);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.RubricLevel);
            this.panel1.Controls.Add(this.Rubric);
            this.panel1.Controls.Add(this.CLO);
            this.panel1.Controls.Add(this.Student);
            this.panel1.Controls.Add(this.Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 450);
            this.panel1.TabIndex = 0;
            // 
            // SignOut
            // 
            this.SignOut.BackColor = System.Drawing.Color.Indigo;
            this.SignOut.ForeColor = System.Drawing.Color.Yellow;
            this.SignOut.Location = new System.Drawing.Point(14, 397);
            this.SignOut.Name = "SignOut";
            this.SignOut.Size = new System.Drawing.Size(90, 29);
            this.SignOut.TabIndex = 10;
            this.SignOut.Text = "SignOut";
            this.SignOut.UseVisualStyleBackColor = false;
            // 
            // Assestment
            // 
            this.Assestment.BackColor = System.Drawing.Color.Indigo;
            this.Assestment.ForeColor = System.Drawing.Color.Yellow;
            this.Assestment.Location = new System.Drawing.Point(15, 353);
            this.Assestment.Name = "Assestment";
            this.Assestment.Size = new System.Drawing.Size(90, 29);
            this.Assestment.TabIndex = 9;
            this.Assestment.Text = "Assestment";
            this.Assestment.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 52);
            this.panel2.TabIndex = 8;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(3, 14);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(115, 24);
            this.label.TabIndex = 1;
            this.label.Text = "Mid Project";
            // 
            // RubricLevel
            // 
            this.RubricLevel.BackColor = System.Drawing.Color.Indigo;
            this.RubricLevel.ForeColor = System.Drawing.Color.Yellow;
            this.RubricLevel.Location = new System.Drawing.Point(15, 304);
            this.RubricLevel.Name = "RubricLevel";
            this.RubricLevel.Size = new System.Drawing.Size(90, 29);
            this.RubricLevel.TabIndex = 5;
            this.RubricLevel.Text = "RubricsLevel";
            this.RubricLevel.UseVisualStyleBackColor = false;
            // 
            // Rubric
            // 
            this.Rubric.BackColor = System.Drawing.Color.Indigo;
            this.Rubric.ForeColor = System.Drawing.Color.Yellow;
            this.Rubric.Location = new System.Drawing.Point(14, 256);
            this.Rubric.Name = "Rubric";
            this.Rubric.Size = new System.Drawing.Size(90, 29);
            this.Rubric.TabIndex = 4;
            this.Rubric.Text = "Rubric";
            this.Rubric.UseVisualStyleBackColor = false;
            // 
            // CLO
            // 
            this.CLO.BackColor = System.Drawing.Color.Indigo;
            this.CLO.ForeColor = System.Drawing.Color.Yellow;
            this.CLO.Location = new System.Drawing.Point(15, 210);
            this.CLO.Name = "CLO";
            this.CLO.Size = new System.Drawing.Size(90, 29);
            this.CLO.TabIndex = 3;
            this.CLO.Text = "CLO";
            this.CLO.UseVisualStyleBackColor = false;
          
            // 
            // Student
            // 
            this.Student.BackColor = System.Drawing.Color.Indigo;
            this.Student.ForeColor = System.Drawing.Color.Yellow;
            this.Student.Location = new System.Drawing.Point(15, 158);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(90, 29);
            this.Student.TabIndex = 2;
            this.Student.Text = "Student";
            this.Student.UseVisualStyleBackColor = false;
            this.Student.Click += new System.EventHandler(this.Student_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Indigo;
            this.Home.ForeColor = System.Drawing.Color.Yellow;
            this.Home.Location = new System.Drawing.Point(15, 113);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(90, 29);
            this.Home.TabIndex = 1;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // panelholder
            // 
            this.panelholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelholder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelholder.Location = new System.Drawing.Point(123, 0);
            this.panelholder.Name = "panelholder";
            this.panelholder.Size = new System.Drawing.Size(677, 450);
            this.panelholder.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelholder);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RubricLevel;
        private System.Windows.Forms.Button Rubric;
        private System.Windows.Forms.Button CLO;
        private System.Windows.Forms.Button Student;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Assestment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panelholder;
        private System.Windows.Forms.Button SignOut;
    }
}

