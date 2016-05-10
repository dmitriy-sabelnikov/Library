using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Views;
using Library.Presenters;

namespace Library
{
    public partial class FormAddBook : Form, IAddBookView
    {
        private AddBookPresenter _addBookPresenter;

        public string Code { get; set; }
        public string Author { get; set; }
        public string NameBook { get; set; }

        public FormAddBook()
        {    
            InitializeComponent();
            _addBookPresenter = new AddBookPresenter(this);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblCode.ForeColor = Color.Black;
            lblAuthor.ForeColor = Color.Black;
            lblNameBook.ForeColor = Color.Black;
            if (txtbxCode.Text == String.Empty)
            {
                lblCode.ForeColor = Color.Red;
                return;
            }
            if (txtbxAuthor.Text == String.Empty)
            {
                lblAuthor.ForeColor = Color.Red;
                return;
            }
            if (txtbxNameBook.Text == String.Empty)
            {
                lblNameBook.ForeColor = Color.Red;
                return;
            }
            Code = txtbxCode.Text;
            Author = txtbxAuthor.Text;
            NameBook = txtbxNameBook.Text;
            _addBookPresenter.AddBook();
            this.Close();
        }
    }
}
