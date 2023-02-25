namespace BAIUST
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            Teacher = new RadioButton();
            Student = new RadioButton();
            panel3 = new Panel();
            UserId = new TextBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            Password = new TextBox();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(638, 533);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Teacher
            // 
            Teacher.AutoSize = true;
            Teacher.BackColor = Color.FromArgb(0, 64, 0);
            Teacher.Font = new Font("Bahnschrift Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Teacher.ForeColor = Color.White;
            Teacher.Location = new Point(12, 2);
            Teacher.Name = "Teacher";
            Teacher.Size = new Size(116, 38);
            Teacher.TabIndex = 1;
            Teacher.TabStop = true;
            Teacher.Text = "Admin";
            Teacher.UseVisualStyleBackColor = false;
            Teacher.CheckedChanged += Teacher_CheckedChanged;
            // 
            // Student
            // 
            Student.AutoSize = true;
            Student.BackColor = Color.FromArgb(0, 64, 0);
            Student.Font = new Font("Bahnschrift Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Student.Location = new Point(19, 3);
            Student.Name = "Student";
            Student.Size = new Size(133, 38);
            Student.TabIndex = 2;
            Student.TabStop = true;
            Student.Text = "Student";
            Student.UseVisualStyleBackColor = false;
            Student.CheckedChanged += Student_CheckedChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(UserId);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(717, 178);
            panel3.Name = "panel3";
            panel3.Size = new Size(360, 59);
            panel3.TabIndex = 16;
            // 
            // UserId
            // 
            UserId.BackColor = Color.FromArgb(224, 224, 224);
            UserId.Font = new Font("Bahnschrift SemiBold", 25F, FontStyle.Bold, GraphicsUnit.Point);
            UserId.Location = new Point(69, 0);
            UserId.Name = "UserId";
            UserId.Size = new Size(288, 58);
            UserId.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 0);
            panel2.Controls.Add(Student);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(925, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(152, 45);
            panel2.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(Teacher);
            panel1.Location = new Point(717, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 45);
            panel1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(717, 17);
            label1.Name = "label1";
            label1.Size = new Size(100, 34);
            label1.TabIndex = 13;
            label1.Text = "Act as:";
            // 
            // panel4
            // 
            panel4.Controls.Add(Password);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(717, 276);
            panel4.Name = "panel4";
            panel4.Size = new Size(360, 59);
            panel4.TabIndex = 17;
            // 
            // Password
            // 
            Password.BackColor = Color.FromArgb(224, 224, 224);
            Password.Font = new Font("Bahnschrift SemiBold", 25F, FontStyle.Bold, GraphicsUnit.Point);
            Password.Location = new Point(69, -1);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(288, 58);
            Password.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 53);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.ForeColor = Color.White;
            button2.Location = new Point(1048, 0);
            button2.Name = "button2";
            button2.Size = new Size(29, 29);
            button2.TabIndex = 19;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 0);
            button1.Font = new Font("Bahnschrift SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(771, 371);
            button1.Name = "button1";
            button1.Size = new Size(270, 70);
            button1.TabIndex = 18;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Bahnschrift SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Green;
            button3.Location = new Point(3, 2);
            button3.Name = "button3";
            button3.Size = new Size(264, 59);
            button3.TabIndex = 10;
            button3.Text = "Register";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 64, 0);
            panel5.Controls.Add(button3);
            panel5.Location = new Point(771, 447);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 65);
            panel5.TabIndex = 20;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1081, 538);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private RadioButton Teacher;
        private RadioButton Student;
        private Panel panel3;
        private TextBox UserId;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Panel panel4;
        private TextBox Password;
        private PictureBox pictureBox3;
        private Button button2;
        private Button button1;
        private Button button3;
        private Panel panel5;
    }
}