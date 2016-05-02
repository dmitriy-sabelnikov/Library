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
    public partial class FormLoadXML : Form, ILoadSaveXMLView
    {
        public string PathToXml { get; set; }

        private Panel pnLoadXml;
        private Panel pnControlLoadXML;
        private Button btnChoosePath;
        private TextBox txtbxPathToXML;
        private Label lblPathToXml;
        private Button btnCancel;
        private Button btnChoose;
        private OpenFileDialog openFileDialogXML;
    
        public FormLoadXML()
        {
            InitializeComponent();
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

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            if (openFileDialogXML.ShowDialog() == DialogResult.OK)
            {
                PathToXml = txtbxPathToXML.Text = openFileDialogXML.FileName;         
            }
        }

        private void InitializeComponent()
        {
            this.openFileDialogXML = new System.Windows.Forms.OpenFileDialog();
            this.pnLoadXml = new System.Windows.Forms.Panel();
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.txtbxPathToXML = new System.Windows.Forms.TextBox();
            this.lblPathToXml = new System.Windows.Forms.Label();
            this.pnControlLoadXML = new System.Windows.Forms.Panel();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnLoadXml.SuspendLayout();
            this.pnControlLoadXML.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogXML
            // 
            this.openFileDialogXML.Filter = "XML|*.xml";
            this.openFileDialogXML.Title = "Load XML";
            // 
            // pnLoadXml
            // 
            this.pnLoadXml.Controls.Add(this.btnChoosePath);
            this.pnLoadXml.Controls.Add(this.txtbxPathToXML);
            this.pnLoadXml.Controls.Add(this.lblPathToXml);
            this.pnLoadXml.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLoadXml.Location = new System.Drawing.Point(0, 0);
            this.pnLoadXml.Name = "pnLoadXml";
            this.pnLoadXml.Size = new System.Drawing.Size(376, 43);
            this.pnLoadXml.TabIndex = 0;
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.Location = new System.Drawing.Point(340, 8);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(23, 20);
            this.btnChoosePath.TabIndex = 0;
            this.btnChoosePath.Text = "...";
            this.btnChoosePath.UseVisualStyleBackColor = true;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // txtbxPathToXML
            // 
            this.txtbxPathToXML.Location = new System.Drawing.Point(76, 8);
            this.txtbxPathToXML.Name = "txtbxPathToXML";
            this.txtbxPathToXML.Size = new System.Drawing.Size(258, 20);
            this.txtbxPathToXML.TabIndex = 1;
            // 
            // lblPathToXml
            // 
            this.lblPathToXml.AutoSize = true;
            this.lblPathToXml.Location = new System.Drawing.Point(8, 12);
            this.lblPathToXml.Name = "lblPathToXml";
            this.lblPathToXml.Size = new System.Drawing.Size(62, 13);
            this.lblPathToXml.TabIndex = 0;
            this.lblPathToXml.Text = "Path to xml:";
            // 
            // pnControlLoadXML
            // 
            this.pnControlLoadXML.Controls.Add(this.btnCancel);
            this.pnControlLoadXML.Controls.Add(this.btnChoose);
            this.pnControlLoadXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControlLoadXML.Location = new System.Drawing.Point(0, 43);
            this.pnControlLoadXML.Name = "pnControlLoadXML";
            this.pnControlLoadXML.Size = new System.Drawing.Size(376, 36);
            this.pnControlLoadXML.TabIndex = 1;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(24, 6);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 0;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(278, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormLoadXML
            // 
            this.ClientSize = new System.Drawing.Size(376, 79);
            this.Controls.Add(this.pnControlLoadXML);
            this.Controls.Add(this.pnLoadXml);
            this.Name = "FormLoadXML";
            this.Text = "Load XML";
            this.pnLoadXml.ResumeLayout(false);
            this.pnLoadXml.PerformLayout();
            this.pnControlLoadXML.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
