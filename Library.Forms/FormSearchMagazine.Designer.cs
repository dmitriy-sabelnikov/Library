namespace Library.Forms
{
    partial class FormSearchMagazine
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
            this.pnSearchMagazine = new System.Windows.Forms.Panel();
            this.pnControlSearchMagazine = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbPublishMonth = new System.Windows.Forms.ComboBox();
            this.txtbxMagazineTheme = new System.Windows.Forms.TextBox();
            this.lblMagazineTheme = new System.Windows.Forms.Label();
            this.lblPublishMonth = new System.Windows.Forms.Label();
            this.txtbxPublishHouse = new System.Windows.Forms.TextBox();
            this.lblPublishHouse = new System.Windows.Forms.Label();
            this.txtbxNameMagazine = new System.Windows.Forms.TextBox();
            this.lblNameMagazine = new System.Windows.Forms.Label();
            this.pnSearchMagazine.SuspendLayout();
            this.pnControlSearchMagazine.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSearchMagazine
            // 
            this.pnSearchMagazine.Controls.Add(this.cbPublishMonth);
            this.pnSearchMagazine.Controls.Add(this.txtbxMagazineTheme);
            this.pnSearchMagazine.Controls.Add(this.lblMagazineTheme);
            this.pnSearchMagazine.Controls.Add(this.lblPublishMonth);
            this.pnSearchMagazine.Controls.Add(this.txtbxPublishHouse);
            this.pnSearchMagazine.Controls.Add(this.lblPublishHouse);
            this.pnSearchMagazine.Controls.Add(this.txtbxNameMagazine);
            this.pnSearchMagazine.Controls.Add(this.lblNameMagazine);
            this.pnSearchMagazine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearchMagazine.Location = new System.Drawing.Point(0, 0);
            this.pnSearchMagazine.Name = "pnSearchMagazine";
            this.pnSearchMagazine.Size = new System.Drawing.Size(254, 223);
            this.pnSearchMagazine.TabIndex = 0;
            // 
            // pnControlSearchMagazine
            // 
            this.pnControlSearchMagazine.Controls.Add(this.btnCancel);
            this.pnControlSearchMagazine.Controls.Add(this.btnSearch);
            this.pnControlSearchMagazine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControlSearchMagazine.Location = new System.Drawing.Point(0, 223);
            this.pnControlSearchMagazine.Name = "pnControlSearchMagazine";
            this.pnControlSearchMagazine.Size = new System.Drawing.Size(254, 39);
            this.pnControlSearchMagazine.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(166, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(13, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbPublishMonth
            // 
            this.cbPublishMonth.FormattingEnabled = true;
            this.cbPublishMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbPublishMonth.Location = new System.Drawing.Point(105, 61);
            this.cbPublishMonth.Name = "cbPublishMonth";
            this.cbPublishMonth.Size = new System.Drawing.Size(137, 21);
            this.cbPublishMonth.TabIndex = 27;
            // 
            // txtbxMagazineTheme
            // 
            this.txtbxMagazineTheme.Location = new System.Drawing.Point(104, 87);
            this.txtbxMagazineTheme.Name = "txtbxMagazineTheme";
            this.txtbxMagazineTheme.Size = new System.Drawing.Size(137, 20);
            this.txtbxMagazineTheme.TabIndex = 26;
            // 
            // lblMagazineTheme
            // 
            this.lblMagazineTheme.AutoSize = true;
            this.lblMagazineTheme.Location = new System.Drawing.Point(5, 94);
            this.lblMagazineTheme.Name = "lblMagazineTheme";
            this.lblMagazineTheme.Size = new System.Drawing.Size(101, 13);
            this.lblMagazineTheme.TabIndex = 25;
            this.lblMagazineTheme.Text = "MagazineTheme....:";
            // 
            // lblPublishMonth
            // 
            this.lblPublishMonth.AutoSize = true;
            this.lblPublishMonth.ForeColor = System.Drawing.Color.Black;
            this.lblPublishMonth.Location = new System.Drawing.Point(6, 68);
            this.lblPublishMonth.Name = "lblPublishMonth";
            this.lblPublishMonth.Size = new System.Drawing.Size(100, 13);
            this.lblPublishMonth.TabIndex = 24;
            this.lblPublishMonth.Text = "Publish month........:";
            // 
            // txtbxPublishHouse
            // 
            this.txtbxPublishHouse.Location = new System.Drawing.Point(105, 35);
            this.txtbxPublishHouse.Name = "txtbxPublishHouse";
            this.txtbxPublishHouse.Size = new System.Drawing.Size(137, 20);
            this.txtbxPublishHouse.TabIndex = 23;
            // 
            // lblPublishHouse
            // 
            this.lblPublishHouse.AutoSize = true;
            this.lblPublishHouse.Location = new System.Drawing.Point(6, 42);
            this.lblPublishHouse.Name = "lblPublishHouse";
            this.lblPublishHouse.Size = new System.Drawing.Size(99, 13);
            this.lblPublishHouse.TabIndex = 22;
            this.lblPublishHouse.Text = "Publish House.......:";
            // 
            // txtbxNameMagazine
            // 
            this.txtbxNameMagazine.Location = new System.Drawing.Point(105, 10);
            this.txtbxNameMagazine.Name = "txtbxNameMagazine";
            this.txtbxNameMagazine.Size = new System.Drawing.Size(137, 20);
            this.txtbxNameMagazine.TabIndex = 21;
            // 
            // lblNameMagazine
            // 
            this.lblNameMagazine.AutoSize = true;
            this.lblNameMagazine.ForeColor = System.Drawing.Color.Black;
            this.lblNameMagazine.Location = new System.Drawing.Point(6, 17);
            this.lblNameMagazine.Name = "lblNameMagazine";
            this.lblNameMagazine.Size = new System.Drawing.Size(98, 13);
            this.lblNameMagazine.TabIndex = 20;
            this.lblNameMagazine.Text = "Magazine\'s name..:";
            // 
            // FormSearchMagazine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 262);
            this.Controls.Add(this.pnControlSearchMagazine);
            this.Controls.Add(this.pnSearchMagazine);
            this.Name = "FormSearchMagazine";
            this.Text = "Search Magazine";
            this.pnSearchMagazine.ResumeLayout(false);
            this.pnSearchMagazine.PerformLayout();
            this.pnControlSearchMagazine.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSearchMagazine;
        private System.Windows.Forms.Panel pnControlSearchMagazine;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbPublishMonth;
        private System.Windows.Forms.TextBox txtbxMagazineTheme;
        private System.Windows.Forms.Label lblMagazineTheme;
        private System.Windows.Forms.Label lblPublishMonth;
        private System.Windows.Forms.TextBox txtbxPublishHouse;
        private System.Windows.Forms.Label lblPublishHouse;
        private System.Windows.Forms.TextBox txtbxNameMagazine;
        private System.Windows.Forms.Label lblNameMagazine;
    }
}