using Guna.UI2.WinForms;
using LibraryDb_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Buecherei
{
    public partial class frmScreenReservations: Form
    {
        int _bookID;
        clsReservations _reservatoins;
        DataTable _dtReservation;
        BindingSource _bindingSource;
        enum enMode  {AddNew = 1, Update = 2}
        enMode _Mode;
        public frmScreenReservations()
        {
            InitializeComponent();
            _bindingSource = new BindingSource();

            _Mode = enMode.AddNew; //At first we set the Mode on Addnew.
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _ResetDefaultValues()
        {
            _Mode = enMode.AddNew; //by default we set the Mode on Addnew.

            lblReservationID.Text = "??";
            btnReserveBook.Text = "reserve book";
            txtUserID.Clear();
            byte? defualtReservationDays = clsSettings.FindBySettingID(1).DefaultReservationDays;
            dtpReservationDate.Value = DateTime.Now.Date.AddDays((byte)defualtReservationDays);
            chbIsReserved.Checked = true;
        }

        private void _LoadReservationDataFromDatabase()
        {
            _dtReservation = clsReservations.GetAllReservations();
            if (_dtReservation != null && _dtReservation.Rows.Count > 0)
            {            
                _bindingSource.DataSource = _dtReservation;
                dgvReservations.DataSource = _bindingSource;
            }
        }
        private void frmScreenReservations_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            _LoadReservationDataFromDatabase();
        }

        private void _FillCopieComboBoxWithData()
        {
            cbCopyItems.Items.Clear();

            DataTable dtCopie = clsBookCopies.GetAllBookCopiesByBookID(_bookID);
            if (dtCopie != null && dtCopie.Rows.Count > 0)
            {
                foreach (DataRow row in dtCopie.Rows)
                {
                    int CopyID = Convert.ToInt32(row["CopyID"]);
                    bool isReserved = clsReservations.IsThis_BookCopyReserved(CopyID);
                    if (!isReserved)
                        cbCopyItems.Items.Add(CopyID);
                }
            }
            // Set SelectedIndex **only if** there are items in the ComboBox
            if (cbCopyItems.Items.Count > 0)
            {
                cbCopyItems.SelectedIndex = 0;
            }
        }
        private void ctFilterOfBooks1_OnSelectedBook_1(int bookID)
        {
            if (bookID != -1)
                _bookID = bookID;

            _FillCopieComboBoxWithData();
        }

        private bool _CheckData(Guna2TextBox textBox, string message)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.FillColor = Color.LightPink;
                errorProvider1.SetError(textBox, message);
                return false;
            }
            else
            {
                textBox.FillColor = Color.White;
                errorProvider1.SetError(textBox, null);
                return true;
            }
        }
        private bool _IsValidateInput()
        {
            bool isValid = true;
            isValid &= _CheckData(txtUserID, "User cannot be empty!");

            //check if Combobox does not have items
            if (cbCopyItems.Items.Count == 0)
                isValid = false;

            return isValid;
        }
        private void btnBookDetails_Click(object sender, EventArgs e)
        {
            if (cbCopyItems.Items.Count == 0)
            {
                MessageBox.Show("No Copy ID selected.", "Copy ID Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int copyID = Convert.ToInt32(cbCopyItems.Text);
            clsBooks books = clsBooks.FindBookByCopyID(copyID);

            if (books == null)
            {
                MessageBox.Show("No Book found with the given CopyID.", "Book Not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmBookDetails frm = new frmBookDetails(books);
            frm.ShowDialog();
        }

        private void btnUserDetails_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text))
            {
                MessageBox.Show("No User ID selected.", "User ID Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userID = Convert.ToInt32(txtUserID.Text.Trim());
            clsUsers users = clsUsers.FindByUserID(userID);

            if (users == null)
            {
                MessageBox.Show("No User found with the given UserID.", "User Not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmUserDetails frm = new frmUserDetails(users);
            frm.ShowDialog();
        }

        private bool _IsFillDataSuccessfully()
        {
            if (_Mode == enMode.AddNew)
                _reservatoins = new clsReservations();

            int userID = Convert.ToInt32(txtUserID.Text.Trim());
            if (!clsUsers.DoesUserExists(userID))
            {
                MessageBox.Show("User does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            _reservatoins.UserID = userID;

            int copyID = Convert.ToInt32(cbCopyItems.Text.Trim());
            if (clsReservations.IsThis_BookCopyReserved(copyID))
            {
                MessageBox.Show("This Copy is already reserved!", "Copy reserved", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            _reservatoins.CopyID = copyID;
            _reservatoins.ReservationDate = dtpReservationDate.Value;
         
            _reservatoins.IsReserved = chbIsReserved.Checked;

            return true;
        }

        private bool _isDataSavedSuccessfully()
        {
            if (!_IsValidateInput())
            {
                MessageBox.Show("Please fill in all required fields!", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!_IsFillDataSuccessfully())
            {
                return false;
            }
            if(!_reservatoins.Save())
            {
                MessageBox.Show("Error occurrd while saving Reservation", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            //The Book saved successfully
            string status = (_Mode == enMode.AddNew ? "reserved" : "unreserved");
            string message = $"The Book has been {status} successfully!";
            MessageBox.Show($"{message}", $"Reservation {status}", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _reservatoins.Mode = clsReservations.enMode.Update;
            _Mode = enMode.Update;
            lblReservationID.Text = _reservatoins.ReservationID.ToString();

            _LoadReservationDataFromDatabase(); //after Saving Success we update the datagridview

            return true;
        }
        private void btnReserveBook_Click(object sender, EventArgs e)
        {
            if (!_isDataSavedSuccessfully())
                return;

            _ResetDefaultValues();
        }

        private void cbFilterby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterby.SelectedIndex != -1)
            {
                txtFilterValue.Clear();
                txtFilterValue.Focus();
            }
        }

        private void _ApplyFilter()
        {
            string filterValue = txtFilterValue.Text.Trim();
            string filterColumn = cbFilterby.Text.Trim();
            if (!string.IsNullOrEmpty(filterValue))
            {
                if (filterColumn == "ReservationID" ||filterColumn == "UserID" || filterColumn == "CopyID")
                {
                    _bindingSource.Filter = $"{filterColumn} = {filterValue}";
                }
                else
                  _bindingSource.Filter = $"{filterColumn} like '{filterValue}%'";
            }
            else
            {
                _bindingSource.Filter = string.Empty;
        
            }
        }
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            string filterColumn = cbFilterby.Text.Trim();
            if (filterColumn == "ReservationID" || filterColumn == "UserID" || filterColumn == "CopyID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
        }
    }
}
