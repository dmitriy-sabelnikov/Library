using Library.DataAccess;
using Library.Forms;
using Library.Presenters;
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
    public partial class FormLibrary : Form
    {
        public FormLibrary(Library library)
        {
            InitializeComponent();
            GridSource.BookLibrary = library;
        }


        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddBook formAddBook = new FormAddBook();
            AddBookPresenter addBookPresenter = new AddBookPresenter(formAddBook);
            formAddBook.AttachPresenter(addBookPresenter);
            formAddBook.ShowDialog();
            addBookPresenter.RefreshGrid(gridLibrary);
        }

        private void addNewspaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddNewspaper formAddNewspaper = new FormAddNewspaper();
            AddNewspaperPresenter addNewspaperPresenter = new AddNewspaperPresenter(formAddNewspaper);
            formAddNewspaper.AttachPresenter(addNewspaperPresenter);
            formAddNewspaper.ShowDialog();
            addNewspaperPresenter.RefreshGrid(gridLibrary);
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearchBook formSearchBook = new FormSearchBook();
            SearchBookPresenter searchBookPresenter = new SearchBookPresenter(formSearchBook);
            formSearchBook.AttachPresenter(searchBookPresenter);
            formSearchBook.ShowDialog();
        }

        private void searchNewspaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearchNewspaper formSearchNewspaper = new FormSearchNewspaper();
            SearchNewspaperPresenter searchNewspaperPresenter = new SearchNewspaperPresenter(formSearchNewspaper);
            formSearchNewspaper.AttachPresenter(searchNewspaperPresenter);
            formSearchNewspaper.ShowDialog();
            searchNewspaperPresenter.RefreshGrid(gridLibrary);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addMagazineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddMagazine formAddMagazine = new FormAddMagazine();
            AddMagazinePresenter addMagazinePresenter = new AddMagazinePresenter(formAddMagazine);
            formAddMagazine.AttachPresenter(addMagazinePresenter);
            formAddMagazine.ShowDialog();
            addMagazinePresenter.RefreshGrid(gridLibrary);
        }

        private void exportAllBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSaveXML formPathToXML = new FormSaveXML();
            SaveBookPresenter saveBookPresenter = new SaveBookPresenter(formPathToXML);
            formPathToXML.ShowDialog();
            saveBookPresenter.SaveBookXML();
            saveBookPresenter.RefreshGrid(gridLibrary);
        }

        private void loadBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoadXML formPathToXML = new FormLoadXML();
            LoadBookXMLPresenter loadBookXML = new LoadBookXMLPresenter(formPathToXML);
            formPathToXML.ShowDialog();
            loadBookXML.LoadBookXML();
            loadBookXML.RefreshGrid(gridLibrary);
        }

        private void exportAllNewspapersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSaveXML formPathToXML = new FormSaveXML();
            SaveNewspaperPresenter saveNewspaperPresenter = new SaveNewspaperPresenter(formPathToXML);
            formPathToXML.ShowDialog();
            saveNewspaperPresenter.SaveNewspaperXML();
            saveNewspaperPresenter.RefreshGrid(gridLibrary);
        }

        private void loadNewspapersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoadXML formPathToXML = new FormLoadXML();
            LoadNewspaperPresenter loadNewspaperXML = new LoadNewspaperPresenter(formPathToXML);
            formPathToXML.ShowDialog();
            loadNewspaperXML.LoadNewspaperXML();
            loadNewspaperXML.RefreshGrid(gridLibrary);
        }

        private void exportAllMagazinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSaveXML formPathToXML = new FormSaveXML();
            SaveNewspaperPresenter saveNewspaperPresenter = new SaveNewspaperPresenter(formPathToXML);
            formPathToXML.ShowDialog();
            saveNewspaperPresenter.SaveNewspaperXML();
            saveNewspaperPresenter.RefreshGrid(gridLibrary);
        }

        private void loadMagazinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoadXML formPathToXML = new FormLoadXML();
            LoadMagazineXMLPresenter loadMagazineXML = new LoadMagazineXMLPresenter(formPathToXML);
            formPathToXML.ShowDialog();
            loadMagazineXML.LoadMagazineXML();
            loadMagazineXML.RefreshGrid(gridLibrary);
        }

        private void searchMagazineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearchMagazine formSearchMagazine = new FormSearchMagazine();
            SearchMagazinePresenter searchMagazinePresenter = new SearchMagazinePresenter(formSearchMagazine);
            formSearchMagazine.AttachPresenter(searchMagazinePresenter);
            formSearchMagazine.ShowDialog();
            searchMagazinePresenter.RefreshGrid(gridLibrary);
        }
    }
}
