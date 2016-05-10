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
        private ISearchNewspaperView _searchNewspaperView;

        public SearchNewspaperPresenter(ISearchNewspaperView searchNewspaperView)
        {
            _searchNewspaperView = searchNewspaperView;
        }

        public void SearchNewspaper()
        {
            GridSource.ResultSearchNewspaper =
                SearchPublication.FindNewspaper(GridSource.BookLibrary.GetAllNewspaper(),
                    _searchNewspaperView.NameNewspaper, _searchNewspaperView.Author,
                    _searchNewspaperView.PublishHouse, _searchNewspaperView.ReleaseDate,
                    _searchNewspaperView.Periodicity);
        }
    }
}
