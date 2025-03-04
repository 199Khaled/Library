namespace Buecherei
{
    partial class frmScreenSettings
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtDefaultFineDay = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDefaultReservationDays = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDefaultBorrowingDays = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "DefaultBorrowingDays:";
            // 
            // txtDefaultFineDay
            // 
            this.txtDefaultFineDay.BackColor = System.Drawing.Color.Transparent;
            this.txtDefaultFineDay.BorderColor = System.Drawing.Color.Gray;
            this.txtDefaultFineDay.BorderRadius = 10;
            this.txtDefaultFineDay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDefaultFineDay.DefaultText = "";
            this.txtDefaultFineDay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDefaultFineDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDefaultFineDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDefaultFineDay.DisabledState.Parent = this.txtDefaultFineDay;
            this.txtDefaultFineDay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDefaultFineDay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDefaultFineDay.FocusedState.Parent = this.txtDefaultFineDay;
            this.txtDefaultFineDay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefaultFineDay.ForeColor = System.Drawing.Color.Black;
            this.txtDefaultFineDay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDefaultFineDay.HoverState.Parent = this.txtDefaultFineDay;
            this.txtDefaultFineDay.Location = new System.Drawing.Point(209, 133);
            this.txtDefaultFineDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDefaultFineDay.Name = "txtDefaultFineDay";
            this.txtDefaultFineDay.PasswordChar = '\0';
            this.txtDefaultFineDay.PlaceholderText = "Default Fine Per Day";
            this.txtDefaultFineDay.SelectedText = "";
            this.txtDefaultFineDay.ShadowDecoration.Parent = this.txtDefaultFineDay;
            this.txtDefaultFineDay.Size = new System.Drawing.Size(222, 36);
            this.txtDefaultFineDay.TabIndex = 30;
            // 
            // txtDefaultReservationDays
            // 
            this.txtDefaultReservationDays.BackColor = System.Drawing.Color.Transparent;
            this.txtDefaultReservationDays.BorderColor = System.Drawing.Color.Gray;
            this.txtDefaultReservationDays.BorderRadius = 10;
            this.txtDefaultReservationDays.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDefaultReservationDays.DefaultText = "";
            this.txtDefaultReservationDays.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDefaultReservationDays.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDefaultReservationDays.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDefaultReservationDays.DisabledState.Parent = this.txtDefaultReservationDays;
            this.txtDefaultReservationDays.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDefaultReservationDays.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDefaultReservationDays.FocusedState.Parent = this.txtDefaultReservationDays;
            this.txtDefaultReservationDays.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefaultReservationDays.ForeColor = System.Drawing.Color.Black;
            this.txtDefaultReservationDays.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDefaultReservationDays.HoverState.Parent = this.txtDefaultReservationDays;
            this.txtDefaultReservationDays.Location = new System.Drawing.Point(209, 85);
            this.txtDefaultReservationDays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDefaultReservationDays.Name = "txtDefaultReservationDays";
            this.txtDefaultReservationDays.PasswordChar = '\0';
            this.txtDefaultReservationDays.PlaceholderText = "Default Reservation Days";
            this.txtDefaultReservationDays.SelectedText = "";
            this.txtDefaultReservationDays.ShadowDecoration.Parent = this.txtDefaultReservationDays;
            this.txtDefaultReservationDays.Size = new System.Drawing.Size(222, 36);
            this.txtDefaultReservationDays.TabIndex = 29;
            // 
            // txtDefaultBorrowingDays
            // 
            this.txtDefaultBorrowingDays.BackColor = System.Drawing.Color.Transparent;
            this.txtDefaultBorrowingDays.BorderColor = System.Drawing.Color.Gray;
            this.txtDefaultBorrowingDays.BorderRadius = 10;
            this.txtDefaultBorrowingDays.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDefaultBorrowingDays.DefaultText = "";
            this.txtDefaultBorrowingDays.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDefaultBorrowingDays.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDefaultBorrowingDays.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDefaultBorrowingDays.DisabledState.Parent = this.txtDefaultBorrowingDays;
            this.txtDefaultBorrowingDays.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDefaultBorrowingDays.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDefaultBorrowingDays.FocusedState.Parent = this.txtDefaultBorrowingDays;
            this.txtDefaultBorrowingDays.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefaultBorrowingDays.ForeColor = System.Drawing.Color.Black;
            this.txtDefaultBorrowingDays.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDefaultBorrowingDays.HoverState.Parent = this.txtDefaultBorrowingDays;
            this.txtDefaultBorrowingDays.Location = new System.Drawing.Point(209, 37);
            this.txtDefaultBorrowingDays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDefaultBorrowingDays.Name = "txtDefaultBorrowingDays";
            this.txtDefaultBorrowingDays.PasswordChar = '\0';
            this.txtDefaultBorrowingDays.PlaceholderText = "Default Borrowing Days";
            this.txtDefaultBorrowingDays.SelectedText = "";
            this.txtDefaultBorrowingDays.ShadowDecoration.Parent = this.txtDefaultBorrowingDays;
            this.txtDefaultBorrowingDays.Size = new System.Drawing.Size(222, 36);
            this.txtDefaultBorrowingDays.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "DefaultReservationDays:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "DefaultFinePerDays:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 10;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(209, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(104, 40);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(327, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(104, 40);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmScreenSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 260);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDefaultFineDay);
            this.Controls.Add(this.txtDefaultReservationDays);
            this.Controls.Add(this.txtDefaultBorrowingDays);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScreenSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmScreenSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtDefaultFineDay;
        private Guna.UI2.WinForms.Guna2TextBox txtDefaultReservationDays;
        private Guna.UI2.WinForms.Guna2TextBox txtDefaultBorrowingDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}