namespace Library.Forms
{
    partial class FormLoadXML
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialogXML = new System.Windows.Forms.OpenFileDialog();
            this.pnLoadXml = new System.Windows.Forms.Panel();
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.txtbxPathToXML = new System.Windows.Forms.TextBox();
            this.lblPathToXML = new System.Windows.Forms.Label();
            this.pnControlLoadXML = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.pnLoadXml.SuspendLayout();
            this.pnControlLoadXML.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogXML
            // 
            this.openFileDialogXML.Filter = "XML files|*.xml";
            this.openFileDialogXML.InitialDirectory = "C:\\";
            // 
            // pnLoadXml
            // 
            this.pnLoadXml.Controls.Add(this.btnChoosePath);
            this.pnLoadXml.Controls.Add(this.txtbxPathToXML);
            this.pnLoadXml.Controls.Add(this.lblPathToXML);
            this.pnLoadXml.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLoadXml.Location = new System.Drawing.Point(0, 0);
            this.pnLoadXml.Name = "pnLoadXml";
            this.pnLoadXml.Size = new System.Drawing.Size(356, 41);
            this.pnLoadXml.TabIndex = 0;
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.Location = new System.Drawing.Point(321, 8);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(20, 20);
            this.btnChoosePath.TabIndex = 2;
            this.btnChoosePath.Text = "...";
            this.btnChoosePath.UseVisualStyleBackColor = true;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // txtbxPathToXML
            // 
            this.txtbxPathToXML.Location = new System.Drawing.Point(91, 8);
            this.txtbxPathToXML.Name = "txtbxPathToXML";
            this.txtbxPathToXML.Size = new System.Drawing.Size(228, 20);
            this.txtbxPathToXML.TabIndex = 1;
            // 
            // lblPathToXML
            // 
            this.lblPathToXML.AutoSize = true;
            this.lblPathToXML.Location = new System.Drawing.Point(10, 12);
            this.lblPathToXML.Name = "lblPathToXML";
            this.lblPathToXML.Size = new System.Drawing.Size(77, 13);
            this.lblPathToXML.TabIndex = 0;
            this.lblPathToXML.Text = "Путь к файлу:";
            // 
            // pnControlLoadXML
            // 
            this.pnControlLoadXML.Controls.Add(this.btnCancel);
            this.pnControlLoadXML.Controls.Add(this.btnChoose);
            this.pnControlLoadXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControlLoadXML.Location = new System.Drawing.Point(0, 41);
            this.pnControlLoadXML.Name = "pnControlLoadXML";
            this.pnControlLoadXML.Size = new System.Drawing.Size(356, 35);
            this.pnControlLoadXML.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(266, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(13, 6);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 4;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // FormLoadXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 76);
            this.Controls.Add(this.pnControlLoadXML);
            this.Controls.Add(this.pnLoadXml);
            this.Name = "FormLoadXML";
            this.Text = "FormPathToXML";
            this.pnLoadXml.ResumeLayout(false);
            this.pnLoadXml.PerformLayout();
            this.pnControlLoadXML.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogXML;
        private System.Windows.Forms.Panel pnLoadXml;
        private System.Windows.Forms.Panel pnControlLoadXML;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnChoosePath;
        private System.Windows.Forms.TextBox txtbxPathToXML;
        private System.Windows.Forms.Label lblPathToXML;
    }
}