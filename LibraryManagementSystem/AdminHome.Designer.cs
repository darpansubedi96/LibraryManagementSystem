﻿namespace LibraryManagementSystem
{
    partial class AdminHome
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
            this.lms = new System.Windows.Forms.Label();
            this.addBooks = new System.Windows.Forms.Button();
            this.viewBooks = new System.Windows.Forms.Button();
            this.lendButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.memberButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoutButton = new System.Windows.Forms.PictureBox();
            this.memberAccountBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).BeginInit();
            this.SuspendLayout();
            // 
            // lms
            // 
            this.lms.AutoSize = true;
            this.lms.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lms.Location = new System.Drawing.Point(217, 12);
            this.lms.Name = "lms";
            this.lms.Size = new System.Drawing.Size(353, 31);
            this.lms.TabIndex = 0;
            this.lms.Text = "Library Management System";
            // 
            // addBooks
            // 
            this.addBooks.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.addBooks.Location = new System.Drawing.Point(80, 149);
            this.addBooks.Name = "addBooks";
            this.addBooks.Size = new System.Drawing.Size(108, 36);
            this.addBooks.TabIndex = 3;
            this.addBooks.Text = "Add Books";
            this.addBooks.UseVisualStyleBackColor = true;
            this.addBooks.Click += new System.EventHandler(this.addBooks_Click);
            // 
            // viewBooks
            // 
            this.viewBooks.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.viewBooks.Location = new System.Drawing.Point(259, 150);
            this.viewBooks.Name = "viewBooks";
            this.viewBooks.Size = new System.Drawing.Size(108, 35);
            this.viewBooks.TabIndex = 4;
            this.viewBooks.Text = "View Books";
            this.viewBooks.UseVisualStyleBackColor = true;
            this.viewBooks.Click += new System.EventHandler(this.viewBooks_Click);
            // 
            // lendButton
            // 
            this.lendButton.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lendButton.Location = new System.Drawing.Point(80, 237);
            this.lendButton.Name = "lendButton";
            this.lendButton.Size = new System.Drawing.Size(108, 39);
            this.lendButton.TabIndex = 8;
            this.lendButton.Text = "Lend";
            this.lendButton.UseVisualStyleBackColor = true;
            this.lendButton.Click += new System.EventHandler(this.lendButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.returnButton.Location = new System.Drawing.Point(259, 237);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(108, 39);
            this.returnButton.TabIndex = 9;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // memberButton
            // 
            this.memberButton.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberButton.Location = new System.Drawing.Point(115, 305);
            this.memberButton.Name = "memberButton";
            this.memberButton.Size = new System.Drawing.Size(173, 39);
            this.memberButton.TabIndex = 10;
            this.memberButton.Text = "Membership";
            this.memberButton.UseVisualStyleBackColor = true;
            this.memberButton.Click += new System.EventHandler(this.memberButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMS.Properties.Resources.pngaaa_com_58333;
            this.pictureBox1.Location = new System.Drawing.Point(448, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // logoutButton
            // 
            this.logoutButton.Image = global::LMS.Properties.Resources.clipart1411375;
            this.logoutButton.Location = new System.Drawing.Point(763, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(25, 23);
            this.logoutButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoutButton.TabIndex = 22;
            this.logoutButton.TabStop = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // memberAccountBtn
            // 
            this.memberAccountBtn.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.memberAccountBtn.Location = new System.Drawing.Point(138, 406);
            this.memberAccountBtn.Name = "memberAccountBtn";
            this.memberAccountBtn.Size = new System.Drawing.Size(139, 23);
            this.memberAccountBtn.TabIndex = 24;
            this.memberAccountBtn.Text = "MemberAccount";
            this.memberAccountBtn.UseVisualStyleBackColor = true;
            this.memberAccountBtn.Click += new System.EventHandler(this.studentAccountBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label2.Location = new System.Drawing.Point(125, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Create member account:";
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.memberAccountBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.memberButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.lendButton);
            this.Controls.Add(this.viewBooks);
            this.Controls.Add(this.addBooks);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lms);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminHome";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addBooks;
        private System.Windows.Forms.Button viewBooks;
        private System.Windows.Forms.Button lendButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button memberButton;
        private System.Windows.Forms.PictureBox logoutButton;
        private System.Windows.Forms.Button memberAccountBtn;
        private System.Windows.Forms.Label label2;
    }
}