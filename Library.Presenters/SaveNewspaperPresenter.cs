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
        ILoadSaveXMLView p_loadSaveXML;

        public SaveNewspaperPresenter(ILoadSaveXMLView m_loadSaveXML)
        {
            p_loadSaveXML = m_loadSaveXML;
        }

        public void SaveNewspaperXML()
        {
            if (p_loadSaveXML.PathToXml != String.Empty)
            {
                XMLDataAccess.SaveToXmlNewspaper(
                    p_loadSaveXML.PathToXml, GridSource.BookLibrary.GetAllNewspaper());
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
