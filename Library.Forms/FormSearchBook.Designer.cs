namespace Library
{
    partial class FormSearchBook
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
            this.pnSearch = new System.Windows.Forms.Panel();
            this.pnControlSearch = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtbxCodeBook = new System.Windows.Forms.TextBox();
            this.lblCodeBook = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.txtbxAuthor = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.pnSearch.SuspendLayout();
            this.pnControlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.txtbxCodeBook);
            this.pnSearch.Controls.Add(this.lblCodeBook);
            this.pnSearch.Controls.Add(this.txtbxName);
            this.pnSearch.Controls.Add(this.txtbxAuthor);
            this.pnSearch.Controls.Add(this.lblName);
            this.pnSearch.Controls.Add(this.lblAuthor);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearch.Location = new System.Drawing.Point(0, 0);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(254, 224);
            this.pnSearch.TabIndex = 0;
            // 
            // pnControlSearch
            // 
            this.pnControlSearch.Controls.Add(this.btnCancel);
            this.pnControlSearch.Controls.Add(this.btnSearch);
            this.pnControlSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControlSearch.Location = new System.Drawing.Point(0, 224);
            this.pnControlSearch.Name = "pnControlSearch";
            this.pnControlSearch.Size = new System.Drawing.Size(254, 38);
            this.pnControlSearch.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(166, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(13, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtbxCodeBook
            // 
            this.txtbxCodeBook.Location = new System.Drawing.Point(105, 6);
            this.txtbxCodeBook.Name = "txtbxCodeBook";
            this.txtbxCodeBook.Size = new System.Drawing.Size(138, 20);
            this.txtbxCodeBook.TabIndex = 29;
            // 
            // lblCodeBook
            // 
            this.lblCodeBook.AutoSize = true;
            this.lblCodeBook.Location = new System.Drawing.Point(6, 13);
            this.lblCodeBook.Name = "lblCodeBook";
            this.lblCodeBook.Size = new System.Drawing.Size(95, 13);
            this.lblCodeBook.TabIndex = 28;
            this.lblCodeBook.Text = "Code book...........:";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(104, 32);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(138, 20);
            this.txtbxName.TabIndex = 27;
            // 
            // txtbxAuthor
            // 
            this.txtbxAuthor.Location = new System.Drawing.Point(105, 58);
            this.txtbxAuthor.Name = "txtbxAuthor";
            this.txtbxAuthor.Size = new System.Drawing.Size(138, 20);
            this.txtbxAuthor.TabIndex = 26;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(7, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(95, 13);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Name...................:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(8, 65);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(95, 13);
            this.lblAuthor.TabIndex = 24;
            this.lblAuthor.Text = "Author..................:";
            // 
            // fmSearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 262);
            this.Controls.Add(this.pnControlSearch);
            this.Controls.Add(this.pnSearch);
            this.Name = "fmSearchBook";
            this.Text = "fmSearchBook";
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.pnControlSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.Panel pnControlSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtbxCodeBook;
        private System.Windows.Forms.Label lblCodeBook;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.TextBox txtbxAuthor;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAuthor;
    }
}