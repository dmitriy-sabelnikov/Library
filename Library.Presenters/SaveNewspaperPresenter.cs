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
    public class SaveNewspaperPresenter
    {
        ILoadSaveXMLView _loadSaveXML;

        public SaveNewspaperPresenter(ILoadSaveXMLView loadSaveXML)
        {
            _loadSaveXML = loadSaveXML;
        }

        public void SaveNewspaperXML()
        {
            if (_loadSaveXML.PathToXml != String.Empty)
            {
                XMLDataAccess.SaveToXmlNewspaper(
                    _loadSaveXML.PathToXml, GridSource.BookLibrary.GetAllNewspaper());
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
