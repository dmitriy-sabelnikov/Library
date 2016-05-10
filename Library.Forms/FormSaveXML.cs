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

namespace Library.Forms
{
    public partial class FormSaveXML : Form, ILoadSaveXMLView
    {
        public string PathToXml { get; set; }
        private SaveBookPresenter _saveBookPresenter;
        private SaveNewspaperPresenter _saveNewspaperPresenter;
        private SaveMagazinePresenter _saveMagazinePresenter;
        private PublicationType _publicationType;

        public FormSaveXML(PublicationType publicationType)
        {
            InitializeComponent();
            _publicationType = publicationType;
            if (_publicationType == PublicationType.book)
            {
                _saveBookPresenter = new SaveBookPresenter(this);
            }
            if (_publicationType == PublicationType.newspaper)
            {
                _saveNewspaperPresenter = new SaveNewspaperPresenter(this);
            }
            if (_publicationType == PublicationType.magazine)
            {
                _saveMagazinePresenter = new SaveMagazinePresenter(this);
            }
        }

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            if (SaveFileDialogXML.ShowDialog() == DialogResult.OK)
            {
                PathToXml = txtbxPathToXML.Text = SaveFileDialogXML.FileName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PathToXml = txtbxPathToXML.Text = String.Empty;
            this.Close();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (_publicationType == PublicationType.book)
            {
                _saveBookPresenter.SaveBookXML();
            }
            if (_publicationType == PublicationType.newspaper)
            {
                _saveNewspaperPresenter.SaveNewspaperXML();
            }
            if (_publicationType == PublicationType.magazine)
            {
                _saveMagazinePresenter.SaveMagazineXML();
            }
            this.Close();
        }
    }
}
