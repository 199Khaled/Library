using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryDb_BusinessLayer;
using System.Runtime.InteropServices;

namespace Buecherei
{
    public partial class ctFilterOfBooks: UserControl
    {
        private bool _filterEnable;
        public bool FilterEnable
        {
            get { return _filterEnable; }
            set
            {
                _filterEnable = value;
                gpBookInfos.Enabled = _filterEnable;
            }
        }
        public ctFilterOfBooks()
        {
            InitializeComponent();
        }

        //define a Custom event event handler delegate with Parameters .
        public delegate void SelectedBook(int bookID);
        public event SelectedBook OnSelectedBook;
        //define a Methode to rais the Event with the Parameters
        public void OnSelected(int bookID)
        {
            OnSelectedBook?.Invoke(bookID);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _FindBook();
        }

        private void _FindBook()
        {
            string filterColumn = cbFilterBy.Text.Trim();
            var filterValue = txtFilterValue.Text.Trim();

            if(string.IsNullOrEmpty(filterColumn) || string.IsNullOrEmpty(filterValue))
            {
                MessageBox.Show("Please select a filter option or a filter Value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dtBook = new DataTable();
            if (cbFilterBy.Text == "BookID")
            {
                dtBook = clsBooks.SearchData(clsBooks.BooksColumn.BookID, filterValue, clsBooks.SearchMode.ExactMatch);
            }
            else if(cbFilterBy.Text == "ISBN")
            {
                dtBook = clsBooks.SearchData(clsBooks.BooksColumn.ISBN, filterValue, clsBooks.SearchMode.ExactMatch);
            }


            if (dtBook != null && dtBook.Rows.Count > 0)
            {
                txtTilte.Text = dtBook.Rows[0]["Title"].ToString();
                txtISBN.Text = dtBook.Rows[0]["ISBN"].ToString();


                int bookID = -1;
                 bookID = Convert.ToInt32(dtBook.Rows[0]["BookID"]);

                if (OnSelectedBook != null)
                    OnSelected(bookID); //rais the event.
            }
            else
            {
                ResetDefaultValue();
                MessageBox.Show("No book found with the given filter criteria!", "Book Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void ResetDefaultValue()
        {
            txtFilterValue.Clear();
            txtFilterValue.Focus();
            txtTilte.Clear();
            txtISBN.Clear();
        }
        private void btnAddnew_Click(object sender, EventArgs e)
        {
            frmScreenOfBooks frm = new frmScreenOfBooks();
            frm.ShowDialog();
        }

        private void cbFilterBy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedIndex != -1)
            {
                txtFilterValue.Clear();
                txtFilterValue.Focus();
            }
        }
    }
}
