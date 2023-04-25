namespace LibraryManagementSystem
{
    partial class AddBooks
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
            this.components = new System.ComponentModel.Container();
            this.lms = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.Label();
            this.bookAuthor = new System.Windows.Forms.Label();
            this.bookCategory = new System.Windows.Forms.Label();
            this.bookCounts = new System.Windows.Forms.Label();
            this.booksNameTextbox = new System.Windows.Forms.TextBox();
            this.booksAuthorTextBox = new System.Windows.Forms.TextBox();
            this.bookCountTextBox = new System.Windows.Forms.TextBox();
            this.bookCategoryDropDown = new System.Windows.Forms.ComboBox();
            this.saveBook = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.SuspendLayout();
            // 
            // lms
            // 
            this.lms.AutoSize = true;
            this.lms.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lms.Location = new System.Drawing.Point(217, 12);
            this.lms.Name = "lms";
            this.lms.Size = new System.Drawing.Size(353, 31);
            this.lms.TabIndex = 2;
            this.lms.Text = "Library Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(88, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Please add book\'s information:";
            // 
            // bookName
            // 
            this.bookName.AutoSize = true;
            this.bookName.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.bookName.Location = new System.Drawing.Point(91, 129);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(84, 15);
            this.bookName.TabIndex = 10;
            this.bookName.Text = "Book Name:";
            // 
            // bookAuthor
            // 
            this.bookAuthor.AutoSize = true;
            this.bookAuthor.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.bookAuthor.Location = new System.Drawing.Point(91, 175);
            this.bookAuthor.Name = "bookAuthor";
            this.bookAuthor.Size = new System.Drawing.Size(91, 15);
            this.bookAuthor.TabIndex = 11;
            this.bookAuthor.Text = "Book Author:";
            // 
            // bookCategory
            // 
            this.bookCategory.AutoSize = true;
            this.bookCategory.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.bookCategory.Location = new System.Drawing.Point(91, 222);
            this.bookCategory.Name = "bookCategory";
            this.bookCategory.Size = new System.Drawing.Size(67, 15);
            this.bookCategory.TabIndex = 12;
            this.bookCategory.Text = "Category:";
            // 
            // bookCounts
            // 
            this.bookCounts.AutoSize = true;
            this.bookCounts.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.bookCounts.Location = new System.Drawing.Point(91, 277);
            this.bookCounts.Name = "bookCounts";
            this.bookCounts.Size = new System.Drawing.Size(87, 15);
            this.bookCounts.TabIndex = 13;
            this.bookCounts.Text = "Book Count:";
            // 
            // booksNameTextbox
            // 
            this.booksNameTextbox.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.booksNameTextbox.Location = new System.Drawing.Point(209, 130);
            this.booksNameTextbox.Name = "booksNameTextbox";
            this.booksNameTextbox.Size = new System.Drawing.Size(278, 22);
            this.booksNameTextbox.TabIndex = 14;
            // 
            // booksAuthorTextBox
            // 
            this.booksAuthorTextBox.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.booksAuthorTextBox.Location = new System.Drawing.Point(209, 175);
            this.booksAuthorTextBox.Name = "booksAuthorTextBox";
            this.booksAuthorTextBox.Size = new System.Drawing.Size(278, 22);
            this.booksAuthorTextBox.TabIndex = 15;
            // 
            // bookCountTextBox
            // 
            this.bookCountTextBox.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.bookCountTextBox.Location = new System.Drawing.Point(209, 277);
            this.bookCountTextBox.Name = "bookCountTextBox";
            this.bookCountTextBox.Size = new System.Drawing.Size(278, 22);
            this.bookCountTextBox.TabIndex = 16;
            this.bookCountTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.bookCountTextBox_Validating);
            // 
            // bookCategoryDropDown
            // 
            this.bookCategoryDropDown.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.bookCategoryDropDown.FormattingEnabled = true;
            this.bookCategoryDropDown.Location = new System.Drawing.Point(209, 222);
            this.bookCategoryDropDown.Name = "bookCategoryDropDown";
            this.bookCategoryDropDown.Size = new System.Drawing.Size(278, 23);
            this.bookCategoryDropDown.TabIndex = 17;
            this.bookCategoryDropDown.Text = "Choose a category.";
            // 
            // saveBook
            // 
            this.saveBook.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.saveBook.Location = new System.Drawing.Point(209, 334);
            this.saveBook.Name = "saveBook";
            this.saveBook.Size = new System.Drawing.Size(75, 23);
            this.saveBook.TabIndex = 18;
            this.saveBook.Text = "Add";
            this.saveBook.UseVisualStyleBackColor = true;
            this.saveBook.Click += new System.EventHandler(this.saveBook_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 48);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add Category";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // backButton
            // 
            this.backButton.Image = global::LMS.Properties.Resources.pngegg;
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(22, 23);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backButton.TabIndex = 23;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveBook);
            this.Controls.Add(this.bookCategoryDropDown);
            this.Controls.Add(this.bookCountTextBox);
            this.Controls.Add(this.booksAuthorTextBox);
            this.Controls.Add(this.booksNameTextbox);
            this.Controls.Add(this.bookCounts);
            this.Controls.Add(this.bookCategory);
            this.Controls.Add(this.bookAuthor);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lms);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBooks";
            this.Text = "AddBooks";
            this.Load += new System.EventHandler(this.AddBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bookName;
        private System.Windows.Forms.Label bookAuthor;
        private System.Windows.Forms.Label bookCategory;
        private System.Windows.Forms.Label bookCounts;
        private System.Windows.Forms.TextBox booksNameTextbox;
        private System.Windows.Forms.TextBox booksAuthorTextBox;
        private System.Windows.Forms.TextBox bookCountTextBox;
        private System.Windows.Forms.ComboBox bookCategoryDropDown;
        private System.Windows.Forms.Button saveBook;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox logoutButton;
        private System.Windows.Forms.PictureBox backButton;
    }
}