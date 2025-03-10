namespace Buecherei
{
    partial class frmMainScreen
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
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnManageReservations = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMangeReturns = new System.Windows.Forms.Button();
            this.btnManageBorrowing = new System.Windows.Forms.Button();
            this.btnMangeUsers = new System.Windows.Forms.Button();
            this.btnMangeBooks = new System.Windows.Forms.Button();
            this.btnMangeCopies = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Image = global::Buecherei.Properties.Resources.Settings;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSettings.Location = new System.Drawing.Point(27, 529);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(167, 160);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Manage Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnManageReservations
            // 
            this.btnManageReservations.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnManageReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageReservations.Image = global::Buecherei.Properties.Resources.ReseveBook;
            this.btnManageReservations.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManageReservations.Location = new System.Drawing.Point(214, 197);
            this.btnManageReservations.Name = "btnManageReservations";
            this.btnManageReservations.Size = new System.Drawing.Size(167, 160);
            this.btnManageReservations.TabIndex = 6;
            this.btnManageReservations.Text = "Manage Reservation";
            this.btnManageReservations.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManageReservations.UseVisualStyleBackColor = true;
            this.btnManageReservations.Click += new System.EventHandler(this.btnManageReservations_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Buecherei.Properties.Resources.vertical_shot_interiors_lello_centenary_bookshop_captured_oporto_portugal;
            this.pictureBox1.Location = new System.Drawing.Point(437, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1116, 756);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnMangeReturns
            // 
            this.btnMangeReturns.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMangeReturns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangeReturns.Image = global::Buecherei.Properties.Resources.returnBook;
            this.btnMangeReturns.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMangeReturns.Location = new System.Drawing.Point(214, 363);
            this.btnMangeReturns.Name = "btnMangeReturns";
            this.btnMangeReturns.Size = new System.Drawing.Size(167, 160);
            this.btnMangeReturns.TabIndex = 3;
            this.btnMangeReturns.Text = "Manage Returns";
            this.btnMangeReturns.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMangeReturns.UseVisualStyleBackColor = true;
            this.btnMangeReturns.Click += new System.EventHandler(this.btnMangeReturns_Click);
            // 
            // btnManageBorrowing
            // 
            this.btnManageBorrowing.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnManageBorrowing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageBorrowing.Image = global::Buecherei.Properties.Resources.bookcrossing_102921611;
            this.btnManageBorrowing.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManageBorrowing.Location = new System.Drawing.Point(27, 363);
            this.btnManageBorrowing.Name = "btnManageBorrowing";
            this.btnManageBorrowing.Size = new System.Drawing.Size(167, 160);
            this.btnManageBorrowing.TabIndex = 0;
            this.btnManageBorrowing.Text = "Manage Borrowing";
            this.btnManageBorrowing.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManageBorrowing.UseVisualStyleBackColor = true;
            this.btnManageBorrowing.Click += new System.EventHandler(this.btnManageBorrowing_Click);
            // 
            // btnMangeUsers
            // 
            this.btnMangeUsers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMangeUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangeUsers.Image = global::Buecherei.Properties.Resources.ManageUsers;
            this.btnMangeUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMangeUsers.Location = new System.Drawing.Point(214, 31);
            this.btnMangeUsers.Name = "btnMangeUsers";
            this.btnMangeUsers.Size = new System.Drawing.Size(167, 160);
            this.btnMangeUsers.TabIndex = 4;
            this.btnMangeUsers.Text = "Manage Users";
            this.btnMangeUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMangeUsers.UseVisualStyleBackColor = true;
            this.btnMangeUsers.Click += new System.EventHandler(this.btnMangeUsers_Click);
            // 
            // btnMangeBooks
            // 
            this.btnMangeBooks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMangeBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangeBooks.Image = global::Buecherei.Properties.Resources.Books;
            this.btnMangeBooks.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMangeBooks.Location = new System.Drawing.Point(27, 197);
            this.btnMangeBooks.Name = "btnMangeBooks";
            this.btnMangeBooks.Size = new System.Drawing.Size(167, 160);
            this.btnMangeBooks.TabIndex = 2;
            this.btnMangeBooks.Text = "Manage Books";
            this.btnMangeBooks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMangeBooks.UseVisualStyleBackColor = true;
            this.btnMangeBooks.Click += new System.EventHandler(this.btnMangeBooks_Click);
            // 
            // btnMangeCopies
            // 
            this.btnMangeCopies.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMangeCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangeCopies.Image = global::Buecherei.Properties.Resources.Copies;
            this.btnMangeCopies.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMangeCopies.Location = new System.Drawing.Point(27, 31);
            this.btnMangeCopies.Name = "btnMangeCopies";
            this.btnMangeCopies.Size = new System.Drawing.Size(167, 160);
            this.btnMangeCopies.TabIndex = 1;
            this.btnMangeCopies.Text = "Manage Copies";
            this.btnMangeCopies.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMangeCopies.UseVisualStyleBackColor = true;
            this.btnMangeCopies.Click += new System.EventHandler(this.btnMangeCopies_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1553, 756);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnManageReservations);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMangeReturns);
            this.Controls.Add(this.btnManageBorrowing);
            this.Controls.Add(this.btnMangeUsers);
            this.Controls.Add(this.btnMangeBooks);
            this.Controls.Add(this.btnMangeCopies);
            this.Name = "frmMainScreen";
            this.Text = "frmMainScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageBorrowing;
        private System.Windows.Forms.Button btnMangeCopies;
        private System.Windows.Forms.Button btnMangeBooks;
        private System.Windows.Forms.Button btnMangeReturns;
        private System.Windows.Forms.Button btnMangeUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnManageReservations;
        private System.Windows.Forms.Button btnSettings;
    }
}