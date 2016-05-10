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
        private IAddNewspaperView _newspaperView;

        public AddNewspaperPresenter(IAddNewspaperView newspaperView)
        {
            _newspaperView = newspaperView;
        }

        public void AddNewspaper()
        {
            GridSource.BookLibrary.AddNewspaper(_newspaperView.NameNewspaper,
                _newspaperView.Author, _newspaperView.PublishHouse, _newspaperView.ReleaseDate, _newspaperView.Periodicity);
        }
    }
}
