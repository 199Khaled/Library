namespace Buecherei
{
    partial class frmScreenReturnBookCopy
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
            this.dtpDueDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpBorrowingDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtBorrowingRecordID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnReturnBook = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtActualReturnDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCopyID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUserDetails = new Guna.UI2.WinForms.Guna2Button();
            this.btnBookDetails = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpDueDate.BorderColor = System.Drawing.Color.Gray;
            this.dtpDueDate.BorderRadius = 10;
            this.dtpDueDate.CheckedState.Parent = this.dtpDueDate;
            this.dtpDueDate.FillColor = System.Drawing.Color.Teal;
            this.dtpDueDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.ForeColor = System.Drawing.Color.White;
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDueDate.HoverState.Parent = this.dtpDueDate;
            this.dtpDueDate.Location = new System.Drawing.Point(176, 254);
            this.dtpDueDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDueDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.ShadowDecoration.Parent = this.dtpDueDate;
            this.dtpDueDate.Size = new System.Drawing.Size(279, 36);
            this.dtpDueDate.TabIndex = 44;
            this.dtpDueDate.Value = new System.DateTime(2025, 2, 26, 0, 0, 0, 0);
            // 
            // dtpBorrowingDate
            // 
            this.dtpBorrowingDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpBorrowingDate.BorderColor = System.Drawing.Color.Gray;
            this.dtpBorrowingDate.BorderRadius = 10;
            this.dtpBorrowingDate.CheckedState.Parent = this.dtpBorrowingDate;
            this.dtpBorrowingDate.FillColor = System.Drawing.Color.Teal;
            this.dtpBorrowingDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBorrowingDate.ForeColor = System.Drawing.Color.White;
            this.dtpBorrowingDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpBorrowingDate.HoverState.Parent = this.dtpBorrowingDate;
            this.dtpBorrowingDate.Location = new System.Drawing.Point(177, 208);
            this.dtpBorrowingDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBorrowingDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBorrowingDate.Name = "dtpBorrowingDate";
            this.dtpBorrowingDate.ShadowDecoration.Parent = this.dtpBorrowingDate;
            this.dtpBorrowingDate.Size = new System.Drawing.Size(279, 36);
            this.dtpBorrowingDate.TabIndex = 43;
            this.dtpBorrowingDate.Value = new System.DateTime(2025, 2, 26, 0, 0, 0, 0);
            // 
            // txtBorrowingRecordID
            // 
            this.txtBorrowingRecordID.BorderColor = System.Drawing.Color.Gray;
            this.txtBorrowingRecordID.BorderRadius = 15;
            this.txtBorrowingRecordID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBorrowingRecordID.DefaultText = "";
            this.txtBorrowingRecordID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBorrowingRecordID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBorrowingRecordID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBorrowingRecordID.DisabledState.Parent = this.txtBorrowingRecordID;
            this.txtBorrowingRecordID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBorrowingRecordID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBorrowingRecordID.FocusedState.Parent = this.txtBorrowingRecordID;
            this.txtBorrowingRecordID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrowingRecordID.ForeColor = System.Drawing.Color.Black;
            this.txtBorrowingRecordID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBorrowingRecordID.HoverState.Parent = this.txtBorrowingRecordID;
            this.txtBorrowingRecordID.Location = new System.Drawing.Point(176, 35);
            this.txtBorrowingRecordID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBorrowingRecordID.Name = "txtBorrowingRecordID";
            this.txtBorrowingRecordID.PasswordChar = '\0';
            this.txtBorrowingRecordID.PlaceholderText = "Boroowing Record ID";
            this.txtBorrowingRecordID.SelectedText = "";
            this.txtBorrowingRecordID.ShadowDecoration.Parent = this.txtBorrowingRecordID;
            this.txtBorrowingRecordID.Size = new System.Drawing.Size(200, 36);
            this.txtBorrowingRecordID.TabIndex = 41;
            this.txtBorrowingRecordID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBorrowingRecordID_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Due Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Borrowing Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "CopyID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "UserID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Borrowing RecordID:";
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.SystemColors.GrayText;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(339, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(116, 40);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BorderRadius = 10;
            this.btnReturnBook.CheckedState.Parent = this.btnReturnBook;
            this.btnReturnBook.CustomImages.Parent = this.btnReturnBook;
            this.btnReturnBook.FillColor = System.Drawing.SystemColors.GrayText;
            this.btnReturnBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.ForeColor = System.Drawing.Color.White;
            this.btnReturnBook.HoverState.Parent = this.btnReturnBook;
            this.btnReturnBook.Location = new System.Drawing.Point(176, 372);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.ShadowDecoration.Parent = this.btnReturnBook;
            this.btnReturnBook.Size = new System.Drawing.Size(116, 40);
            this.btnReturnBook.TabIndex = 46;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.SystemColors.GrayText;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(386, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(70, 40);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtActualReturnDate
            // 
            this.txtActualReturnDate.BorderColor = System.Drawing.Color.Gray;
            this.txtActualReturnDate.BorderRadius = 15;
            this.txtActualReturnDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtActualReturnDate.DefaultText = "";
            this.txtActualReturnDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtActualReturnDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtActualReturnDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtActualReturnDate.DisabledState.Parent = this.txtActualReturnDate;
            this.txtActualReturnDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtActualReturnDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtActualReturnDate.FocusedState.Parent = this.txtActualReturnDate;
            this.txtActualReturnDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActualReturnDate.ForeColor = System.Drawing.Color.Black;
            this.txtActualReturnDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtActualReturnDate.HoverState.Parent = this.txtActualReturnDate;
            this.txtActualReturnDate.Location = new System.Drawing.Point(177, 305);
            this.txtActualReturnDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtActualReturnDate.Name = "txtActualReturnDate";
            this.txtActualReturnDate.PasswordChar = '\0';
            this.txtActualReturnDate.PlaceholderText = "Actual Return Date";
            this.txtActualReturnDate.SelectedText = "";
            this.txtActualReturnDate.ShadowDecoration.Parent = this.txtActualReturnDate;
            this.txtActualReturnDate.Size = new System.Drawing.Size(279, 36);
            this.txtActualReturnDate.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Actual Return Date:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtUserID
            // 
            this.txtUserID.BorderColor = System.Drawing.Color.Gray;
            this.txtUserID.BorderRadius = 15;
            this.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserID.DefaultText = "";
            this.txtUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserID.DisabledState.Parent = this.txtUserID;
            this.txtUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserID.FocusedState.Parent = this.txtUserID;
            this.txtUserID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.ForeColor = System.Drawing.Color.Black;
            this.txtUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserID.HoverState.Parent = this.txtUserID;
            this.txtUserID.Location = new System.Drawing.Point(177, 116);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.PasswordChar = '\0';
            this.txtUserID.PlaceholderText = "User ID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.SelectedText = "";
            this.txtUserID.ShadowDecoration.Parent = this.txtUserID;
            this.txtUserID.Size = new System.Drawing.Size(279, 36);
            this.txtUserID.TabIndex = 42;
            // 
            // txtCopyID
            // 
            this.txtCopyID.BackColor = System.Drawing.Color.Transparent;
            this.txtCopyID.BorderColor = System.Drawing.Color.Gray;
            this.txtCopyID.BorderRadius = 15;
            this.txtCopyID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCopyID.DefaultText = "";
            this.txtCopyID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCopyID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCopyID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCopyID.DisabledState.Parent = this.txtCopyID;
            this.txtCopyID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCopyID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCopyID.FocusedState.Parent = this.txtCopyID;
            this.txtCopyID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopyID.ForeColor = System.Drawing.Color.Black;
            this.txtCopyID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCopyID.HoverState.Parent = this.txtCopyID;
            this.txtCopyID.Location = new System.Drawing.Point(176, 162);
            this.txtCopyID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCopyID.Name = "txtCopyID";
            this.txtCopyID.PasswordChar = '\0';
            this.txtCopyID.PlaceholderText = "Copy ID";
            this.txtCopyID.ReadOnly = true;
            this.txtCopyID.SelectedText = "";
            this.txtCopyID.ShadowDecoration.Parent = this.txtCopyID;
            this.txtCopyID.Size = new System.Drawing.Size(279, 36);
            this.txtCopyID.TabIndex = 51;
            // 
            // btnUserDetails
            // 
            this.btnUserDetails.BorderRadius = 10;
            this.btnUserDetails.CheckedState.Parent = this.btnUserDetails;
            this.btnUserDetails.CustomImages.Parent = this.btnUserDetails;
            this.btnUserDetails.FillColor = System.Drawing.SystemColors.GrayText;
            this.btnUserDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserDetails.ForeColor = System.Drawing.Color.White;
            this.btnUserDetails.HoverState.Parent = this.btnUserDetails;
            this.btnUserDetails.Location = new System.Drawing.Point(463, 121);
            this.btnUserDetails.Name = "btnUserDetails";
            this.btnUserDetails.ShadowDecoration.Parent = this.btnUserDetails;
            this.btnUserDetails.Size = new System.Drawing.Size(50, 29);
            this.btnUserDetails.TabIndex = 78;
            this.btnUserDetails.Text = "...";
            this.btnUserDetails.Click += new System.EventHandler(this.btnUserDetails_Click);
            // 
            // btnBookDetails
            // 
            this.btnBookDetails.BorderRadius = 10;
            this.btnBookDetails.CheckedState.Parent = this.btnBookDetails;
            this.btnBookDetails.CustomImages.Parent = this.btnBookDetails;
            this.btnBookDetails.FillColor = System.Drawing.SystemColors.GrayText;
            this.btnBookDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookDetails.ForeColor = System.Drawing.Color.White;
            this.btnBookDetails.HoverState.Parent = this.btnBookDetails;
            this.btnBookDetails.Location = new System.Drawing.Point(463, 165);
            this.btnBookDetails.Name = "btnBookDetails";
            this.btnBookDetails.ShadowDecoration.Parent = this.btnBookDetails;
            this.btnBookDetails.Size = new System.Drawing.Size(50, 29);
            this.btnBookDetails.TabIndex = 79;
            this.btnBookDetails.Text = "...";
            this.btnBookDetails.Click += new System.EventHandler(this.btnBookDetails_Click);
            // 
            // frmScreenReturnBookCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 424);
            this.Controls.Add(this.btnBookDetails);
            this.Controls.Add(this.btnUserDetails);
            this.Controls.Add(this.txtCopyID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtActualReturnDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.dtpBorrowingDate);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.txtBorrowingRecordID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScreenReturnBookCopy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Book Copy";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDueDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBorrowingDate;
        private Guna.UI2.WinForms.Guna2TextBox txtBorrowingRecordID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnReturnBook;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtActualReturnDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2TextBox txtUserID;
        private Guna.UI2.WinForms.Guna2TextBox txtCopyID;
        private Guna.UI2.WinForms.Guna2Button btnBookDetails;
        private Guna.UI2.WinForms.Guna2Button btnUserDetails;
    }
}