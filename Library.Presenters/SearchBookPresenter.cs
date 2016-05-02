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
        private ISearchBookView m_searchBookView;
        
        public SearchBookPresenter(ISearchBookView p_searchBookView)
        {
            m_searchBookView = p_searchBookView;
        }

        public void SearchBook ()
        {
            GridSource.ResultSearchBook = 
                SearchPublication.FindBook(GridSource.BookLibrary.GetAllBook(),
                    m_searchBookView.Code, m_searchBookView.NameBook, m_searchBookView.Author);
        }

        public void RefreshGrid(DataGridView gridLibrary)
        {
            if (GridSource.ResultSearchBook == null)
            {
                return;
            }
            if (GridSource.ResultSearchBook.Count > 0)
            {
                GridSource.ClearGrid(gridLibrary);
                GridSource.FillLibraryByBooks(gridLibrary, GridSource.ResultSearchBook);
            }
            else
            {
                MessageBox.Show("I can't find book");
            }
        }
    }


}
