using Library.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Presenters
{
    public class AddMagazinePresenter
    {
        private IAddMagazineView _magazineView; 

        public AddMagazinePresenter(IAddMagazineView magazineView)
        {
            _magazineView = magazineView;
        }

        public void AddMagazine ()
        {
            GridSource.BookLibrary.AddMagazine(
                _magazineView.NameMagazine, _magazineView.PublishHouse, _magazineView.PublishMonth, _magazineView.MagazineTheme);
        }
    }
}
