namespace LibraryManagementSystem
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.regLable = new System.Windows.Forms.Label();
            this.regUsername = new System.Windows.Forms.Label();
            this.regPassword = new System.Windows.Forms.Label();
            this.regRepassword = new System.Windows.Forms.Label();
            this.regUsernameTextBox = new System.Windows.Forms.TextBox();
            this.regPasswordTextBox = new System.Windows.Forms.TextBox();
            this.RegisterNowButton = new System.Windows.Forms.Label();
            this.regConfirmPasswordtextBox = new System.Windows.Forms.TextBox();
            this.regPicture = new System.Windows.Forms.PictureBox();
            this.loginBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.regPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // regLable
            // 
            this.regLable.AutoSize = true;
            this.regLable.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLable.Location = new System.Drawing.Point(217, 12);
            this.regLable.Name = "regLable";
            this.regLable.Size = new System.Drawing.Size(353, 31);
            this.regLable.TabIndex = 0;
            this.regLable.Text = "Library Management System";
            // 
            // regUsername
            // 
            this.regUsername.AutoSize = true;
            this.regUsername.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.regUsername.Location = new System.Drawing.Point(61, 99);
            this.regUsername.Name = "regUsername";
            this.regUsername.Size = new System.Drawing.Size(157, 15);
            this.regUsername.TabIndex = 1;
            this.regUsername.Text = "Please Enter Username";
            // 
            // regPassword
            // 
            this.regPassword.AutoSize = true;
            this.regPassword.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.regPassword.Location = new System.Drawing.Point(61, 147);
            this.regPassword.Name = "regPassword";
            this.regPassword.Size = new System.Drawing.Size(156, 15);
            this.regPassword.TabIndex = 2;
            this.regPassword.Text = "Please Enter Password:";
            // 
            // regRepassword
            // 
            this.regRepassword.AutoSize = true;
            this.regRepassword.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.regRepassword.Location = new System.Drawing.Point(61, 191);
            this.regRepassword.Name = "regRepassword";
            this.regRepassword.Size = new System.Drawing.Size(164, 15);
            this.regRepassword.TabIndex = 3;
            this.regRepassword.Text = "Enter Confirm Password:";
            // 
            // regUsernameTextBox
            // 
            this.regUsernameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.regUsernameTextBox.Location = new System.Drawing.Point(252, 99);
            this.regUsernameTextBox.Name = "regUsernameTextBox";
            this.regUsernameTextBox.Size = new System.Drawing.Size(136, 22);
            this.regUsernameTextBox.TabIndex = 4;
            // 
            // regPasswordTextBox
            // 
            this.regPasswordTextBox.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.regPasswordTextBox.Location = new System.Drawing.Point(252, 147);
            this.regPasswordTextBox.Name = "regPasswordTextBox";
            this.regPasswordTextBox.Size = new System.Drawing.Size(136, 22);
            this.regPasswordTextBox.TabIndex = 5;
            // 
            // RegisterNowButton
            // 
            this.RegisterNowButton.AutoSize = true;
            this.RegisterNowButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegisterNowButton.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RegisterNowButton.Location = new System.Drawing.Point(202, 261);
            this.RegisterNowButton.Name = "RegisterNowButton";
            this.RegisterNowButton.Size = new System.Drawing.Size(106, 17);
            this.RegisterNowButton.TabIndex = 6;
            this.RegisterNowButton.Text = "Register Now";
            this.RegisterNowButton.Click += new System.EventHandler(this.RegisterNowButton_Click);
            // 
            // regConfirmPasswordtextBox
            // 
            this.regConfirmPasswordtextBox.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.regConfirmPasswordtextBox.Location = new System.Drawing.Point(250, 191);
            this.regConfirmPasswordtextBox.Name = "regConfirmPasswordtextBox";
            this.regConfirmPasswordtextBox.Size = new System.Drawing.Size(138, 22);
            this.regConfirmPasswordtextBox.TabIndex = 7;
            // 
            // regPicture
            // 
            this.regPicture.Image = ((System.Drawing.Image)(resources.GetObject("regPicture.Image")));
            this.regPicture.Location = new System.Drawing.Point(464, 178);
            this.regPicture.Name = "regPicture";
            this.regPicture.Size = new System.Drawing.Size(400, 426);
            this.regPicture.TabIndex = 8;
            this.regPicture.TabStop = false;
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.loginBtn.Location = new System.Drawing.Point(213, 299);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 9;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.regPicture);
            this.Controls.Add(this.regConfirmPasswordtextBox);
            this.Controls.Add(this.RegisterNowButton);
            this.Controls.Add(this.regPasswordTextBox);
            this.Controls.Add(this.regUsernameTextBox);
            this.Controls.Add(this.regRepassword);
            this.Controls.Add(this.regPassword);
            this.Controls.Add(this.regUsername);
            this.Controls.Add(this.regLable);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.regPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label regLable;
        private System.Windows.Forms.Label regUsername;
        private System.Windows.Forms.Label regPassword;
        private System.Windows.Forms.Label regRepassword;
        private System.Windows.Forms.TextBox regUsernameTextBox;
        private System.Windows.Forms.TextBox regPasswordTextBox;
        private System.Windows.Forms.Label RegisterNowButton;
        private System.Windows.Forms.TextBox regConfirmPasswordtextBox;
        private System.Windows.Forms.PictureBox regPicture;
        private System.Windows.Forms.Button loginBtn;
    }
}