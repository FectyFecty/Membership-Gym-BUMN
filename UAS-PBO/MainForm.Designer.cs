namespace UAS_PBO
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            lblTitle = new Label();
            btnLogin = new Button();
            btnRegister = new Button();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(83, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(340, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SELAMAT DATANG DI GYM BUMN!";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(141, 278);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(207, 33);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(141, 317);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(207, 33);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Daftar";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(141, 356);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(207, 33);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 230);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(175, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(153, 230);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(334, 42);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(154, 230);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // MainForm
            // 
            ClientSize = new Size(500, 400);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitle);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BUMN GYM MEMBERSHIP";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
