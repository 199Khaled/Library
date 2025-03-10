namespace Buecherei
{
    partial class frmScreenCopies
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRemoveCopies = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddCopies = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvBookCopies = new System.Windows.Forms.DataGridView();
            this.cbFilterby = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtCopieCount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumDownNumberOfCopies = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ctFilterOfBooks1 = new Buecherei.ctFilterOfBooks();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDownNumberOfCopies)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveCopies
            // 
            this.btnRemoveCopies.BorderRadius = 10;
            this.btnRemoveCopies.CheckedState.Parent = this.btnRemoveCopies;
            this.btnRemoveCopies.CustomImages.Parent = this.btnRemoveCopies;
            this.btnRemoveCopies.FillColor = System.Drawing.Color.SteelBlue;
            this.btnRemoveCopies.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCopies.ForeColor = System.Drawing.Color.White;
            this.btnRemoveCopies.HoverState.Parent = this.btnRemoveCopies;
            this.btnRemoveCopies.Location = new System.Drawing.Point(591, 243);
            this.btnRemoveCopies.Name = "btnRemoveCopies";
            this.btnRemoveCopies.ShadowDecoration.Parent = this.btnRemoveCopies;
            this.btnRemoveCopies.Size = new System.Drawing.Size(128, 40);
            this.btnRemoveCopies.TabIndex = 25;
            this.btnRemoveCopies.Text = "Remove Copies";
            this.btnRemoveCopies.Click += new System.EventHandler(this.btnRemoveCopies_Click);
            // 
            // btnAddCopies
            // 
            this.btnAddCopies.BorderRadius = 10;
            this.btnAddCopies.CheckedState.Parent = this.btnAddCopies;
            this.btnAddCopies.CustomImages.Parent = this.btnAddCopies;
            this.btnAddCopies.FillColor = System.Drawing.Color.SteelBlue;
            this.btnAddCopies.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCopies.ForeColor = System.Drawing.Color.White;
            this.btnAddCopies.HoverState.Parent = this.btnAddCopies;
            this.btnAddCopies.Location = new System.Drawing.Point(457, 243);
            this.btnAddCopies.Name = "btnAddCopies";
            this.btnAddCopies.ShadowDecoration.Parent = this.btnAddCopies;
            this.btnAddCopies.Size = new System.Drawing.Size(128, 40);
            this.btnAddCopies.TabIndex = 26;
            this.btnAddCopies.Text = "Add Copies";
            this.btnAddCopies.Click += new System.EventHandler(this.btnAddCopies_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Filter by:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BackColor = System.Drawing.Color.Transparent;
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
            this.txtFilterValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValue.ForeColor = System.Drawing.Color.Black;
            this.txtFilterValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.HoverState.Parent = this.txtFilterValue;
            this.txtFilterValue.Location = new System.Drawing.Point(268, 321);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.PlaceholderText = "Filter Value";
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.ShadowDecoration.Parent = this.txtFilterValue;
            this.txtFilterValue.Size = new System.Drawing.Size(448, 36);
            this.txtFilterValue.TabIndex = 31;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
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
            this.dgvBookCopies.Location = new System.Drawing.Point(17, 363);
            this.dgvBookCopies.MultiSelect = false;
            this.dgvBookCopies.Name = "dgvBookCopies";
            this.dgvBookCopies.ReadOnly = true;
            this.dgvBookCopies.Size = new System.Drawing.Size(702, 337);
            this.dgvBookCopies.TabIndex = 32;
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
            "CopyID",
            "BookID"});
            this.cbFilterby.ItemsAppearance.Parent = this.cbFilterby;
            this.cbFilterby.Location = new System.Drawing.Point(103, 321);
            this.cbFilterby.Name = "cbFilterby";
            this.cbFilterby.ShadowDecoration.Parent = this.cbFilterby;
            this.cbFilterby.Size = new System.Drawing.Size(161, 36);
            this.cbFilterby.TabIndex = 33;
            this.cbFilterby.SelectedIndexChanged += new System.EventHandler(this.cbFilterby_SelectedIndexChanged);
            // 
            // txtCopieCount
            // 
            this.txtCopieCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCopieCount.DefaultText = "0";
            this.txtCopieCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCopieCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCopieCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCopieCount.DisabledState.Parent = this.txtCopieCount;
            this.txtCopieCount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCopieCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCopieCount.FocusedState.Parent = this.txtCopieCount;
            this.txtCopieCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopieCount.ForeColor = System.Drawing.Color.Black;
            this.txtCopieCount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCopieCount.HoverState.Parent = this.txtCopieCount;
            this.txtCopieCount.Location = new System.Drawing.Point(182, 709);
            this.txtCopieCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCopieCount.Name = "txtCopieCount";
            this.txtCopieCount.PasswordChar = '\0';
            this.txtCopieCount.PlaceholderText = "";
            this.txtCopieCount.ReadOnly = true;
            this.txtCopieCount.SelectedText = "";
            this.txtCopieCount.SelectionStart = 1;
            this.txtCopieCount.ShadowDecoration.Parent = this.txtCopieCount;
            this.txtCopieCount.Size = new System.Drawing.Size(74, 36);
            this.txtCopieCount.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 719);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Number of Copies:";
            // 
            // NumDownNumberOfCopies
            // 
            this.NumDownNumberOfCopies.BackColor = System.Drawing.Color.Transparent;
            this.NumDownNumberOfCopies.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumDownNumberOfCopies.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NumDownNumberOfCopies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NumDownNumberOfCopies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NumDownNumberOfCopies.DisabledState.Parent = this.NumDownNumberOfCopies;
            this.NumDownNumberOfCopies.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.NumDownNumberOfCopies.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.NumDownNumberOfCopies.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NumDownNumberOfCopies.FocusedState.Parent = this.NumDownNumberOfCopies;
            this.NumDownNumberOfCopies.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumDownNumberOfCopies.ForeColor = System.Drawing.Color.Black;
            this.NumDownNumberOfCopies.Location = new System.Drawing.Point(287, 243);
            this.NumDownNumberOfCopies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumDownNumberOfCopies.Name = "NumDownNumberOfCopies";
            this.NumDownNumberOfCopies.ShadowDecoration.Parent = this.NumDownNumberOfCopies;
            this.NumDownNumberOfCopies.Size = new System.Drawing.Size(97, 40);
            this.NumDownNumberOfCopies.TabIndex = 36;
            this.NumDownNumberOfCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Number of Copies, you want to add:";
            // 
            // ctFilterOfBooks1
            // 
            this.ctFilterOfBooks1.BackColor = System.Drawing.Color.Silver;
            this.ctFilterOfBooks1.FilterEnable = false;
            this.ctFilterOfBooks1.Location = new System.Drawing.Point(24, 27);
            this.ctFilterOfBooks1.Name = "ctFilterOfBooks1";
            this.ctFilterOfBooks1.Size = new System.Drawing.Size(695, 172);
            this.ctFilterOfBooks1.TabIndex = 0;
            this.ctFilterOfBooks1.OnSelectedBook += new Buecherei.ctFilterOfBooks.SelectedBook(this.ctFilterOfBooks1_OnSelectedBook);
            // 
            // frmScreenCopies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 757);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumDownNumberOfCopies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCopieCount);
            this.Controls.Add(this.cbFilterby);
            this.Controls.Add(this.dgvBookCopies);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddCopies);
            this.Controls.Add(this.btnRemoveCopies);
            this.Controls.Add(this.ctFilterOfBooks1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScreenCopies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copies";
            this.Load += new System.EventHandler(this.frmScreenCopies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDownNumberOfCopies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctFilterOfBooks ctFilterOfBooks1;
        private Guna.UI2.WinForms.Guna2Button btnRemoveCopies;
        private Guna.UI2.WinForms.Guna2Button btnAddCopies;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private System.Windows.Forms.DataGridView dgvBookCopies;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterby;
        private Guna.UI2.WinForms.Guna2TextBox txtCopieCount;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumDownNumberOfCopies;
        private System.Windows.Forms.Label label3;
    }
}