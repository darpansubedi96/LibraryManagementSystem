namespace LMS
{
    partial class Lend
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.borrowDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bookNameComboBox = new System.Windows.Forms.ComboBox();
            this.lendButton = new System.Windows.Forms.Button();
            this.noOfBooks = new System.Windows.Forms.Label();
            this.noOfBooksTextBox = new System.Windows.Forms.TextBox();
            this.CancleButton = new System.Windows.Forms.Button();
            this.lms = new System.Windows.Forms.Label();
            this.dataGridViewBorrower = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBorrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfBooksBorrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.borrowerNameComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.logoutButton = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(34, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the borrower information:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Borrower Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of Borrow:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Book Name:";
            // 
            // borrowDateTimePicker
            // 
            this.borrowDateTimePicker.Location = new System.Drawing.Point(127, 220);
            this.borrowDateTimePicker.Name = "borrowDateTimePicker";
            this.borrowDateTimePicker.Size = new System.Drawing.Size(123, 19);
            this.borrowDateTimePicker.TabIndex = 5;
            // 
            // bookNameComboBox
            // 
            this.bookNameComboBox.FormattingEnabled = true;
            this.bookNameComboBox.Location = new System.Drawing.Point(127, 174);
            this.bookNameComboBox.Name = "bookNameComboBox";
            this.bookNameComboBox.Size = new System.Drawing.Size(123, 20);
            this.bookNameComboBox.TabIndex = 6;
            this.bookNameComboBox.Text = "Choose a book name.";
            // 
            // lendButton
            // 
            this.lendButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lendButton.Location = new System.Drawing.Point(55, 327);
            this.lendButton.Name = "lendButton";
            this.lendButton.Size = new System.Drawing.Size(75, 23);
            this.lendButton.TabIndex = 7;
            this.lendButton.Text = "Lend";
            this.lendButton.UseVisualStyleBackColor = true;
            this.lendButton.Click += new System.EventHandler(this.lendButton_Click);
            // 
            // noOfBooks
            // 
            this.noOfBooks.AutoSize = true;
            this.noOfBooks.Location = new System.Drawing.Point(35, 271);
            this.noOfBooks.Name = "noOfBooks";
            this.noOfBooks.Size = new System.Drawing.Size(71, 12);
            this.noOfBooks.TabIndex = 8;
            this.noOfBooks.Text = "No of Books:";
            // 
            // noOfBooksTextBox
            // 
            this.noOfBooksTextBox.Location = new System.Drawing.Point(127, 264);
            this.noOfBooksTextBox.Name = "noOfBooksTextBox";
            this.noOfBooksTextBox.Size = new System.Drawing.Size(123, 19);
            this.noOfBooksTextBox.TabIndex = 9;
            this.noOfBooksTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.noOfBooksTextBox_Validating);
            // 
            // CancleButton
            // 
            this.CancleButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CancleButton.Location = new System.Drawing.Point(160, 327);
            this.CancleButton.Name = "CancleButton";
            this.CancleButton.Size = new System.Drawing.Size(75, 23);
            this.CancleButton.TabIndex = 10;
            this.CancleButton.Text = "Cancle";
            this.CancleButton.UseVisualStyleBackColor = true;
            this.CancleButton.Click += new System.EventHandler(this.CancleButton_Click);
            // 
            // lms
            // 
            this.lms.AutoSize = true;
            this.lms.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lms.Location = new System.Drawing.Point(217, 12);
            this.lms.Name = "lms";
            this.lms.Size = new System.Drawing.Size(353, 31);
            this.lms.TabIndex = 1;
            this.lms.Text = "Library Management System";
            // 
            // dataGridViewBorrower
            // 
            this.dataGridViewBorrower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrower.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.borrowerName,
            this.bookName,
            this.dateOfBorrow,
            this.noOfBooksBorrowed});
            this.dataGridViewBorrower.Location = new System.Drawing.Point(294, 87);
            this.dataGridViewBorrower.Name = "dataGridViewBorrower";
            this.dataGridViewBorrower.RowTemplate.Height = 21;
            this.dataGridViewBorrower.Size = new System.Drawing.Size(494, 351);
            this.dataGridViewBorrower.TabIndex = 11;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 60;
            // 
            // borrowerName
            // 
            this.borrowerName.HeaderText = "Borrower Name";
            this.borrowerName.Name = "borrowerName";
            this.borrowerName.ReadOnly = true;
            this.borrowerName.Width = 145;
            // 
            // bookName
            // 
            this.bookName.HeaderText = "Book Name";
            this.bookName.Name = "bookName";
            this.bookName.ReadOnly = true;
            this.bookName.Width = 140;
            // 
            // dateOfBorrow
            // 
            this.dateOfBorrow.HeaderText = "Date of Borrow";
            this.dateOfBorrow.Name = "dateOfBorrow";
            this.dateOfBorrow.ReadOnly = true;
            this.dateOfBorrow.Width = 110;
            // 
            // noOfBooksBorrowed
            // 
            this.noOfBooksBorrowed.HeaderText = "Numbers";
            this.noOfBooksBorrowed.Name = "noOfBooksBorrowed";
            this.noOfBooksBorrowed.ReadOnly = true;
            this.noOfBooksBorrowed.Width = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(457, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Borrower Information:";
            // 
            // borrowerNameComboBox
            // 
            this.borrowerNameComboBox.FormattingEnabled = true;
            this.borrowerNameComboBox.Location = new System.Drawing.Point(127, 136);
            this.borrowerNameComboBox.Name = "borrowerNameComboBox";
            this.borrowerNameComboBox.Size = new System.Drawing.Size(123, 20);
            this.borrowerNameComboBox.TabIndex = 13;
            this.borrowerNameComboBox.Text = "Choose a member  name.";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
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
            this.backButton.TabIndex = 24;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Lend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.borrowerNameComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewBorrower);
            this.Controls.Add(this.lms);
            this.Controls.Add(this.CancleButton);
            this.Controls.Add(this.noOfBooksTextBox);
            this.Controls.Add(this.noOfBooks);
            this.Controls.Add(this.lendButton);
            this.Controls.Add(this.bookNameComboBox);
            this.Controls.Add(this.borrowDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lend";
            this.Text = "Lend";
            this.Load += new System.EventHandler(this.Lend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker borrowDateTimePicker;
        private System.Windows.Forms.ComboBox bookNameComboBox;
        private System.Windows.Forms.Button lendButton;
        private System.Windows.Forms.Label noOfBooks;
        private System.Windows.Forms.TextBox noOfBooksTextBox;
        private System.Windows.Forms.Button CancleButton;
        private System.Windows.Forms.Label lms;
        private System.Windows.Forms.DataGridView dataGridViewBorrower;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBorrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfBooksBorrowed;
        private System.Windows.Forms.ComboBox borrowerNameComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.PictureBox logoutButton;
        private System.Windows.Forms.PictureBox backButton;
    }
}