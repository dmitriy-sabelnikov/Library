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
    public class LoadBookXMLPresenter
    {
        ILoadSaveXMLView _loadSaveXML;
        
        public LoadBookXMLPresenter (ILoadSaveXMLView loadSaveXML)
        {
            _loadSaveXML = loadSaveXML;
        }

        public void LoadBookXML ()
        {
            if (_loadSaveXML.PathToXml != String.Empty)
            {
                GridSource.BookLibrary.UnionListBooks(
                    XMLDataAccess.LoadFromXmlBooks(_loadSaveXML.PathToXml));
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
