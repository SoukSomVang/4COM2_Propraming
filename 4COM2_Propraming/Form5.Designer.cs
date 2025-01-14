namespace _4COM2_Propraming
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panel1 = new Panel();
            txtUserName = new TextBox();
            txtPwd = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(txtPwd);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 565);
            panel1.TabIndex = 0;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Saysettha OT", 10.2F);
            txtUserName.Location = new Point(44, 327);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(246, 37);
            txtUserName.TabIndex = 6;
            // 
            // txtPwd
            // 
            txtPwd.Font = new Font("Saysettha OT", 10.2F);
            txtPwd.Location = new Point(44, 423);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(246, 37);
            txtPwd.TabIndex = 5;
            txtPwd.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.HotTrack;
            btnLogin.ForeColor = SystemColors.Info;
            btnLogin.Location = new Point(166, 483);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(124, 41);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.OrangeRed;
            btnExit.ForeColor = SystemColors.Info;
            btnExit.Location = new Point(36, 483);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(131, 41);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ScrollBar;
            label2.Font = new Font("Saysettha OT", 10.2F);
            label2.Location = new Point(44, 396);
            label2.Name = "label2";
            label2.Size = new Size(91, 27);
            label2.TabIndex = 2;
            label2.Text = "ລະຫັດຜ່ານ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ScrollBar;
            label1.Font = new Font("Saysettha OT", 10.2F);
            label1.Location = new Point(44, 300);
            label1.Name = "label1";
            label1.Size = new Size(113, 27);
            label1.TabIndex = 1;
            label1.Text = "ຊື່ເຂົ້າໃຊ້ລະບົບ:";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 589);
            ControlBox = false;
            Controls.Add(panel1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtUserName;
        private TextBox txtPwd;
        private Button btnLogin;
        private Button btnExit;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}