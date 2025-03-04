using LibraryDb_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buecherei
{
    public partial class frmScreenFines: Form
    {
        int _userID, _borowingRecordID;
        decimal _fineAmount;
        short _numberOfLateDays;

        clsFines _fines;
        //we defeniere a delegate to sende back the FineID
        public delegate void SendDataBack(object sender, int? FineID);
        public event SendDataBack OnSendData;


        public frmScreenFines(int userID, int borrowingRecordID, decimal fineAmount, short numberOfLateDays)
        {
            InitializeComponent();

            this._userID = userID;
            this._borowingRecordID = borrowingRecordID;
            this._fineAmount = fineAmount;
            this._numberOfLateDays = numberOfLateDays;
        }

        private void _LoadData()
        {
            txtUserID.Text = _userID.ToString();
            txtBorrowingRecordID.Text = _borowingRecordID.ToString();
            txtFineAmount.Text = _fineAmount.ToString("C");
            txtNumberOfLateDays.Text = _numberOfLateDays.ToString();

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void _FillData()
        {
            _fines = new clsFines();

            _fines.UserID = _userID;
            _fines.BorrowingRecordID = _borowingRecordID;
            _fines.NumberOfLateDays = _numberOfLateDays;
            _fines.FineAmount = _fineAmount;
            _fines.PaymentStatus = true;
        }

        private void _SaveData()
        {
            _FillData();

            if(!_fines.Save())
            {
                MessageBox.Show("Failed while Fine saving", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _fines.Mode = clsFines.enMode.Update;
            lblFineID.Text = _fines.FineID.ToString();
            //we sent the FineID back, to ensure ,that everythig was success and continue Processign
            OnSendData?.Invoke(this, _fines.FineID); //raise the Event, wehn saving is successful.

            string message = "Fine has been saved successfully.";
            string title = "Save Success";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPayOverdueFine_Click(object sender, EventArgs e)
        {
            _SaveData();
        }

        private void frmScreenFines_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
