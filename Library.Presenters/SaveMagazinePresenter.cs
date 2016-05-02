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
        ILoadSaveXMLView p_loadSaveXML;

        public SaveMagazinePresenter(ILoadSaveXMLView m_loadSaveXML)
        {
            p_loadSaveXML = m_loadSaveXML;
        }

        public void SaveMagazineXML()
        {
            if (p_loadSaveXML.PathToXml != String.Empty)
            {
                XMLDataAccess.SaveToXmlMagazines(
                    p_loadSaveXML.PathToXml, GridSource.BookLibrary.GetAllMagazine());
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
