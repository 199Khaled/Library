namespace Buecherei
{
    partial class frmScreenBorrowing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbCopyItems = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnBorrowBook = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDueDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpBorrowingDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctFilterOfBooks2 = new Buecherei.ctFilterOfBooks();
            this.lblBorrowingRecordID = new System.Windows.Forms.Label();
            this.btnUserDetails = new Guna.UI2.WinForms.Guna2Button();
            this.dgvBookCopies = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCopies)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCopyItems
            // 
            this.cbCopyItems.BackColor = System.Drawing.Color.Transparent;
            this.cbCopyItems.BorderColor = System.Drawing.Color.Gray;
            this.cbCopyItems.BorderRadius = 15;
            this.cbCopyItems.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCopyItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCopyItems.FocusedColor = System.Drawing.Color.Empty;
            this.cbCopyItems.FocusedState.Parent = this.cbCopyItems;
            this.cbCopyItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCopyItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCopyItems.FormattingEnabled = true;
            this.cbCopyItems.HoverState.Parent = this.cbCopyItems;
            this.cbCopyItems.ItemHeight = 30;
            this.cbCopyItems.ItemsAppearance.Parent = this.cbCopyItems;
            this.cbCopyItems.Location = new System.Drawing.Point(179, 232);
            this.cbCopyItems.Name = "cbCopyItems";
            this.cbCopyItems.ShadowDecoration.Parent = this.cbCopyItems;
            this.cbCopyItems.Size = new System.Drawing.Size(481, 36);
            this.cbCopyItems.TabIndex = 73;
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
            this.btnCancel.Location = new System.Drawing.Point(543, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(116, 40);
            this.btnCancel.TabIndex = 72;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.BorderRadius = 10;
            this.btnBorrowBook.CheckedState.Parent = this.btnBorrowBook;
            this.btnBorrowBook.CustomImages.Parent = this.btnBorrowBook;
            this.btnBorrowBook.FillColor = System.Drawing.SystemColors.GrayText;
            this.btnBorrowBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowBook.ForeColor = System.Drawing.Color.White;
            this.btnBorrowBook.HoverState.Parent = this.btnBorrowBook;
            this.btnBorrowBook.Location = new System.Drawing.Point(186, 402);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.ShadowDecoration.Parent = this.btnBorrowBook;
            this.btnBorrowBook.Size = new System.Drawing.Size(116, 40);
            this.btnBorrowBook.TabIndex = 71;
            this.btnBorrowBook.Text = "Borrow Book";
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 20);
            this.label9.TabIndex = 69;
            this.label9.Text = "Borrowing RecordID:";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpDueDate.BorderColor = System.Drawing.Color.Gray;
            this.dtpDueDate.BorderRadius = 10;
            this.dtpDueDate.CheckedState.Parent = this.dtpDueDate;
            this.dtpDueDate.FillColor = System.Drawing.Color.SteelBlue;
            this.dtpDueDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.ForeColor = System.Drawing.Color.White;
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDueDate.HoverState.Parent = this.dtpDueDate;
            this.dtpDueDate.Location = new System.Drawing.Point(178, 351);
            this.dtpDueDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDueDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.ShadowDecoration.Parent = this.dtpDueDate;
            this.dtpDueDate.Size = new System.Drawing.Size(481, 36);
            this.dtpDueDate.TabIndex = 68;
            this.dtpDueDate.Value = new System.DateTime(2025, 2, 26, 0, 0, 0, 0);
            // 
            // dtpBorrowingDate
            // 
            this.dtpBorrowingDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpBorrowingDate.BorderColor = System.Drawing.Color.Gray;
            this.dtpBorrowingDate.BorderRadius = 10;
            this.dtpBorrowingDate.CheckedState.Parent = this.dtpBorrowingDate;
            this.dtpBorrowingDate.FillColor = System.Drawing.Color.SteelBlue;
            this.dtpBorrowingDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBorrowingDate.ForeColor = System.Drawing.Color.White;
            this.dtpBorrowingDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpBorrowingDate.HoverState.Parent = this.dtpBorrowingDate;
            this.dtpBorrowingDate.Location = new System.Drawing.Point(179, 312);
            this.dtpBorrowingDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBorrowingDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBorrowingDate.Name = "dtpBorrowingDate";
            this.dtpBorrowingDate.ShadowDecoration.Parent = this.dtpBorrowingDate;
            this.dtpBorrowingDate.Size = new System.Drawing.Size(481, 36);
            this.dtpBorrowingDate.TabIndex = 67;
            this.dtpBorrowingDate.Value = new System.DateTime(2025, 2, 26, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 66;
            this.label6.Text = "Due Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 65;
            this.label7.Text = "Borrowing Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(106, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 64;
            this.label8.Text = "CopyID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "UserID:";
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
            this.txtUserID.Location = new System.Drawing.Point(179, 271);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.PasswordChar = '\0';
            this.txtUserID.PlaceholderText = "User ID";
            this.txtUserID.SelectedText = "";
            this.txtUserID.ShadowDecoration.Parent = this.txtUserID;
            this.txtUserID.Size = new System.Drawing.Size(481, 36);
            this.txtUserID.TabIndex = 75;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctFilterOfBooks2
            // 
            this.ctFilterOfBooks2.BackColor = System.Drawing.Color.Silver;
            this.ctFilterOfBooks2.FilterEnable = false;
            this.ctFilterOfBooks2.Location = new System.Drawing.Point(12, 12);
            this.ctFilterOfBooks2.Name = "ctFilterOfBooks2";
            this.ctFilterOfBooks2.Size = new System.Drawing.Size(695, 172);
            this.ctFilterOfBooks2.TabIndex = 63;
            this.ctFilterOfBooks2.OnSelectedBook += new Buecherei.ctFilterOfBooks.SelectedBook(this.ctFilterOfBooks2_OnSelectedBook);
            // 
            // lblBorrowingRecordID
            // 
            this.lblBorrowingRecordID.AutoSize = true;
            this.lblBorrowingRecordID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowingRecordID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBorrowingRecordID.Location = new System.Drawing.Point(182, 201);
            this.lblBorrowingRecordID.Name = "lblBorrowingRecordID";
            this.lblBorrowingRecordID.Size = new System.Drawing.Size(36, 20);
            this.lblBorrowingRecordID.TabIndex = 76;
            this.lblBorrowingRecordID.Text = "???";
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
            this.btnUserDetails.Location = new System.Drawing.Point(667, 273);
            this.btnUserDetails.Name = "btnUserDetails";
            this.btnUserDetails.ShadowDecoration.Parent = this.btnUserDetails;
            this.btnUserDetails.Size = new System.Drawing.Size(50, 29);
            this.btnUserDetails.TabIndex = 77;
            this.btnUserDetails.Text = "...";
            this.btnUserDetails.Click += new System.EventHandler(this.btnUserDetails_Click);
            // 
            // dgvBookCopies
            // 
            this.dgvBookCopies.AllowUserToAddRows = false;
            this.dgvBookCopies.AllowUserToDeleteRows = false;
            this.dgvBookCopies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookCopies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookCopies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookCopies.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookCopies.EnableHeadersVisualStyles = false;
            this.dgvBookCopies.Location = new System.Drawing.Point(18, 514);
            this.dgvBookCopies.MultiSelect = false;
            this.dgvBookCopies.Name = "dgvBookCopies";
            this.dgvBookCopies.ReadOnly = true;
            this.dgvBookCopies.Size = new System.Drawing.Size(702, 298);
            this.dgvBookCopies.TabIndex = 78;
            // 
            // frmScreenBorrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 824);
            this.Controls.Add(this.dgvBookCopies);
            this.Controls.Add(this.btnUserDetails);
            this.Controls.Add(this.lblBorrowingRecordID);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCopyItems);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBorrowBook);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.dtpBorrowingDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ctFilterOfBooks2);
            this.Name = "frmScreenBorrowing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrowings";
            this.Load += new System.EventHandler(this.frmScreenBorrowing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCopies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbCopyItems;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnBorrowBook;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDueDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBorrowingDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private ctFilterOfBooks ctFilterOfBooks2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtUserID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblBorrowingRecordID;
        private Guna.UI2.WinForms.Guna2Button btnUserDetails;
        private System.Windows.Forms.DataGridView dgvBookCopies;
    }
}