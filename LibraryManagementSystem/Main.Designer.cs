namespace LMS
{
    partial class Main
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
            this.adminButton = new System.Windows.Forms.Button();
            this.studentButton = new System.Windows.Forms.Button();
            this.titleLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(196, 137);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(75, 23);
            this.adminButton.TabIndex = 0;
            this.adminButton.Text = "Admin";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // studentButton
            // 
            this.studentButton.Location = new System.Drawing.Point(423, 137);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(75, 23);
            this.studentButton.TabIndex = 1;
            this.studentButton.Text = "Member";
            this.studentButton.UseVisualStyleBackColor = true;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLable.Location = new System.Drawing.Point(190, 9);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(353, 31);
            this.titleLable.TabIndex = 2;
            this.titleLable.Text = "Library Management System";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titleLable);
            this.Controls.Add(this.studentButton);
            this.Controls.Add(this.adminButton);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.Label titleLable;
    }
}