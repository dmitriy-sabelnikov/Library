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
        private IAddBookView m_bookView;

        public AddBookPresenter(IAddBookView p_bookView)
        {
            m_bookView = p_bookView;
        }

        public void AddBook()
        {
            GridSource.BookLibrary.AddBook(m_bookView.Code, m_bookView.NameBook, m_bookView.Author);
        }

        public void RefreshGrid(DataGridView gridLibrary)
        {
            GridSource.ClearGrid(gridLibrary);
            GridSource.FillLibraryByBooks(gridLibrary, GridSource.BookLibrary.GetAllBook());
            GridSource.FillLibraryByNewspapers(gridLibrary, GridSource.BookLibrary.GetAllNewspaper());
            GridSource.FillLibraryByMagazines(gridLibrary, GridSource.BookLibrary.GetAllMagazine());
        }
    }
}
