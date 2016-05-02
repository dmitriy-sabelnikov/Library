using Library.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Presenters
{
    public class SearchNewspaperPresenter
    {
        private ISearchNewspaperView m_searchNewspaperView;

        public SearchNewspaperPresenter(ISearchNewspaperView p_searchNewspaperView)
        {
            m_searchNewspaperView = p_searchNewspaperView;
        }

        public void SearchNewspaper()
        {
            GridSource.ResultSearchNewspaper =
                SearchPublication.FindNewspaper(GridSource.BookLibrary.GetAllNewspaper(),
                    m_searchNewspaperView.NameNewspaper, m_searchNewspaperView.Author,
                    m_searchNewspaperView.PublishHouse, m_searchNewspaperView.ReleaseDate,
                    m_searchNewspaperView.Periodicity);
        }

        public void RefreshGrid(DataGridView gridLibrary)
        {
            if (GridSource.ResultSearchNewspaper == null)
            {
                return;
            }
            if (GridSource.ResultSearchNewspaper.Count > 0)
            {
                GridSource.ClearGrid(gridLibrary);
                GridSource.FillLibraryByNewspapers(gridLibrary, GridSource.ResultSearchNewspaper);
            }
            else
            {
                MessageBox.Show("I can't find newspaper");
            }
        }

    }
}
