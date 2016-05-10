using Library.DataAccess;
using Library.Forms;
using Library.Presenters;
using Library.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class FormLibrary : Form, ILibrary
    {
        public DataGridView GridLibrary { get; set; }
        private LibraryPresenter _libraryPresenter;

        public FormLibrary(Library library)
        {
            InitializeComponent();
            GridSource.BookLibrary = library;
            GridLibrary = gridLibrary;
            _libraryPresenter = new LibraryPresenter(this);
        }


        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddBook formAddBook = new FormAddBook();
            formAddBook.ShowDialog();
            _libraryPresenter.RefreshGridLibrary();
        }

        private void addNewspaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddNewspaper formAddNewspaper = new FormAddNewspaper();
            formAddNewspaper.ShowDialog();
            _libraryPresenter.RefreshGridLibrary();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearchBook formSearchBook = new FormSearchBook();
            formSearchBook.ShowDialog();
            if (!_libraryPresenter.RefreshGridLibraryAfterSearchBooks() 
                && GridSource.ResultSearchBook != null && GridSource.ResultSearchBook.Count == 0 )
            {
                MessageBox.Show("I can't find book");
            }
        }

        private void searchNewspaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearchNewspaper formSearchNewspaper = new FormSearchNewspaper();
            formSearchNewspaper.ShowDialog();
            if (!_libraryPresenter.RefreshGridLibraryAfterSearchNewspapers() 
                && GridSource.ResultSearchNewspaper != null && GridSource.ResultSearchNewspaper.Count == 0)
            {
                MessageBox.Show("I can't find newspaper");
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addMagazineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddMagazine formAddMagazine = new FormAddMagazine();
            formAddMagazine.ShowDialog();
            _libraryPresenter.RefreshGridLibrary();
        }

        private void exportAllBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSaveXML formPathToXML = new FormSaveXML(PublicationType.book);
            formPathToXML.ShowDialog();
            _libraryPresenter.RefreshGridLibrary();
        }

        private void loadBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoadXML formPathToXML = new FormLoadXML(PublicationType.book);
            formPathToXML.ShowDialog();
            _libraryPresenter.RefreshGridLibrary();
        }

        private void exportAllNewspapersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSaveXML formPathToXML = new FormSaveXML(PublicationType.newspaper);
            formPathToXML.ShowDialog();
            _libraryPresenter.RefreshGridLibrary();
        }

        private void loadNewspapersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoadXML formPathToXML = new FormLoadXML(PublicationType.newspaper);
            formPathToXML.ShowDialog();
            _libraryPresenter.RefreshGridLibrary();
        }

        private void exportAllMagazinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSaveXML formPathToXML = new FormSaveXML(PublicationType.magazine);
            formPathToXML.ShowDialog();
            _libraryPresenter.RefreshGridLibrary();
        }

        private void loadMagazinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoadXML formPathToXML = new FormLoadXML(PublicationType.magazine);
            formPathToXML.ShowDialog();
            _libraryPresenter.RefreshGridLibrary();
        }

        private void searchMagazineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearchMagazine formSearchMagazine = new FormSearchMagazine();
            formSearchMagazine.ShowDialog();
            if (!_libraryPresenter.RefreshGridLibraryAfterSearchMagazines()
                && GridSource.ResultSearchMagazine != null && GridSource.ResultSearchMagazine.Count == 0)
            {
                MessageBox.Show("I can't find magazine");
            }
        }
    }
}
