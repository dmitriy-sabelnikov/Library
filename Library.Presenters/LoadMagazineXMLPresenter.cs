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
    public class LoadMagazineXMLPresenter
    {
        ILoadSaveXMLView _loadSaveXML;

        public LoadMagazineXMLPresenter(ILoadSaveXMLView loadSaveXML)
        {
            _loadSaveXML = loadSaveXML;
        }

        public void LoadMagazineXML ()
        {
            if (_loadSaveXML.PathToXml != String.Empty)
            {
                GridSource.BookLibrary.UnionListMagazines(
                    XMLDataAccess.LoadFromXmlMagazines(_loadSaveXML.PathToXml));
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
