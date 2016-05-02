namespace Library.Forms
{
    partial class FormSaveXML
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
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.txtbxPathToXML = new System.Windows.Forms.TextBox();
            this.lblPathToXml = new System.Windows.Forms.Label();
            this.pnControlSaveXML = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.pnSaveXml = new System.Windows.Forms.Panel();
            this.SaveFileDialogXML = new System.Windows.Forms.SaveFileDialog();
            this.pnControlSaveXML.SuspendLayout();
            this.pnSaveXml.SuspendLayout();
            this.SuspendLayout();
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
            // pnControlSaveXML
            // 
            this.pnControlSaveXML.Controls.Add(this.btnCancel);
            this.pnControlSaveXML.Controls.Add(this.btnChoose);
            this.pnControlSaveXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControlSaveXML.Location = new System.Drawing.Point(0, 43);
            this.pnControlSaveXML.Name = "pnControlSaveXML";
            this.pnControlSaveXML.Size = new System.Drawing.Size(376, 36);
            this.pnControlSaveXML.TabIndex = 3;
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
            // pnSaveXml
            // 
            this.pnSaveXml.Controls.Add(this.btnChoosePath);
            this.pnSaveXml.Controls.Add(this.txtbxPathToXML);
            this.pnSaveXml.Controls.Add(this.lblPathToXml);
            this.pnSaveXml.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSaveXml.Location = new System.Drawing.Point(0, 0);
            this.pnSaveXml.Name = "pnSaveXml";
            this.pnSaveXml.Size = new System.Drawing.Size(376, 43);
            this.pnSaveXml.TabIndex = 2;
            // 
            // SaveFileDialogXML
            // 
            this.SaveFileDialogXML.Filter = "XML|*.xml";
            this.SaveFileDialogXML.Title = "Save XML";
            // 
            // FormSaveXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 79);
            this.Controls.Add(this.pnControlSaveXML);
            this.Controls.Add(this.pnSaveXml);
            this.Name = "FormSaveXML";
            this.Text = "FormSaveXML";
            this.pnControlSaveXML.ResumeLayout(false);
            this.pnSaveXml.ResumeLayout(false);
            this.pnSaveXml.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChoosePath;
        private System.Windows.Forms.TextBox txtbxPathToXML;
        private System.Windows.Forms.Label lblPathToXml;
        private System.Windows.Forms.Panel pnControlSaveXML;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Panel pnSaveXml;
        private System.Windows.Forms.SaveFileDialog SaveFileDialogXML;
    }
}