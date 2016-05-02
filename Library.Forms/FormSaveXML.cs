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
        public FormSaveXML()
        {
            InitializeComponent();
        }

        public string PathToXml { get; set; }

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
            this.Close();
        }
    }
}
