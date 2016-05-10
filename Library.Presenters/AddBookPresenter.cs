using Library.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Presenters
{
    public class AddBookPresenter
    {
        private IAddBookView _bookView;

        public AddBookPresenter(IAddBookView bookView)
        {
            _bookView = bookView;
        }

        public void AddBook()
        {
            GridSource.BookLibrary.AddBook(_bookView.Code, _bookView.NameBook, _bookView.Author);
        }
    }
}
