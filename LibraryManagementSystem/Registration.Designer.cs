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
            this.regUsername = new System.Windows.Forms.Label();
            this.regPassword = new System.Windows.Forms.Label();
            this.regRepassword = new System.Windows.Forms.Label();
            this.regUsernameTextBox = new System.Windows.Forms.TextBox();
            this.regPasswordTextBox = new System.Windows.Forms.TextBox();
            this.RegisterNowButton = new System.Windows.Forms.Label();
            this.regConfirmPasswordtextBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regUsername
            // 
            this.regUsername.AutoSize = true;
            this.regUsername.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.regUsername.Location = new System.Drawing.Point(42, 88);
            this.regUsername.Name = "regUsername";
            this.regUsername.Size = new System.Drawing.Size(110, 15);
            this.regUsername.TabIndex = 1;
            this.regUsername.Text = "Enter Username";
            // 
            // regPassword
            // 
            this.regPassword.AutoSize = true;
            this.regPassword.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.regPassword.Location = new System.Drawing.Point(42, 133);
            this.regPassword.Name = "regPassword";
            this.regPassword.Size = new System.Drawing.Size(109, 15);
            this.regPassword.TabIndex = 2;
            this.regPassword.Text = "Enter Password:";
            // 
            // regRepassword
            // 
            this.regRepassword.AutoSize = true;
            this.regRepassword.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.regRepassword.Location = new System.Drawing.Point(42, 181);
            this.regRepassword.Name = "regRepassword";
            this.regRepassword.Size = new System.Drawing.Size(125, 15);
            this.regRepassword.TabIndex = 3;
            this.regRepassword.Text = "Confirm Password:";
            // 
            // regUsernameTextBox
            // 
            this.regUsernameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.regUsernameTextBox.Location = new System.Drawing.Point(181, 88);
            this.regUsernameTextBox.Name = "regUsernameTextBox";
            this.regUsernameTextBox.Size = new System.Drawing.Size(116, 22);
            this.regUsernameTextBox.TabIndex = 4;
            // 
            // regPasswordTextBox
            // 
            this.regPasswordTextBox.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.regPasswordTextBox.Location = new System.Drawing.Point(181, 130);
            this.regPasswordTextBox.Name = "regPasswordTextBox";
            this.regPasswordTextBox.Size = new System.Drawing.Size(116, 22);
            this.regPasswordTextBox.TabIndex = 5;
            // 
            // RegisterNowButton
            // 
            this.RegisterNowButton.AutoSize = true;
            this.RegisterNowButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegisterNowButton.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RegisterNowButton.Location = new System.Drawing.Point(104, 247);
            this.RegisterNowButton.Name = "RegisterNowButton";
            this.RegisterNowButton.Size = new System.Drawing.Size(106, 17);
            this.RegisterNowButton.TabIndex = 6;
            this.RegisterNowButton.Text = "Register Now";
            this.RegisterNowButton.Click += new System.EventHandler(this.RegisterNowButton_Click);
            // 
            // regConfirmPasswordtextBox
            // 
            this.regConfirmPasswordtextBox.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.regConfirmPasswordtextBox.Location = new System.Drawing.Point(181, 178);
            this.regConfirmPasswordtextBox.Name = "regConfirmPasswordtextBox";
            this.regConfirmPasswordtextBox.Size = new System.Drawing.Size(116, 22);
            this.regConfirmPasswordtextBox.TabIndex = 7;
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.loginBtn.Location = new System.Drawing.Point(114, 284);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 9;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(86, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter following fields:";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 349);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.regConfirmPasswordtextBox);
            this.Controls.Add(this.RegisterNowButton);
            this.Controls.Add(this.regPasswordTextBox);
            this.Controls.Add(this.regUsernameTextBox);
            this.Controls.Add(this.regRepassword);
            this.Controls.Add(this.regPassword);
            this.Controls.Add(this.regUsername);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label regUsername;
        private System.Windows.Forms.Label regPassword;
        private System.Windows.Forms.Label regRepassword;
        private System.Windows.Forms.TextBox regUsernameTextBox;
        private System.Windows.Forms.TextBox regPasswordTextBox;
        private System.Windows.Forms.Label RegisterNowButton;
        private System.Windows.Forms.TextBox regConfirmPasswordtextBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label1;
    }
}