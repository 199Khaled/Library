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
    public partial class frmUserDetails: Form
    {
        clsUsers _users;
        public frmUserDetails(clsUsers users)
        {
            InitializeComponent();
            this._users = users;
        }

        private void _ResetDefaultValue()
        {
            foreach(Control control in this.Controls)
            {
                if(control is TextBox textbox)
                {
                    textbox.Clear();
                }
            }
        }
        private void _LoadData()
        {
            txtFirstname.Text = _users.Firstname;
            txtLastname.Text = _users.Lastname;
            txtCity.Text = _users.City;
            txtEmail.Text = _users.Email;
            txtTelefon.Text = _users.Telefon;
            txtLibraryCardNumber.Text = _users.LibraryCardNumber;
        }
        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();
            _LoadData();
        }
    }
}
