namespace Library
{
    partial class FormSearchNewspaper
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
            this.nPeriodicity = new System.Windows.Forms.NumericUpDown();
            this.lblPeriodicity = new System.Windows.Forms.Label();
            this.dtReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.txtbxPublishHouse = new System.Windows.Forms.TextBox();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblPublishHouse = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.txtbxAuthor = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.pnSearchControl = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPeriodicity)).BeginInit();
            this.pnSearchControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.nPeriodicity);
            this.pnSearch.Controls.Add(this.lblPeriodicity);
            this.pnSearch.Controls.Add(this.dtReleaseDate);
            this.pnSearch.Controls.Add(this.txtbxPublishHouse);
            this.pnSearch.Controls.Add(this.lblReleaseDate);
            this.pnSearch.Controls.Add(this.lblPublishHouse);
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
            // nPeriodicity
            // 
            this.nPeriodicity.Location = new System.Drawing.Point(105, 111);
            this.nPeriodicity.Name = "nPeriodicity";
            this.nPeriodicity.Size = new System.Drawing.Size(137, 20);
            this.nPeriodicity.TabIndex = 26;
            // 
            // lblPeriodicity
            // 
            this.lblPeriodicity.AutoSize = true;
            this.lblPeriodicity.Location = new System.Drawing.Point(9, 118);
            this.lblPeriodicity.Name = "lblPeriodicity";
            this.lblPeriodicity.Size = new System.Drawing.Size(94, 13);
            this.lblPeriodicity.TabIndex = 25;
            this.lblPeriodicity.Text = "Periodicity............:";
            // 
            // dtReleaseDate
            // 
            this.dtReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReleaseDate.Location = new System.Drawing.Point(105, 85);
            this.dtReleaseDate.Name = "dtReleaseDate";
            this.dtReleaseDate.Size = new System.Drawing.Size(138, 20);
            this.dtReleaseDate.TabIndex = 24;
            this.dtReleaseDate.Value = new System.DateTime(2016, 4, 1, 0, 0, 0, 0);
            // 
            // txtbxPublishHouse
            // 
            this.txtbxPublishHouse.Location = new System.Drawing.Point(105, 59);
            this.txtbxPublishHouse.Name = "txtbxPublishHouse";
            this.txtbxPublishHouse.Size = new System.Drawing.Size(138, 20);
            this.txtbxPublishHouse.TabIndex = 23;
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.ForeColor = System.Drawing.Color.Black;
            this.lblReleaseDate.Location = new System.Drawing.Point(8, 91);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(93, 13);
            this.lblReleaseDate.TabIndex = 22;
            this.lblReleaseDate.Text = "Release Date......:";
            // 
            // lblPublishHouse
            // 
            this.lblPublishHouse.AutoSize = true;
            this.lblPublishHouse.Location = new System.Drawing.Point(8, 66);
            this.lblPublishHouse.Name = "lblPublishHouse";
            this.lblPublishHouse.Size = new System.Drawing.Size(93, 13);
            this.lblPublishHouse.TabIndex = 21;
            this.lblPublishHouse.Text = "Publish House.....:";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(105, 7);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(138, 20);
            this.txtbxName.TabIndex = 11;
            // 
            // txtbxAuthor
            // 
            this.txtbxAuthor.Location = new System.Drawing.Point(106, 33);
            this.txtbxAuthor.Name = "txtbxAuthor";
            this.txtbxAuthor.Size = new System.Drawing.Size(138, 20);
            this.txtbxAuthor.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(8, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(95, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name...................:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(9, 40);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(95, 13);
            this.lblAuthor.TabIndex = 7;
            this.lblAuthor.Text = "Author..................:";
            // 
            // pnSearchControl
            // 
            this.pnSearchControl.Controls.Add(this.btnCancel);
            this.pnSearchControl.Controls.Add(this.btnSearch);
            this.pnSearchControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSearchControl.Location = new System.Drawing.Point(0, 224);
            this.pnSearchControl.Name = "pnSearchControl";
            this.pnSearchControl.Size = new System.Drawing.Size(254, 38);
            this.pnSearchControl.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(166, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(13, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // fmSearchNewspaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 262);
            this.Controls.Add(this.pnSearchControl);
            this.Controls.Add(this.pnSearch);
            this.Name = "fmSearchNewspaper";
            this.Text = "Search newspaper";
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPeriodicity)).EndInit();
            this.pnSearchControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.Panel pnSearchControl;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.TextBox txtbxAuthor;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.NumericUpDown nPeriodicity;
        private System.Windows.Forms.Label lblPeriodicity;
        private System.Windows.Forms.DateTimePicker dtReleaseDate;
        private System.Windows.Forms.TextBox txtbxPublishHouse;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblPublishHouse;
    }
}