namespace BAIUST
{
    partial class library_Admin_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(library_Admin_Login));
            pictureBox1 = new PictureBox();
            Student = new RadioButton();
            panel3 = new Panel();
            UserId = new TextBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            Password = new TextBox();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(546, 542);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Student
            // 
            Student.AutoSize = true;
            Student.BackColor = Color.Green;
            Student.Font = new Font("Bahnschrift Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Student.Location = new Point(16, 4);
            Student.Name = "Student";
            Student.Size = new Size(116, 38);
            Student.TabIndex = 2;
            Student.TabStop = true;
            Student.Text = "Admin";
            Student.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(UserId);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(593, 157);
            panel3.Name = "panel3";
            panel3.Size = new Size(360, 59);
            panel3.TabIndex = 16;
            // 
            // UserId
            // 
            UserId.BackColor = Color.FromArgb(224, 224, 224);
            UserId.Font = new Font("Bahnschrift SemiBold", 25F, FontStyle.Bold, GraphicsUnit.Point);
            UserId.Location = new Point(72, -2);
            UserId.Name = "UserId";
            UserId.Size = new Size(288, 58);
            UserId.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Green;
            panel2.Controls.Add(Student);
            panel2.Location = new Point(750, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(152, 45);
            panel2.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(596, 67);
            label1.Name = "label1";
            label1.Size = new Size(100, 34);
            label1.TabIndex = 13;
            label1.Text = "Act as:";
            // 
            // panel4
            // 
            panel4.Controls.Add(Password);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(593, 255);
            panel4.Name = "panel4";
            panel4.Size = new Size(360, 59);
            panel4.TabIndex = 17;
            // 
            // Password
            // 
            Password.BackColor = Color.FromArgb(224, 224, 224);
            Password.Font = new Font("Bahnschrift SemiBold", 25F, FontStyle.Bold, GraphicsUnit.Point);
            Password.Location = new Point(72, 1);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(288, 58);
            Password.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 53);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Bahnschrift SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(4, 3);
            button1.Name = "button1";
            button1.Size = new Size(270, 67);
            button1.TabIndex = 18;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 64, 0);
            panel5.Controls.Add(button1);
            panel5.Location = new Point(653, 402);
            panel5.Name = "panel5";
            panel5.Size = new Size(277, 73);
            panel5.TabIndex = 20;
            // 
            // library_Admin_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 563);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Name = "library_Admin_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "library_Admin_Login";
            Load += library_Admin_Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private RadioButton Student;
        private Panel panel3;
        private TextBox UserId;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label1;
        private Panel panel4;
        private TextBox Password;
        private PictureBox pictureBox3;
        private Button button1;
        private Panel panel5;
    }
}