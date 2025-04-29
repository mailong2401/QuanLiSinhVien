namespace QuanLiSinhVien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            btnExit = new Button();
            btnLog = new Button();
            pictureBox3 = new PictureBox();
            panelPass = new Panel();
            pictureBox2 = new PictureBox();
            textBox2 = new TextBox();
            panelAcc = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.backgroundLogin1;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 452);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.backgroundLogin2;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnLog);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(panelPass);
            panel2.Controls.Add(panelAcc);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(442, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(451, 452);
            panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(0, 119, 182);
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(0, 180, 216);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(234, 352);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(142, 54);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLog
            // 
            btnLog.BackColor = Color.FromArgb(0, 119, 182);
            btnLog.FlatAppearance.BorderColor = Color.FromArgb(0, 180, 216);
            btnLog.FlatAppearance.BorderSize = 0;
            btnLog.FlatStyle = FlatStyle.Flat;
            btnLog.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLog.ForeColor = SystemColors.ButtonFace;
            btnLog.ImageAlign = ContentAlignment.MiddleLeft;
            btnLog.Location = new Point(80, 352);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(142, 54);
            btnLog.TabIndex = 4;
            btnLog.Text = "Đăng nhập";
            btnLog.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.userColors;
            pictureBox3.Location = new Point(104, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(249, 157);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // panelPass
            // 
            panelPass.BackColor = Color.FromArgb(202, 240, 248);
            panelPass.Controls.Add(pictureBox2);
            panelPass.Controls.Add(textBox2);
            panelPass.Location = new Point(80, 265);
            panelPass.Name = "panelPass";
            panelPass.Size = new Size(296, 61);
            panelPass.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.padlock;
            pictureBox2.Location = new Point(7, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(202, 240, 248);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(48, 18);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '•';
            textBox2.Size = new Size(216, 24);
            textBox2.TabIndex = 0;
            // 
            // panelAcc
            // 
            panelAcc.BackColor = Color.FromArgb(202, 240, 248);
            panelAcc.Controls.Add(pictureBox1);
            panelAcc.Controls.Add(textBox1);
            panelAcc.Location = new Point(80, 185);
            panelAcc.Name = "panelAcc";
            panelAcc.Size = new Size(296, 61);
            panelAcc.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(7, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(202, 240, 248);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(48, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 24);
            textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 452);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelPass.ResumeLayout(false);
            panelPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelAcc.ResumeLayout(false);
            panelAcc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panelAcc;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Panel panelPass;
        private PictureBox pictureBox2;
        private TextBox textBox2;
        private Button btnLog;
        private PictureBox pictureBox3;
        private Button btnExit;
    }
}
