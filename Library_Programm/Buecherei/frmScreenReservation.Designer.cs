namespace Buecherei
{
    partial class frmScreenReservations
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
            this.btnBookDetails = new Guna.UI2.WinForms.Guna2Button();
            this.btnUserDetails = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnReserveBook = new Guna.UI2.WinForms.Guna2Button();
            this.dtpReservationDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReservationID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chbIsReserved = new Guna.UI2.WinForms.Guna2CheckBox();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFilterby = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCopyItems = new Guna.UI2.WinForms.Guna2ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctFilterOfBooks1 = new Buecherei.ctFilterOfBooks();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.btnBookDetails.Location = new System.Drawing.Point(656, 244);
            this.btnBookDetails.Name = "btnBookDetails";
            this.btnBookDetails.ShadowDecoration.Parent = this.btnBookDetails;
            this.btnBookDetails.Size = new System.Drawing.Size(50, 29);
            this.btnBookDetails.TabIndex = 93;
            this.btnBookDetails.Text = "...";
            this.btnBookDetails.Click += new System.EventHandler(this.btnBookDetails_Click);
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
            this.btnUserDetails.Location = new System.Drawing.Point(330, 244);
            this.btnUserDetails.Name = "btnUserDetails";
            this.btnUserDetails.ShadowDecoration.Parent = this.btnUserDetails;
            this.btnUserDetails.Size = new System.Drawing.Size(50, 29);
            this.btnUserDetails.TabIndex = 92;
            this.btnUserDetails.Text = "...";
            this.btnUserDetails.Click += new System.EventHandler(this.btnUserDetails_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(586, 367);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(116, 40);
            this.btnCancel.TabIndex = 88;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReserveBook
            // 
            this.btnReserveBook.BorderRadius = 10;
            this.btnReserveBook.CheckedState.Parent = this.btnReserveBook;
            this.btnReserveBook.CustomImages.Parent = this.btnReserveBook;
            this.btnReserveBook.FillColor = System.Drawing.SystemColors.GrayText;
            this.btnReserveBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserveBook.ForeColor = System.Drawing.Color.White;
            this.btnReserveBook.HoverState.Parent = this.btnReserveBook;
            this.btnReserveBook.Location = new System.Drawing.Point(450, 367);
            this.btnReserveBook.Name = "btnReserveBook";
            this.btnReserveBook.ShadowDecoration.Parent = this.btnReserveBook;
            this.btnReserveBook.Size = new System.Drawing.Size(116, 40);
            this.btnReserveBook.TabIndex = 87;
            this.btnReserveBook.Text = "Reserve Book";
            this.btnReserveBook.Click += new System.EventHandler(this.btnReserveBook_Click);
            // 
            // dtpReservationDate
            // 
            this.dtpReservationDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpReservationDate.BorderColor = System.Drawing.Color.Gray;
            this.dtpReservationDate.BorderRadius = 10;
            this.dtpReservationDate.CheckedState.Parent = this.dtpReservationDate;
            this.dtpReservationDate.FillColor = System.Drawing.Color.Teal;
            this.dtpReservationDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReservationDate.ForeColor = System.Drawing.Color.White;
            this.dtpReservationDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpReservationDate.HoverState.Parent = this.dtpReservationDate;
            this.dtpReservationDate.Location = new System.Drawing.Point(161, 290);
            this.dtpReservationDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpReservationDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpReservationDate.Name = "dtpReservationDate";
            this.dtpReservationDate.ShadowDecoration.Parent = this.dtpReservationDate;
            this.dtpReservationDate.Size = new System.Drawing.Size(331, 36);
            this.dtpReservationDate.TabIndex = 85;
            this.dtpReservationDate.Value = new System.DateTime(2025, 3, 2, 0, 0, 0, 0);
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
            this.txtUserID.Location = new System.Drawing.Point(161, 239);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.PasswordChar = '\0';
            this.txtUserID.PlaceholderText = "User ID";
            this.txtUserID.SelectedText = "";
            this.txtUserID.ShadowDecoration.Parent = this.txtUserID;
            this.txtUserID.Size = new System.Drawing.Size(164, 36);
            this.txtUserID.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 82;
            this.label4.Text = "Reservation Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 81;
            this.label3.Text = "CopyID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 80;
            this.label2.Text = "UserID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 94;
            this.label1.Text = "ReservationID:";
            // 
            // lblReservationID
            // 
            this.lblReservationID.AutoSize = true;
            this.lblReservationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblReservationID.Location = new System.Drawing.Point(157, 204);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(27, 20);
            this.lblReservationID.TabIndex = 95;
            this.lblReservationID.Text = "??";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(561, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 96;
            this.label5.Text = "isReserved:";
            // 
            // chbIsReserved
            // 
            this.chbIsReserved.AutoSize = true;
            this.chbIsReserved.Checked = true;
            this.chbIsReserved.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbIsReserved.CheckedState.BorderRadius = 2;
            this.chbIsReserved.CheckedState.BorderThickness = 0;
            this.chbIsReserved.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbIsReserved.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIsReserved.Location = new System.Drawing.Point(669, 299);
            this.chbIsReserved.Name = "chbIsReserved";
            this.chbIsReserved.Size = new System.Drawing.Size(15, 14);
            this.chbIsReserved.TabIndex = 97;
            this.chbIsReserved.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbIsReserved.UncheckedState.BorderRadius = 2;
            this.chbIsReserved.UncheckedState.BorderThickness = 0;
            this.chbIsReserved.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbIsReserved.UseVisualStyleBackColor = true;
            // 
            // dgvReservations
            // 
            this.dgvReservations.AllowUserToAddRows = false;
            this.dgvReservations.AllowUserToDeleteRows = false;
            this.dgvReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservations.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReservations.EnableHeadersVisualStyles = false;
            this.dgvReservations.Location = new System.Drawing.Point(15, 477);
            this.dgvReservations.MultiSelect = false;
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.Size = new System.Drawing.Size(687, 320);
            this.dgvReservations.TabIndex = 98;
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderColor = System.Drawing.Color.Gray;
            this.txtFilterValue.BorderRadius = 15;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.DefaultText = "";
            this.txtFilterValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.DisabledState.Parent = this.txtFilterValue;
            this.txtFilterValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.FocusedState.Parent = this.txtFilterValue;
            this.txtFilterValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValue.ForeColor = System.Drawing.Color.Black;
            this.txtFilterValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.HoverState.Parent = this.txtFilterValue;
            this.txtFilterValue.Location = new System.Drawing.Point(262, 433);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.PlaceholderText = "Filter Value";
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.ShadowDecoration.Parent = this.txtFilterValue;
            this.txtFilterValue.Size = new System.Drawing.Size(440, 36);
            this.txtFilterValue.TabIndex = 101;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // cbFilterby
            // 
            this.cbFilterby.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterby.BorderColor = System.Drawing.Color.Gray;
            this.cbFilterby.BorderRadius = 15;
            this.cbFilterby.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterby.FocusedColor = System.Drawing.Color.Empty;
            this.cbFilterby.FocusedState.Parent = this.cbFilterby;
            this.cbFilterby.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterby.ForeColor = System.Drawing.Color.Black;
            this.cbFilterby.FormattingEnabled = true;
            this.cbFilterby.HoverState.Parent = this.cbFilterby;
            this.cbFilterby.ItemHeight = 30;
            this.cbFilterby.Items.AddRange(new object[] {
            "ReservationID",
            "UserID",
            "CopyID",
            "ReservationData"});
            this.cbFilterby.ItemsAppearance.Parent = this.cbFilterby;
            this.cbFilterby.Location = new System.Drawing.Point(83, 433);
            this.cbFilterby.Name = "cbFilterby";
            this.cbFilterby.ShadowDecoration.Parent = this.cbFilterby;
            this.cbFilterby.Size = new System.Drawing.Size(175, 36);
            this.cbFilterby.TabIndex = 100;
            this.cbFilterby.SelectedIndexChanged += new System.EventHandler(this.cbFilterby_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 99;
            this.label8.Text = "Filter by:";
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
            this.cbCopyItems.Location = new System.Drawing.Point(487, 237);
            this.cbCopyItems.Name = "cbCopyItems";
            this.cbCopyItems.ShadowDecoration.Parent = this.cbCopyItems;
            this.cbCopyItems.Size = new System.Drawing.Size(164, 36);
            this.cbCopyItems.TabIndex = 102;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctFilterOfBooks1
            // 
            this.ctFilterOfBooks1.BackColor = System.Drawing.Color.Silver;
            this.ctFilterOfBooks1.FilterEnable = true;
            this.ctFilterOfBooks1.Location = new System.Drawing.Point(11, 12);
            this.ctFilterOfBooks1.Name = "ctFilterOfBooks1";
            this.ctFilterOfBooks1.Size = new System.Drawing.Size(695, 172);
            this.ctFilterOfBooks1.TabIndex = 103;
            this.ctFilterOfBooks1.OnSelectedBook += new Buecherei.ctFilterOfBooks.SelectedBook(this.ctFilterOfBooks1_OnSelectedBook_1);
            // 
            // frmScreenReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 809);
            this.Controls.Add(this.ctFilterOfBooks1);
            this.Controls.Add(this.cbCopyItems);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterby);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvReservations);
            this.Controls.Add(this.chbIsReserved);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblReservationID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBookDetails);
            this.Controls.Add(this.btnUserDetails);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReserveBook);
            this.Controls.Add(this.dtpReservationDate);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScreenReservations";
            this.Text = "Reservations";
            this.Load += new System.EventHandler(this.frmScreenReservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnBookDetails;
        private Guna.UI2.WinForms.Guna2Button btnUserDetails;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnReserveBook;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpReservationDate;
        private Guna.UI2.WinForms.Guna2TextBox txtUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReservationID;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2CheckBox chbIsReserved;
        private System.Windows.Forms.DataGridView dgvReservations;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterby;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox cbCopyItems;
        private ctFilterOfBooks ctFilterOfBooks1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}