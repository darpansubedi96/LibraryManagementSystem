namespace LibraryManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.titleLable = new System.Windows.Forms.Label();
            this.enterUPLable = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginPicture = new System.Windows.Forms.PictureBox();
            this.usernameLable = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.registerText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).BeginInit();
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
            this.loginButton.Location = new System.Drawing.Point(92, 225);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 26);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginPicture
            // 
            this.loginPicture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("loginPicture.ErrorImage")));
            this.loginPicture.Image = ((System.Drawing.Image)(resources.GetObject("loginPicture.Image")));
            this.loginPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("loginPicture.InitialImage")));
            this.loginPicture.Location = new System.Drawing.Point(464, 178);
            this.loginPicture.Name = "loginPicture";
            this.loginPicture.Size = new System.Drawing.Size(400, 426);
            this.loginPicture.TabIndex = 3;
            this.loginPicture.TabStop = false;
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
            this.passwordLabel.Location = new System.Drawing.Point(89, 168);
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
            this.passwordTextbox.Location = new System.Drawing.Point(173, 168);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(132, 19);
            this.passwordTextbox.TabIndex = 7;
            this.passwordTextbox.UseSystemPasswordChar = true;
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.registerButton.Location = new System.Drawing.Point(92, 292);
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
            this.registerText.Location = new System.Drawing.Point(92, 274);
            this.registerText.Name = "registerText";
            this.registerText.Size = new System.Drawing.Size(199, 15);
            this.registerText.TabIndex = 9;
            this.registerText.Text = "If you don\'t have an account?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerText);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLable);
            this.Controls.Add(this.loginPicture);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.enterUPLable);
            this.Controls.Add(this.titleLable);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LMS";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Label enterUPLable;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox loginPicture;
        private System.Windows.Forms.Label usernameLable;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label registerText;
    }
}

