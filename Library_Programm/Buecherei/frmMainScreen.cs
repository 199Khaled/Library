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
    public partial class frmMainScreen: Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void btnMangeBooks_Click(object sender, EventArgs e)
        {
            frmScreenOfBooks frm = new frmScreenOfBooks();
            frm.ShowDialog();
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnMangeCopies_Click(object sender, EventArgs e)
        {
            frmScreenCopies frm = new frmScreenCopies();
            frm.ShowDialog();
        }

        private void btnManageBorrowing_Click(object sender, EventArgs e)
        {
            frmScreenBorrowing frm = new frmScreenBorrowing();
            frm.ShowDialog();
        }

        private void btnMangeUsers_Click(object sender, EventArgs e)
        {
            frmScreenOfUsers frm = new frmScreenOfUsers();
            frm.ShowDialog();
        }

        private void btnMangeReturns_Click(object sender, EventArgs e)
        {
            frmScreenReturnBookCopy frm = new frmScreenReturnBookCopy();
            frm.ShowDialog();
        }

        private void btnManageReservations_Click(object sender, EventArgs e)
        {
            frmScreenReservations frm = new frmScreenReservations();
            frm.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmScreenSettings frm = new frmScreenSettings();
            frm.ShowDialog();
        }
    }
}
