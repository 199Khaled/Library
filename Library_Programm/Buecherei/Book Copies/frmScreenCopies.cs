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
    public partial class frmScreenCopies: Form
    {
        clsBookCopies _bookCopies;
        BindingSource _bindingSource;
        int _bookID = -1;
        enum enMode { Addnew = 1, Update = 2 }
        enMode _Mode = enMode.Addnew;

        bool _filterEnable;
        public frmScreenCopies(bool filterEnable = true)
        {
            InitializeComponent();
            _bindingSource = new BindingSource();
            _Mode = enMode.Addnew; // at first

            ctFilterOfBooks1.FilterEnable = filterEnable;

        }
        private void _LoadBookCopiesFromDatabase()
        {
            DataTable dtbookCopies = clsBookCopies.GetAllBookCopies();
            if (dtbookCopies != null && dtbookCopies.Rows.Count > 0)
            {
                _bindingSource.DataSource = dtbookCopies;
                dgvBookCopies.DataSource = _bindingSource;
            }
        }
        private void frmScreenCopies_Load(object sender, EventArgs e)
        {
            _LoadBookCopiesFromDatabase();
        }

        private void ctFilterOfBooks1_OnSelectedBook(int bookID)
        {
            if(bookID != -1)
            {
                _bookID = bookID;
            }
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
                if (filterColumn == "BookID" || filterColumn == "CopyID")
                {
                    _bindingSource.Filter = $"{filterColumn} = {filterValue}";
                    txtCopieCount.Text = _bindingSource.Count.ToString();
                }
                //else
                //    _bindingSource.Filter = $"{filterColumn} like '{filterValue}%'";
            }
            else
            {
                _bindingSource.Filter = string.Empty;
                txtCopieCount.Text = "0";
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            string filterColumn = cbFilterby.Text.Trim();
            bool IsNotDigitOrControl = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if ((filterColumn == "BookID" || filterColumn == "CopyID") && IsNotDigitOrControl)
            {
                e.Handled = true;
            }
        }

        private void _ResetDefaultValues()
        {
            _Mode = enMode.Addnew;
        }

        private bool _IsDataFilledSuccessfully()
        {
            if (_bookID == -1)
            {
                MessageBox.Show("No book selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (_Mode == enMode.Addnew)
                _bookCopies = new clsBookCopies();          

            _bookCopies.BookID = _bookID;
            _bookCopies.CopyCount = (int)NumDownNumberOfCopies.Value;
            _bookCopies.AvailabilityStatus = true;

            return true;
        }

        private void btnAddCopies_Click(object sender, EventArgs e)
        {
            if(!_IsDataFilledSuccessfully())
            {
                return;
            }

            string status = _Mode == enMode.Addnew ? "added successfuly" : "updated successfully";
            if(_bookCopies.Save())
            {
                _Mode = enMode.Update;
                _bookCopies.Mode = clsBookCopies.enMode.Update;
                MessageBox.Show($"The book copies have been {status}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _LoadBookCopiesFromDatabase();
                ctFilterOfBooks1.ResetDefaultValue();
            }
            else
            {
                MessageBox.Show("An error occurred while saving the book copies. Please try again.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _ResetDefaultValues();
        }

        private void btnRemoveCopies_Click(object sender, EventArgs e)
        {
            // Prüfen, ob überhaupt eine Zeile ausgewählt ist
            if (dgvBookCopies.CurrentRow == null || dgvBookCopies.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("Please select a valid row before proceeding.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int CopyID = (int)dgvBookCopies.CurrentRow.Cells[0].Value;

            //wa make it sure, that the user will do the transaktion.
            bool warningMessage = MessageBox.Show("Are you sure, you want to delete Data of this Copy?", "Warning",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes;

            //if No, we go back from the methode
            if (!warningMessage)
                return;

            if (warningMessage && clsBookCopies.DeleteBookCopies(CopyID))
            {
                MessageBox.Show("The Copy has been deleted successfully!", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefaultValues();
                _LoadBookCopiesFromDatabase();
            }
            else
            {
                MessageBox.Show("An error occurred while deleting the Copy. Please try again.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
