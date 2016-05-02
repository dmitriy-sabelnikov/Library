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
    public partial class FormAddMagazine : Form, IAddMagazineView
    {
        private AddMagazinePresenter addMagazinePresenter;

        public string NameMagazine { get; set; }
        public string PublishHouse { get; set; }
        public string PublishMonth { get; set; }
        public string MagazineTheme { get; set; }

        public FormAddMagazine()
        {
            InitializeComponent();
        }

        public void AttachPresenter(AddMagazinePresenter addMagazinePresenter)
        {
            this.addMagazinePresenter = addMagazinePresenter;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblNameMagazine.ForeColor = Color.Black;
            if (lblNameMagazine.Text == String.Empty)
            {
                lblNameMagazine.ForeColor = Color.Red;
                return;
            }
            NameMagazine = txtbxNameMagazine.Text;
            PublishHouse = txtbxPublishHouse.Text;
            PublishMonth = cbPublishMonth.Text;
            MagazineTheme = txtbxMagazineTheme.Text;
            addMagazinePresenter.AddMagazine();
            this.Close();
        }
    }
}
