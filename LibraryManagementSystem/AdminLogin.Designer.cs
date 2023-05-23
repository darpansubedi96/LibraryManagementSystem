namespace LibraryManagementSystem
{
    partial class AdminLogin
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
            this.titleLable = new System.Windows.Forms.Label();
            this.enterUPLable = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameLable = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.registerText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resetPasswordButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLable.Location = new System.Drawing.Point(217, 12);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(353, 31);
            this.titleLable.TabIndex = 0;
            this.titleLable.Text = "Library Management System";
            // 
            // enterUPLable
            // 
            this.enterUPLable.AutoSize = true;
            this.enterUPLable.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.enterUPLable.Location = new System.Drawing.Point(77, 79);
            this.enterUPLable.Name = "enterUPLable";
            this.enterUPLable.Size = new System.Drawing.Size(248, 15);
            this.enterUPLable.TabIndex = 1;
            this.enterUPLable.Text = "Please enter username and password:";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.loginButton.Location = new System.Drawing.Point(141, 210);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 26);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // usernameLable
            // 
            this.usernameLable.AutoSize = true;
            this.usernameLable.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.usernameLable.Location = new System.Drawing.Point(84, 130);
            this.usernameLable.Name = "usernameLable";
            this.usernameLable.Size = new System.Drawing.Size(74, 15);
            this.usernameLable.TabIndex = 4;
            this.usernameLable.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.passwordLabel.Location = new System.Drawing.Point(84, 168);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(66, 14);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(173, 130);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(132, 19);
            this.usernameTextbox.TabIndex = 6;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(173, 166);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(132, 19);
            this.passwordTextbox.TabIndex = 7;
            this.passwordTextbox.UseSystemPasswordChar = true;
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.registerButton.Location = new System.Drawing.Point(141, 383);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 26);
            this.registerButton.TabIndex = 8;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // registerText
            // 
            this.registerText.AutoSize = true;
            this.registerText.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.registerText.Location = new System.Drawing.Point(104, 352);
            this.registerText.Name = "registerText";
            this.registerText.Size = new System.Drawing.Size(175, 15);
            this.registerText.TabIndex = 9;
            this.registerText.Text = "Doesn\'t have an account?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(104, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Forgot the password?";
            // 
            // resetPasswordButton
            // 
            this.resetPasswordButton.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.resetPasswordButton.Location = new System.Drawing.Point(141, 304);
            this.resetPasswordButton.Name = "resetPasswordButton";
            this.resetPasswordButton.Size = new System.Drawing.Size(75, 26);
            this.resetPasswordButton.TabIndex = 12;
            this.resetPasswordButton.Text = "Reset";
            this.resetPasswordButton.UseVisualStyleBackColor = true;
            this.resetPasswordButton.Click += new System.EventHandler(this.resetPasswordButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMS.Properties.Resources.pngaaa_com_58333;
            this.pictureBox1.Location = new System.Drawing.Point(448, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.Image = global::LMS.Properties.Resources.pngegg;
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(22, 23);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backButton.TabIndex = 24;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.resetPasswordButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.registerText);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLable);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.enterUPLable);
            this.Controls.Add(this.titleLable);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LMS";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Label enterUPLable;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label usernameLable;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label registerText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetPasswordButton;
        private System.Windows.Forms.PictureBox backButton;
    }
}

