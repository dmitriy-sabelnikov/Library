using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;
using Library.Presenters;
using Library.Views;

namespace Library
{
    public partial class FormSearchBook : Form, ISearchBookView
    {
        private SearchBookPresenter searchBookPresenter;

        public string Code { get; set; }
        public string Author { get; set; }
        public string NameBook { get; set; }

        public FormSearchBook()
        {
            InitializeComponent();
        }

        public void AttachPresenter (SearchBookPresenter searchBookPresenter)
        {
            this.searchBookPresenter = searchBookPresenter;   
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Code = txtbxCodeBook.Text;
            Author = txtbxAuthor.Text;
            NameBook = txtbxName.Text;
            searchBookPresenter.SearchBook();
            this.Close();            
        }
    }
}
