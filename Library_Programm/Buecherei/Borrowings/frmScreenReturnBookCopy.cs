using Guna.UI2.WinForms;
using LibraryDb_BusinessLayer;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace Buecherei
{
    public partial class frmScreenReturnBookCopy: Form
    {
        clsBorrowingRecords _borrowingRecords;
        bool _isFinePaid = false;
        public frmScreenReturnBookCopy()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _ResetDefaultValue()
        {
            txtUserID.Clear();
            txtCopyID.Clear();
            txtActualReturnDate.Clear();
            dtpBorrowingDate.Value = DateTime.Now;
            dtpDueDate.Value = DateTime.Now.AddDays(3); //by default the Borrowing is for 3 days.
            txtActualReturnDate.Clear();

        }

        private void _LoadBoroowingRecordData()
        {
            if (string.IsNullOrEmpty(txtBorrowingRecordID.Text))
            {
                MessageBox.Show("No borrowing record selected. Please select a record to continue.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int borrowingRecordID = Convert.ToInt32(txtBorrowingRecordID.Text.Trim());

            //we search after data with the borrowingreco
            _borrowingRecords = clsBorrowingRecords.FindByBorrowingRecordID(borrowingRecordID);
            if (_borrowingRecords == null)
            {
                MessageBox.Show("No BorrowingRecord found for the given RecordID.",
                    "BorrowingRecord not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtUserID.Text = _borrowingRecords.UserID.ToString();
            txtCopyID.Text = _borrowingRecords.CopyID.ToString();
            dtpBorrowingDate.Value = _borrowingRecords.BorrowingDate.Value;
            dtpDueDate.Value = _borrowingRecords.DueDate.Value;

            //wenn the varaible ActualReturnDate not Null has has a Value.
            if(_borrowingRecords.ActualReturnDate.HasValue)
                   txtActualReturnDate.Text = _borrowingRecords.ActualReturnDate.Value.ToShortDateString()  ;
        }

        private void _UpdateDataAfterCopyReturning()
        {
            if(!string.IsNullOrEmpty(txtActualReturnDate.Text))
            {
                MessageBox.Show("This Copo has already been returned and cannnot be processed again.", "Return Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //update the BookCopies.AvailabitityStatus = true
            clsBookCopies bookCopies = clsBookCopies.FindByCopyID(_borrowingRecords.CopyID);
            if (bookCopies == null)
            {
                MessageBox.Show("No book copies found for the given criteria.",
                 "Book Copies Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool updateSuccess = clsBookCopies.UpdateBookCopiesByID(bookCopies.CopyID, bookCopies.BookID, true);
            if (!updateSuccess)
            {
                MessageBox.Show("Failed to update the book copy.AvailibiltyStatus. Please try again.",
                           "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //we set for ActualReturnDate the current Date by Click on the Return Button.
            txtActualReturnDate.Text = DateTime.Now.ToShortDateString();

            updateSuccess = clsBorrowingRecords.UpdateBorrowingRecordsByID(_borrowingRecords.BorrowingRecordID,
                _borrowingRecords.UserID, _borrowingRecords.CopyID, _borrowingRecords.BorrowingDate,
                _borrowingRecords.DueDate, DateTime.Now);

            if (!updateSuccess)
            {
                MessageBox.Show("Failed to returned the borrowingRecord.ActualReturnDate. Please try again.",
                           "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //The Book Return successfully
            string message = $"The BoroowingRecord has been returned successfully!";
            MessageBox.Show($"{message}", $"Borrowing return", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            if (!_IsValidateInput())
            {
                MessageBox.Show("Please fill in all required fields!", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!_CheckIfFineExists())
            {
                return;
            }
            _UpdateDataAfterCopyReturning();
        }

        private bool _CheckIfFineExists()
        {
            if(!string.IsNullOrEmpty(txtActualReturnDate.Text))
            {
                MessageBox.Show($"This Book is already returned on {txtActualReturnDate.Text}", "Book returned", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            DateTime endDate = dtpDueDate.Value;
            DateTime currentDate = DateTime.Now;

            short differenceInDays = Convert.ToSByte((currentDate - endDate).Days);

            if(currentDate > endDate)
            {
                MessageBox.Show($"The book is overdue by {differenceInDays} days. A fine must be paid before Proceeding.",
                    "Overdue",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                _GoToPaymentScreen(differenceInDays);

                if (!_isFinePaid)
                    return false;
            }

            return true;
        }

        private void _GoToPaymentScreen(short numberOfLateDays)
        {
            int userID = Convert.ToInt32(txtUserID.Text);
            int borrowingRecordID = Convert.ToInt32(txtBorrowingRecordID.Text);

            // We get the settings data from the "Settings" table in the database based on the setting ID.
            // Since we only have one setting with ID = 1,
            clsSettings settings = clsSettings.FindBySettingID(1);

            // Check if the settings object is null (no settings were found with the given ID).
            if (settings == null)
            {
                MessageBox.Show("No settings found for the specified ID.", "Settings Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method as there are no settings available to proceed with.
            }
            decimal fineAmount = numberOfLateDays * Convert.ToDecimal(settings.DefaultFilePerDay);
            frmScreenFines frm = new frmScreenFines(userID, borrowingRecordID, fineAmount, numberOfLateDays);
            frm.OnSendData += _GetDataFromFineScreen; // subscribe the methode _GetDataFromFineScreen to the even.
            frm.ShowDialog();
        }
        private void _GetDataFromFineScreen(object sender, int? fineID)
        {
            if (fineID != null)
                _isFinePaid = true;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            _ResetDefaultValue();

            _LoadBoroowingRecordData();
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
            isValid &= _CheckData(txtCopyID, "Copy cannot be empty!");
          
            return isValid;
        }

        private void txtBorrowingRecordID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
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

        private void btnBookDetails_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCopyID.Text))
            {
                MessageBox.Show("No Copy ID selected.", "Copy ID Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int copyID = Convert.ToInt32(txtCopyID.Text.Trim());
            clsBooks books = clsBooks.FindBookByCopyID(copyID);

            if (books == null)
            {
                MessageBox.Show("No Book found with the given CopyID.", "Book Not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmBookDetails frm = new frmBookDetails(books);
            frm.ShowDialog();
        }
    }
}
