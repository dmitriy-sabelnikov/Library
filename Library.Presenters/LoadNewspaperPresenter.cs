using Library.DataAccess;
using Library.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Presenters
{
    public class LoadNewspaperPresenter
    {
        ILoadSaveXMLView _loadSaveXML;

        public LoadNewspaperPresenter(ILoadSaveXMLView loadSaveXML)
        {
            _loadSaveXML = loadSaveXML;
        }

        public void LoadNewspaperXML ()
        {
            if (_loadSaveXML.PathToXml != String.Empty)
            {
                GridSource.BookLibrary.UnionListNewspapers(
                    XMLDataAccess.LoadFromXmlNewspapers(_loadSaveXML.PathToXml));
            }
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
