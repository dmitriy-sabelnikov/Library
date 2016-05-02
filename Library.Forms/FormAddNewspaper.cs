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
    public partial class FormAddNewspaper : Form, IAddNewspaperView
    {
        private AddNewspaperPresenter addNewspaperPresenter;

        public string NameNewspaper { get; set; }
        public string Author { get; set; }
        public string PublishHouse { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Periodicity { get; set; }

        public FormAddNewspaper()
        {
            InitializeComponent();
        }

        public void AttachPresenter(AddNewspaperPresenter addNewspaperPresenter)
        {
            this.addNewspaperPresenter = addNewspaperPresenter;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblAuthor.ForeColor = Color.Black;
            lblNameNewspaper.ForeColor = Color.Black;
            if (txtbxAuthor.Text == String.Empty)
            {
                lblAuthor.ForeColor = Color.Red;
                return;
            }
            if (txtbxNameNewspaper.Text == String.Empty)
            {
                lblNameNewspaper.ForeColor = Color.Red;
                return;
            }

            NameNewspaper = txtbxNameNewspaper.Text;
            Author = txtbxAuthor.Text;
            PublishHouse = txtbxPublishHouse.Text;
            ReleaseDate = dtReleaseDate.Value;
            Periodicity = nPeriodicity.Value;
            addNewspaperPresenter.AddNewspaper();
            this.Close();

        }
    }
}
