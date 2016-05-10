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
    public partial class FormSearchMagazine : Form, ISearchMagazineView
    {
        public string NameMagazine { get; set; }
        public string PublishHouse { get; set; }
        public string PublishMonth { get; set; }
        public string MagazineTheme { get; set; }

        private SearchMagazinePresenter _searchMagazinePresenter;

        public FormSearchMagazine()
        {
            InitializeComponent();
            _searchMagazinePresenter = new SearchMagazinePresenter(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GridSource.ResultSearchMagazine =
                SearchPublication.FindMagazine(GridSource.BookLibrary.GetAllMagazine(), 
                txtbxNameMagazine.Text, txtbxPublishHouse.Text, cbPublishMonth.Text, txtbxMagazineTheme.Text);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
