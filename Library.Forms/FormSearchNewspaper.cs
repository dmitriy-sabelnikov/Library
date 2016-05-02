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
    public partial class FormSearchNewspaper : Form, ISearchNewspaperView
    {
        public string NameNewspaper { get; set; }
        public string Author { get; set; }
        public string PublishHouse { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Periodicity { get; set; }

        private SearchNewspaperPresenter searchNewspaperPresenter;

        public FormSearchNewspaper()
        {
            InitializeComponent();
        }

        public void AttachPresenter(SearchNewspaperPresenter searchNewspaperPresenter)
        {
            this.searchNewspaperPresenter = searchNewspaperPresenter;
        }
    
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            NameNewspaper = txtbxName.Text;
            Author = txtbxAuthor.Text;
            PublishHouse = txtbxPublishHouse.Text;
            ReleaseDate = dtReleaseDate.Value;
            Periodicity = nPeriodicity.Value;
            searchNewspaperPresenter.SearchNewspaper();
            this.Close();
        }
    }
}
