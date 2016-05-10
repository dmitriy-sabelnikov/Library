using Library.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Presenters
{
    public class SearchBookPresenter
    {
        private ISearchBookView _searchBookView;
        
        public SearchBookPresenter(ISearchBookView searchBookView)
        {
            _searchBookView = searchBookView;
        }

        public void SearchBook ()
        {
            GridSource.ResultSearchBook = 
                SearchPublication.FindBook(GridSource.BookLibrary.GetAllBook(),
                    _searchBookView.Code, _searchBookView.NameBook, _searchBookView.Author);
        }
    }
}
