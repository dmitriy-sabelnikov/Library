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
    public class SaveBookPresenter
    {
        ILoadSaveXMLView p_loadSaveXML;

        public SaveBookPresenter (ILoadSaveXMLView m_loadSaveXML)
        {
            p_loadSaveXML = m_loadSaveXML;
        }

        public void SaveBookXML ()
        {
            if (p_loadSaveXML.PathToXml != String.Empty)
            {
                XMLDataAccess.SaveToXmlBooks(
                    p_loadSaveXML.PathToXml, GridSource.BookLibrary.GetAllBook());
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
