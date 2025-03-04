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
    public partial class frmScreenOfUsers: Form
    {
        clsUsers _users;
        BindingSource _bindingSource;
        enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode = enMode.AddNew;
        public frmScreenOfUsers()
        {
            InitializeComponent();
            _bindingSource = new BindingSource();
            _Mode = enMode.AddNew;
        }

        private void _LoadUserDataFromDatabase()
        {
            DataTable dtUsers = clsUsers.GetAllUsers();
            if(dtUsers != null && dtUsers.Rows.Count > 0)
            {
                _bindingSource.DataSource = dtUsers;
                dgvUsers.DataSource = _bindingSource;
            }
        }
        private void _ResetDefaultTextBoxColor()
        {
            txtFirstname.FillColor = Color.White;
            txtLastname.FillColor = Color.White;
            txtCity.FillColor = Color.White;

            errorProvider1.SetError(txtFirstname, null);
            errorProvider1.SetError(txtLastname, null);
            errorProvider1.SetError(txtCity, null);
        }
        private void _ResetDefaultValues()
        {
            _Mode = enMode.AddNew;
            btnSave.Text = "Save";
            lblUserID.Text = "??";
            txtFirstname.Clear();
            txtLastname.Clear();
            txtCity.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            txtLibraryCardNumber.Clear();

            _ResetDefaultTextBoxColor();
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
            isValid &= _CheckData(txtFirstname, "Firstname shoud be not empty!");
            isValid &= _CheckData(txtLastname, "Lastname shoud be not empty!");
            isValid &= _CheckData(txtCity, "City shoud be not empty!");

            return isValid;
        }

        private void frmScreenOfUsers_Load(object sender, EventArgs e)
        {
            _LoadUserDataFromDatabase();
        }

        private void _LoadData(clsUsers user)
        {
            if (user != null)
            {
                lblUserID.Text = user.UserID.ToString();
                txtFirstname.Text = user.Firstname;
                txtLastname.Text = user.Lastname;
                txtCity.Text = user.City;
                txtTelefon.Text = user.Telefon;
                txtEmail.Text = user.Email;
                txtLibraryCardNumber.Text = user.LibraryCardNumber;
            }
        }
        private void _FillData()
        {
            if (_Mode == enMode.AddNew) // if the mode adding, we must create a new instanz of the class clsBooks.
                _users = new clsUsers();

            _users.Firstname = txtFirstname.Text.Trim();
            _users.Lastname = txtLastname.Text.Trim();
            _users.City = txtCity.Text.Trim();
            _users.Telefon = txtTelefon.Text.Trim();
            _users.Email = txtEmail.Text.Trim();
            _users.LibraryCardNumber = txtLibraryCardNumber.Text.Trim();
        }

        private bool _IsDateSavedSuccess()
        {
            if (!_IsValidateInput())
            {
                MessageBox.Show("Please fill in all required fields!", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            _FillData(); //Fille the Data of the Book

            if (!_users.Save())
            {
                MessageBox.Show("An error occurred while saving the user. Please try again.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //The Book saved successfully
            lblUserID.Text = _users.UserID.ToString();
            string status = (_Mode == enMode.AddNew ? "saved" : "updated");
            string message = $"The user has been {status} successfully!";
            MessageBox.Show($"{message}", $"User {status}", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_IsDateSavedSuccess())
                return;
            _ResetDefaultValues();
            _LoadUserDataFromDatabase();
        }

        private void dgvBookCopies_DoubleClick(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            _Mode = enMode.Update;
            btnSave.Text = "Update";
            int userID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            _users = clsUsers.FindByUserID(userID);
            _LoadData(_users);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblUserID.Text) || lblUserID.Text == "??")
            {
                MessageBox.Show("Please select a valid row before proceeding.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int userID = Convert.ToInt16(lblUserID.Text); //we save the value of userID in the declared Valriable UserID.

            //wa make it sure, that the user will do the transaktion.
            bool warningMessage = MessageBox.Show("Are you sure, you want to delete Data of this User?", "Warning",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes;

            //if No, we go back from the methode
            if (!warningMessage)
                return;

            if (warningMessage && clsUsers.DeleteUsers(userID))
            {
                MessageBox.Show("The User has been deleted successfully!", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefaultValues();
                _LoadUserDataFromDatabase();
            }
            else
            {
                MessageBox.Show("An error occurred while deleting the User. Please try again.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _ResetDefaultValues();
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
                if (filterColumn == "UserID")
                    _bindingSource.Filter = $"{filterColumn} = {filterValue}";
                else
                    _bindingSource.Filter = $"{filterColumn} like '{filterValue}%'";
            }
            else
            {
                _bindingSource.Filter = string.Empty;
                //we reset the defualt value while filtering, when the boxs are filled with data, 
                //in case a field as txtFirstname has a data and not empty.
                if (!string.IsNullOrEmpty(txtFirstname.Text))
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
            if (filterColumn == "UserID" && (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnGoToBorrowingScreen_Click(object sender, EventArgs e)
        {
            frmScreenBorrowing frm = new frmScreenBorrowing();
            frm.ShowDialog();
        }

        private void btnCreateLibraryCardNumber_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string cardNumber;
            do
            {
                cardNumber = random.Next(100000000, 999999999).ToString();
            } while (clsUsers.IsCardNumberExists(cardNumber));

            txtLibraryCardNumber.Text = "L" + cardNumber;
        }
    }
}
