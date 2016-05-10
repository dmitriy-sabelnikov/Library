using Library.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Presenters
{
    public class LibraryPresenter
    {
        private ILibrary _library { get; set; }
        
        public LibraryPresenter (ILibrary library)
        {
            _library = library;
        }

        public void RefreshGridLibrary ()
        {
            GridSource.ClearGrid(_library.GridLibrary);
            GridSource.FillLibraryByBooks(_library.GridLibrary, GridSource.BookLibrary.GetAllBook());
            GridSource.FillLibraryByNewspapers(_library.GridLibrary, GridSource.BookLibrary.GetAllNewspaper());
            GridSource.FillLibraryByMagazines(_library.GridLibrary, GridSource.BookLibrary.GetAllMagazine());
        }

        public bool RefreshGridLibraryAfterSearchBooks()
        {
            if (GridSource.ResultSearchBook != null && GridSource.ResultSearchBook.Count > 0)
            {
                GridSource.ClearGrid(_library.GridLibrary);
                GridSource.FillLibraryByBooks(_library.GridLibrary, GridSource.ResultSearchBook);
                return true;
            }
            return false;
        }

        public bool RefreshGridLibraryAfterSearchNewspapers()
        {
            if (GridSource.ResultSearchNewspaper != null && GridSource.ResultSearchNewspaper.Count > 0)
            {
                GridSource.ClearGrid(_library.GridLibrary);
                GridSource.FillLibraryByNewspapers(_library.GridLibrary, GridSource.ResultSearchNewspaper);
                return true;
            }
            return false;
        }

        public bool RefreshGridLibraryAfterSearchMagazines()
        {
            if (GridSource.ResultSearchMagazine != null && GridSource.ResultSearchMagazine.Count > 0)
            {
                GridSource.ClearGrid(_library.GridLibrary);
                GridSource.FillLibraryByMagazines(_library.GridLibrary, GridSource.ResultSearchMagazine);
                return true;
            }
            return false;
        }
    }
}
