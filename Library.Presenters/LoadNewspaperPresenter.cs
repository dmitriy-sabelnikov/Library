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
        ILoadSaveXMLView p_loadSaveXML;

        public LoadNewspaperPresenter(ILoadSaveXMLView m_loadSaveXML)
        {
            p_loadSaveXML = m_loadSaveXML;
        }

        public void LoadNewspaperXML ()
        {
            if (p_loadSaveXML.PathToXml != String.Empty)
            {
                GridSource.BookLibrary.UnionListNewspapers(
                    XMLDataAccess.LoadFromXmlNewspapers(p_loadSaveXML.PathToXml));
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
