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
    public class SaveMagazinePresenter
    {
        ILoadSaveXMLView _loadSaveXML;

        public SaveMagazinePresenter(ILoadSaveXMLView loadSaveXML)
        {
            _loadSaveXML = loadSaveXML;
        }

        public void SaveMagazineXML()
        {
            if (_loadSaveXML.PathToXml != String.Empty)
            {
                XMLDataAccess.SaveToXmlMagazines(
                    _loadSaveXML.PathToXml, GridSource.BookLibrary.GetAllMagazine());
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
