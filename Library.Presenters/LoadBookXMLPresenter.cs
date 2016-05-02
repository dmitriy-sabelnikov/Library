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
        ILoadSaveXMLView p_loadSaveXML;
        
        public LoadBookXMLPresenter (ILoadSaveXMLView m_loadSaveXML)
        {
            p_loadSaveXML = m_loadSaveXML;
        }

        public void LoadBookXML ()
        {
            if (p_loadSaveXML.PathToXml != String.Empty)
            {
                GridSource.BookLibrary.UnionListBooks(
                    XMLDataAccess.LoadFromXmlBooks(p_loadSaveXML.PathToXml));
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
