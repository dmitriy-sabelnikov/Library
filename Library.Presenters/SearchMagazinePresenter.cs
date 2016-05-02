using Library.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Presenters
{
    public class SearchMagazinePresenter
    {
        private ISearchMagazineView m_searchMagazineView;

        public SearchMagazinePresenter(ISearchMagazineView p_searchMagazineView)
        {
            m_searchMagazineView = p_searchMagazineView;
        }
        
        public void SearchMagazine ()
        {
            GridSource.ResultSearchMagazine= 
                SearchPublication.FindMagazine(GridSource.BookLibrary.GetAllMagazine(),
                    m_searchMagazineView.NameMagazine, m_searchMagazineView.PublishHouse,
                    m_searchMagazineView.PublishMonth, m_searchMagazineView.MagazineTheme);
        }

        public void RefreshGrid(DataGridView gridLibrary)
        {
            if (GridSource.ResultSearchMagazine == null)
            {
                return;
            }
            if (GridSource.ResultSearchMagazine.Count > 0)
            {
                GridSource.ClearGrid(gridLibrary);
                GridSource.FillLibraryByMagazines(gridLibrary, GridSource.ResultSearchMagazine);
            }
            else
            {
                MessageBox.Show("I can't find magazine");
            }
        }
    }
}
