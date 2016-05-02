using Library.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Presenters
{
    public class AddNewspaperPresenter
    {
        private IAddNewspaperView m_newspaperView;

        public AddNewspaperPresenter(IAddNewspaperView p_newspaperView)
        {
            m_newspaperView = p_newspaperView;
        }

        public void AddNewspaper()
        {
            GridSource.BookLibrary.AddNewspaper(m_newspaperView.NameNewspaper,
                m_newspaperView.Author, m_newspaperView.PublishHouse, m_newspaperView.ReleaseDate, m_newspaperView.Periodicity);
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
