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
        private IAddMagazineView m_magazineView; 

        public AddMagazinePresenter(IAddMagazineView p_magazineView)
        {
            m_magazineView = p_magazineView;
        }

        public void AddMagazine ()
        {
            GridSource.BookLibrary.AddMagazine(
                m_magazineView.NameMagazine, m_magazineView.PublishHouse, m_magazineView.PublishMonth, m_magazineView.MagazineTheme);
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
