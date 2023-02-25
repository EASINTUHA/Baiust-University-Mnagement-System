namespace BAIUST
{
    partial class AddAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccount));
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            UserId = new TextBox();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            Password = new TextBox();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            textBox1 = new TextBox();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            textBox2 = new TextBox();
            pictureBox5 = new PictureBox();
            panel5 = new Panel();
            textBox3 = new TextBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            label1 = new Label();
            panel6 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(734, 761);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(UserId);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(790, 516);
            panel3.Name = "panel3";
            panel3.Size = new Size(360, 59);
            panel3.TabIndex = 22;
            // 
            // UserId
            // 
            UserId.BackColor = Color.White;
            UserId.Font = new Font("Bahnschrift SemiBold", 25F, FontStyle.Bold, GraphicsUnit.Point);
            UserId.Location = new Point(69, 1);
            UserId.Name = "UserId";
            UserId.Size = new Size(288, 58);
            UserId.TabIndex = 8;
            UserId.TextChanged += UserId_TextChanged;
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
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(Password);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(790, 600);
            panel4.Name = "panel4";
            panel4.Size = new Size(360, 59);
            panel4.TabIndex = 23;
            // 
            // Password
            // 
            Password.BackColor = Color.White;
            Password.Font = new Font("Bahnschrift SemiBold", 25F, FontStyle.Bold, GraphicsUnit.Point);
            Password.Location = new Point(69, 0);
            Password.Name = "Password";
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
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.ForeColor = Color.White;
            button2.Location = new Point(1156, 2);
            button2.Name = "button2";
            button2.Size = new Size(29, 29);
            button2.TabIndex = 25;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 0);
            button1.Font = new Font("Bahnschrift SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(7, 4);
            button1.Name = "button1";
            button1.Size = new Size(277, 70);
            button1.TabIndex = 24;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox4);
            panel1.Location = new Point(790, 439);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 59);
            panel1.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Bahnschrift SemiBold", 25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(69, 0);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(288, 58);
            textBox1.TabIndex = 9;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 53);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(pictureBox5);
            panel2.Location = new Point(790, 354);
            panel2.Name = "panel2";
            panel2.Size = new Size(360, 59);
            panel2.TabIndex = 27;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Bahnschrift SemiBold", 25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(69, 0);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(288, 58);
            textBox2.TabIndex = 9;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(60, 53);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(pictureBox6);
            panel5.Location = new Point(790, 277);
            panel5.Name = "panel5";
            panel5.Size = new Size(360, 59);
            panel5.TabIndex = 28;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.Font = new Font("Bahnschrift SemiBold", 25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(69, 0);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(288, 58);
            textBox3.TabIndex = 9;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(60, 53);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(899, 34);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(189, 163);
            pictureBox7.TabIndex = 29;
            pictureBox7.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(793, 216);
            label1.Name = "label1";
            label1.Size = new Size(340, 38);
            label1.TabIndex = 30;
            label1.Text = "New Student Registration";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Green;
            panel6.Controls.Add(button1);
            panel6.Location = new Point(820, 694);
            panel6.Name = "panel6";
            panel6.Size = new Size(289, 79);
            panel6.TabIndex = 31;
            // 
            // AddAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 243, 232);
            ClientSize = new Size(1188, 778);
            Controls.Add(panel6);
            Controls.Add(label1);
            Controls.Add(pictureBox7);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddAccount";
            Load += AddAccount_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel3;
        private TextBox UserId;
        private PictureBox pictureBox2;
        private Panel panel4;
        private TextBox Password;
        private PictureBox pictureBox3;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private TextBox textBox1;
        private PictureBox pictureBox4;
        private Panel panel2;
        private TextBox textBox2;
        private PictureBox pictureBox5;
        private Panel panel5;
        private TextBox textBox3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Label label1;
        private Panel panel6;
    }
}