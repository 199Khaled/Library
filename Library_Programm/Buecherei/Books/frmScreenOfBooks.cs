using Guna.UI2.WinForms;
using LibraryDb_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace Buecherei
{
    public partial class frmScreenOfBooks: Form
    {
        clsBooks _books;
        BindingSource _bindingSource;
        enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode = enMode.AddNew;
        public frmScreenOfBooks()
        {
            InitializeComponent();
            _bindingSource = new BindingSource();
            _Mode = enMode.AddNew;
        }
        
        private void _ResetDefaultTextBoxSetting()
        {
            txtTitle.FillColor = Color.White;
            txtISBN.FillColor = Color.White;
            txtGenre.FillColor = Color.White;

            errorProvider1.SetError(txtTitle, null);
            errorProvider1.SetError(txtISBN, null);
            errorProvider1.SetError(txtGenre, null);
        }
        private void _ResetDefaultValues()
        {
            _Mode = enMode.AddNew;
            btnSave.Text = "Save";
            lblBookID.Text = "??";
            txtTitle.Clear();
            txtISBN.Clear();
            txtGenre.Clear();
            txtAdditionalDatails.Clear();
            dtpPublicationDate.Value = DateTime.Now;

            _ResetDefaultTextBoxSetting();
        }
       
        private bool _CheckData(Guna2TextBox textBox, string message)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.FillColor = Color.LightPink;
                errorProvider1.SetError(textBox,message);
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
            isValid &= _CheckData(txtTitle,"Titel shoud be not empty!");
            isValid &= _CheckData(txtISBN, "ISBN shoud be not empty!");
            isValid &= _CheckData(txtGenre, "Genre shoud be not empty!");

            return isValid;
        }

        private void _LoadData(clsBooks books)
        {
            if (books != null)
            {
                lblBookID.Text = books.BookID.ToString();
                txtTitle.Text = books.Title;
                txtISBN.Text = books.ISBN;
                dtpPublicationDate.Value = books.PublicationDate.Value;
                txtGenre.Text = books.Genre;
                txtAdditionalDatails.Text = books.AdditionalDetails;
            }
        }
        private void _FillData()
        {
            if(_Mode == enMode.AddNew) // if the mode adding, we must create a new instanz of the class clsBooks.
                 _books = new clsBooks();

            _books.Title = txtTitle.Text.Trim();
            _books.ISBN = txtISBN.Text.Trim();
            _books.PublicationDate = dtpPublicationDate.Value;
            _books.Genre = txtGenre.Text.Trim();
            _books.AdditionalDetails = txtAdditionalDatails.Text.Trim();
        }

        private bool _IsDateSavedSuccess()
        {
            if (!_IsValidateInput())
            {
                MessageBox.Show("Please fill in all required fields!", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            _FillData(); //Fille the Data of the Book

            if (!_books.Save())
            {
                MessageBox.Show("An error occurred while saving the book. Please try again.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //The Book saved successfully
            lblBookID.Text = _books.BookID.ToString();
            string status = (_Mode == enMode.AddNew ? "saved" : "updated");
            string message = $"The book has been {status} successfully!";
            MessageBox.Show($"{message}", $"Book {status}", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            _ResetDefaultValues();
        }

        private void txtCopy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!_IsDateSavedSuccess())
            {
                return;
            }
               
            _ResetDefaultValues();
            _LoadDataFromDatabase();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadDataFromDatabase()
        {
            DataTable dtBooks = clsBooks.GetAllBooks();

            if(dtBooks != null && dtBooks.Rows.Count > 0)
            {
                _bindingSource.DataSource = dtBooks;
                dgvBooks.DataSource = _bindingSource;
            }
        }
        private void frmScreenOfBooks_Load(object sender, EventArgs e)
        {
            _LoadDataFromDatabase();
        }

        private void dgvBooks_DoubleClick(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            _Mode = enMode.Update;
            btnSave.Text = "Update";
            int booksID = (int)dgvBooks.CurrentRow.Cells[0].Value;
            _books = clsBooks.FindByBookID(booksID);
            _LoadData(_books);
           
        }

        private void cbFilterby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterby.SelectedIndex != -1)
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
                if (filterColumn == "BookID")
                    _bindingSource.Filter = $"{filterColumn} = {filterValue}";
                else
                    _bindingSource.Filter = $"{filterColumn} like '{filterValue}%'";
            }
            else
            {
                _bindingSource.Filter = string.Empty;
                if(!string.IsNullOrEmpty(txtTitle.Text))
                {
                    _ResetDefaultValues();
                }
            }
        }
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (cbFilterby.SelectedIndex == -1)
                return;

            _ApplyFilter();
        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            string filterColumn = cbFilterby.Text.Trim();
            if (filterColumn == "BookID" && (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblBookID.Text) || lblBookID.Text == "??")
            { 
                MessageBox.Show("Please select a valid row before proceeding.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookID = Convert.ToInt16(lblBookID.Text); //we save the value of bookID in the declared Valriable bookID.

            //wa make it sure, that the user will do the transaktion.
            bool warningMessage = MessageBox.Show("Are you sure, you want to delete Data of this book?","Warning",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes;

            //if No, we go back from the methode
            if (!warningMessage)
                return;

            if (warningMessage && clsBooks.DeleteBooks(bookID))
            {
                MessageBox.Show("The book has been deleted successfully!", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefaultValues();
                _LoadDataFromDatabase();
            }
            else
            {
                MessageBox.Show("An error occurred while deleting the book. Please try again.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGoToCopySide_Click(object sender, EventArgs e)
        {
            frmScreenCopies frm = new frmScreenCopies();
            frm.ShowDialog();
        }
    }
}
