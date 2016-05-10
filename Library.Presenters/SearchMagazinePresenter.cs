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
        private ISearchMagazineView _searchMagazineView;

        public SearchMagazinePresenter(ISearchMagazineView searchMagazineView)
        {
            _searchMagazineView = searchMagazineView;
        }
        
        public void SearchMagazine ()
        {
            GridSource.ResultSearchMagazine= 
                SearchPublication.FindMagazine(GridSource.BookLibrary.GetAllMagazine(),
                    _searchMagazineView.NameMagazine, _searchMagazineView.PublishHouse,
                    _searchMagazineView.PublishMonth, _searchMagazineView.MagazineTheme);
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
