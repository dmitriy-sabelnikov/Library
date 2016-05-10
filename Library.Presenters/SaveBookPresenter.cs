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
        ILoadSaveXMLView _loadSaveXML;

        public SaveBookPresenter (ILoadSaveXMLView loadSaveXML)
        {
            _loadSaveXML = loadSaveXML;
        }

        public void SaveBookXML ()
        {
            if (_loadSaveXML.PathToXml != String.Empty)
            {
                XMLDataAccess.SaveToXmlBooks(
                    _loadSaveXML.PathToXml, GridSource.BookLibrary.GetAllBook());
            }
        }
    }
}
