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

namespace Buecherei
{
    public partial class frmScreenBorrowing: Form
    {
        clsBorrowingRecords _borrowings;
        int _bookID;
        enum enMode { Addnew = 1, Update = 2 }
        enMode _Mode = enMode.Addnew;
        public frmScreenBorrowing()
        {
            InitializeComponent();
            _Mode = enMode.Addnew;
            ctFilterOfBooks2.FilterEnable = true;
        }

        private void _ResetDefaultValue()
        {
            _Mode = enMode.Addnew;
            lblBorrowingRecordID.Text = "???";
            txtUserID.Select();
            txtUserID.Clear();
            cbCopyItems.Items.Clear();

            dtpBorrowingDate.Value = DateTime.Now;

            // We get the settings data from the "Settings" table in the database based on the setting ID.
            // Since we only have one setting with ID = 1,
            clsSettings settings = clsSettings.FindBySettingID(1);

            // Check if the settings object is null (no settings were found with the given ID).
            if (settings == null)
            {
                MessageBox.Show("No settings found for the specified ID.", "Settings Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method as there are no settings available to proceed with.
            }
            dtpDueDate.Value = DateTime.Now.AddDays((int)settings.DefaultBorrowingDays); //by default the Borrowing is for 3 days.
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
            isValid &= _CheckData(txtUserID, "User shoud be not empty!");

            //check if Combobox does not have items
            if (cbCopyItems.Items.Count == 0)
                isValid = false;

            //check if borrowing date is bevore due date
            if(dtpBorrowingDate.Value > dtpDueDate.Value)
            {
                MessageBox.Show("The borrowing date cannot be after the due date.");
                isValid = false;
            }
            return isValid;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmScreenBorrowing_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();
        }

        private bool _IsFillDataSuccessfully()
        {
            if (_Mode == enMode.Addnew)
                _borrowings = new clsBorrowingRecords();
            int userID = Convert.ToInt32(txtUserID.Text.Trim());
            if (!clsUsers.DoesUserExists(userID))
            {
                MessageBox.Show("User does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            _borrowings.UserID = userID;

            int copyID = Convert.ToInt32(cbCopyItems.Text.Trim());
            if (!clsBookCopies.DoesBookCopyExistsAndAvailable(copyID))
            {
                MessageBox.Show("This Copy is not available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            _borrowings.CopyID = copyID;
            _borrowings.BorrowingDate = dtpBorrowingDate.Value;

          
            _borrowings.DueDate = dtpDueDate.Value;

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

            if (!_borrowings.Save())
            {
                MessageBox.Show("An error occurred while saving the boroowing. Please try again.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //The Book saved successfully
            string status = (_Mode == enMode.Addnew ? "saved" : "updated");
            string message = $"The user has been {status} successfully!";
            MessageBox.Show($"{message}", $"Borrowing {status}", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblBorrowingRecordID.Text = _borrowings.BorrowingRecordID.ToString();
            _borrowings.Mode = clsBorrowingRecords.enMode.Update;  // Set the mode of the borrowing object to Update.
            _Mode = enMode.Update; // Update the current mode of the form/process.


            //update the BookCopies.AvailabitityStatus = false
            clsBookCopies bookCopies = clsBookCopies.FindByCopyID(_borrowings.CopyID);
            if (bookCopies == null)
            {
                MessageBox.Show("No book copies found for the given criteria.",
                 "Book Copies Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool updateSuccess = clsBookCopies.UpdateBookCopiesByID(bookCopies.CopyID, bookCopies.BookID, false);
            if (!updateSuccess)
            {
                MessageBox.Show("Failed to update the book copy. Please try again.",
                           "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
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
                    if (!clsReservations.IsThis_BookCopyReserved(CopyID)) //if not reversed, add it.
                        cbCopyItems.Items.Add(CopyID);
                }
            }
            // Set SelectedIndex **only if** there are items in the ComboBox
            if (cbCopyItems.Items.Count > 0)
            {
                cbCopyItems.SelectedIndex = 0;
            }
        }
        private void ctFilterOfBooks2_OnSelectedBook(int bookID)
        {
            if (bookID != -1)
            {
                _bookID = bookID;
            }
            _FillCopieComboBoxWithData();
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            _isDataSavedSuccessfully();
        }

        private void btnUserDetails_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUserID.Text))
            {
                MessageBox.Show("No User ID selected.", "User ID Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userID = Convert.ToInt32(txtUserID.Text.Trim());
            clsUsers users = clsUsers.FindByUserID(userID);

            if(users == null)
            {
                MessageBox.Show("No User found with the given UserID.", "User Not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmUserDetails frm = new frmUserDetails(users);
            frm.ShowDialog();
        }
    }
}
