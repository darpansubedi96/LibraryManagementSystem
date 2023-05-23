namespace LMS
{
    partial class MemberRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.memberComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.memberUserName = new System.Windows.Forms.TextBox();
            this.memberPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.preUsername = new System.Windows.Forms.Label();
            this.prePassword = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the member to create account:";
            // 
            // memberComboBox
            // 
            this.memberComboBox.FormattingEnabled = true;
            this.memberComboBox.Location = new System.Drawing.Point(139, 81);
            this.memberComboBox.Name = "memberComboBox";
            this.memberComboBox.Size = new System.Drawing.Size(147, 20);
            this.memberComboBox.TabIndex = 1;
            this.memberComboBox.Text = "Choose a member name.";
            this.memberComboBox.SelectedIndexChanged += new System.EventHandler(this.memberComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Member:";
            // 
            // memberUserName
            // 
            this.memberUserName.Location = new System.Drawing.Point(139, 144);
            this.memberUserName.Name = "memberUserName";
            this.memberUserName.Size = new System.Drawing.Size(147, 19);
            this.memberUserName.TabIndex = 3;
            // 
            // memberPassword
            // 
            this.memberPassword.Location = new System.Drawing.Point(139, 183);
            this.memberPassword.Name = "memberPassword";
            this.memberPassword.Size = new System.Drawing.Size(147, 19);
            this.memberPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(139, 244);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prePassword);
            this.groupBox1.Controls.Add(this.preUsername);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(74, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 75);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password:";
            // 
            // preUsername
            // 
            this.preUsername.AutoSize = true;
            this.preUsername.Location = new System.Drawing.Point(82, 26);
            this.preUsername.Name = "preUsername";
            this.preUsername.Size = new System.Drawing.Size(0, 12);
            this.preUsername.TabIndex = 2;
            // 
            // prePassword
            // 
            this.prePassword.AutoSize = true;
            this.prePassword.Location = new System.Drawing.Point(82, 51);
            this.prePassword.Name = "prePassword";
            this.prePassword.Size = new System.Drawing.Size(0, 12);
            this.prePassword.TabIndex = 3;
            // 
            // MemberRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 417);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.memberPassword);
            this.Controls.Add(this.memberUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.memberComboBox);
            this.Controls.Add(this.label1);
            this.Name = "MemberRegistration";
            this.Text = "Member Registration";
            this.Load += new System.EventHandler(this.MemberRegistration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox memberComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox memberUserName;
        private System.Windows.Forms.TextBox memberPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label prePassword;
        private System.Windows.Forms.Label preUsername;
    }
}