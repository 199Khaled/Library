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
    public partial class frmScreenSettings: Form
    {
        clsSettings _settings;
        public frmScreenSettings()
        {
            InitializeComponent();
        }

        private void _LoadSettingsDataFromDatabase()
        {
            //we just have one setting ID .therefore we set 1 as parameter in the methode.
            _settings = clsSettings.FindBySettingID(1); 
            if(_settings == null)
            {
                MessageBox.Show("No Setting found", "Setting not found", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            txtDefaultBorrowingDays.Text = _settings.DefaultBorrowingDays.ToString();
            txtDefaultReservationDays.Text = _settings.DefaultReservationDays.ToString();
            txtDefaultFineDay.Text = _settings.DefaultFilePerDay.ToString() ;
        }

        private void _FillData()
        {
            _settings.DefaultBorrowingDays = Convert.ToByte(txtDefaultBorrowingDays.Text.Trim())
;           _settings.DefaultReservationDays = Convert.ToByte(txtDefaultReservationDays.Text.Trim());
            _settings.DefaultFilePerDay = Convert.ToDecimal(txtDefaultFineDay.Text.Trim());
        }
        private void frmScreenSettings_Load(object sender, EventArgs e)
        {
              _LoadSettingsDataFromDatabase();
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
            isValid &= _CheckData(txtDefaultBorrowingDays, "Default BorrowingdDays cannot be empty!");
            isValid &= _CheckData(txtDefaultReservationDays, "Default ReservationDays cannot be empty!");
            isValid &= _CheckData(txtDefaultFineDay, "Default Fine Per Day cannot be empty!");

            return isValid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _SaveSettingSDate();
        }
        private void _SaveSettingSDate()
        {
            if (!_IsValidateInput())
            {
                MessageBox.Show("Please fill in all required fields!", "Missing Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _FillData();
            if (!_settings.Save())
            {
                MessageBox.Show("An Error occured while saving setting", "seving faild",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        
            string message = $"Setting has been updated succesfully";
            MessageBox.Show(message, $"update Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
