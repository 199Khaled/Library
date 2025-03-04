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
    public partial class frmBookDetails: Form
    {
        clsBooks _books;
        public frmBookDetails(clsBooks books)
        {
            InitializeComponent();
            this._books = books;
        }

        private void _ResetDefaultValue()
        {
            lblBookID.Text = "??";
            foreach(Control control in this.Controls)
            {
                if(control is TextBox textbox)
                {
                    textbox.Clear();
                }
            }

            dtpPublicationDate.Value = DateTime.Now;
        }

        private void _FillData()
        {
            lblBookID.Text = _books.BookID.ToString();
            txtTitle.Text = _books.Title;
            txtISBN.Text = _books.ISBN;
            txtGenre.Text = _books.Genre;
            dtpPublicationDate.Value = _books.PublicationDate.Value;
            txtAdditionalDatails.Text = _books.AdditionalDetails;
        }
        private void frmBookDetails_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();
            _FillData();
        }
    }
}
