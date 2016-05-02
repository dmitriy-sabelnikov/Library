namespace Library
{
    partial class FormAddNewspaper
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
            this.pnNewspaper = new System.Windows.Forms.Panel();
            this.nPeriodicity = new System.Windows.Forms.NumericUpDown();
            this.lblPeriodicity = new System.Windows.Forms.Label();
            this.dtReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.txtbxPublishHouse = new System.Windows.Forms.TextBox();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblPublishHouse = new System.Windows.Forms.Label();
            this.txtbxNameNewspaper = new System.Windows.Forms.TextBox();
            this.txtbxAuthor = new System.Windows.Forms.TextBox();
            this.lblNameNewspaper = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.pnControlNewspaper = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnNewspaper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPeriodicity)).BeginInit();
            this.pnControlNewspaper.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnNewspaper
            // 
            this.pnNewspaper.Controls.Add(this.nPeriodicity);
            this.pnNewspaper.Controls.Add(this.lblPeriodicity);
            this.pnNewspaper.Controls.Add(this.dtReleaseDate);
            this.pnNewspaper.Controls.Add(this.txtbxPublishHouse);
            this.pnNewspaper.Controls.Add(this.lblReleaseDate);
            this.pnNewspaper.Controls.Add(this.lblPublishHouse);
            this.pnNewspaper.Controls.Add(this.txtbxNameNewspaper);
            this.pnNewspaper.Controls.Add(this.txtbxAuthor);
            this.pnNewspaper.Controls.Add(this.lblNameNewspaper);
            this.pnNewspaper.Controls.Add(this.lblAuthor);
            this.pnNewspaper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNewspaper.Location = new System.Drawing.Point(0, 0);
            this.pnNewspaper.Name = "pnNewspaper";
            this.pnNewspaper.Size = new System.Drawing.Size(254, 224);
            this.pnNewspaper.TabIndex = 0;
            // 
            // nPeriodicity
            // 
            this.nPeriodicity.Location = new System.Drawing.Point(108, 113);
            this.nPeriodicity.Name = "nPeriodicity";
            this.nPeriodicity.Size = new System.Drawing.Size(137, 20);
            this.nPeriodicity.TabIndex = 16;
            // 
            // lblPeriodicity
            // 
            this.lblPeriodicity.AutoSize = true;
            this.lblPeriodicity.Location = new System.Drawing.Point(9, 120);
            this.lblPeriodicity.Name = "lblPeriodicity";
            this.lblPeriodicity.Size = new System.Drawing.Size(100, 13);
            this.lblPeriodicity.TabIndex = 15;
            this.lblPeriodicity.Text = "Periodicity..............:";
            // 
            // dtReleaseDate
            // 
            this.dtReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReleaseDate.Location = new System.Drawing.Point(108, 87);
            this.dtReleaseDate.Name = "dtReleaseDate";
            this.dtReleaseDate.Size = new System.Drawing.Size(137, 20);
            this.dtReleaseDate.TabIndex = 14;
            this.dtReleaseDate.Value = new System.DateTime(2016, 3, 29, 0, 0, 0, 0);
            // 
            // txtbxPublishHouse
            // 
            this.txtbxPublishHouse.Location = new System.Drawing.Point(108, 61);
            this.txtbxPublishHouse.Name = "txtbxPublishHouse";
            this.txtbxPublishHouse.Size = new System.Drawing.Size(137, 20);
            this.txtbxPublishHouse.TabIndex = 12;
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.ForeColor = System.Drawing.Color.Black;
            this.lblReleaseDate.Location = new System.Drawing.Point(9, 94);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(99, 13);
            this.lblReleaseDate.TabIndex = 11;
            this.lblReleaseDate.Text = "Release Date........:";
            // 
            // lblPublishHouse
            // 
            this.lblPublishHouse.AutoSize = true;
            this.lblPublishHouse.Location = new System.Drawing.Point(9, 68);
            this.lblPublishHouse.Name = "lblPublishHouse";
            this.lblPublishHouse.Size = new System.Drawing.Size(99, 13);
            this.lblPublishHouse.TabIndex = 10;
            this.lblPublishHouse.Text = "Publish House.......:";
            // 
            // txtbxNameNewspaper
            // 
            this.txtbxNameNewspaper.Location = new System.Drawing.Point(108, 35);
            this.txtbxNameNewspaper.Name = "txtbxNameNewspaper";
            this.txtbxNameNewspaper.Size = new System.Drawing.Size(137, 20);
            this.txtbxNameNewspaper.TabIndex = 9;
            // 
            // txtbxAuthor
            // 
            this.txtbxAuthor.Location = new System.Drawing.Point(108, 9);
            this.txtbxAuthor.Name = "txtbxAuthor";
            this.txtbxAuthor.Size = new System.Drawing.Size(137, 20);
            this.txtbxAuthor.TabIndex = 8;
            // 
            // lblNameNewspaper
            // 
            this.lblNameNewspaper.AutoSize = true;
            this.lblNameNewspaper.ForeColor = System.Drawing.Color.Black;
            this.lblNameNewspaper.Location = new System.Drawing.Point(9, 42);
            this.lblNameNewspaper.Name = "lblNameNewspaper";
            this.lblNameNewspaper.Size = new System.Drawing.Size(100, 13);
            this.lblNameNewspaper.TabIndex = 7;
            this.lblNameNewspaper.Text = "Newsaper\'s name..:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(9, 16);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(101, 13);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Author....................:";
            // 
            // pnControlNewspaper
            // 
            this.pnControlNewspaper.Controls.Add(this.btnCancel);
            this.pnControlNewspaper.Controls.Add(this.btnAdd);
            this.pnControlNewspaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControlNewspaper.Location = new System.Drawing.Point(0, 224);
            this.pnControlNewspaper.Name = "pnControlNewspaper";
            this.pnControlNewspaper.Size = new System.Drawing.Size(254, 38);
            this.pnControlNewspaper.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(166, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // fmAddNewspaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 262);
            this.Controls.Add(this.pnControlNewspaper);
            this.Controls.Add(this.pnNewspaper);
            this.Name = "fmAddNewspaper";
            this.Text = "Add newspaper";
            this.pnNewspaper.ResumeLayout(false);
            this.pnNewspaper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPeriodicity)).EndInit();
            this.pnControlNewspaper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnNewspaper;
        private System.Windows.Forms.Panel pnControlNewspaper;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtbxNameNewspaper;
        private System.Windows.Forms.TextBox txtbxAuthor;
        private System.Windows.Forms.Label lblNameNewspaper;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.NumericUpDown nPeriodicity;
        private System.Windows.Forms.Label lblPeriodicity;
        private System.Windows.Forms.DateTimePicker dtReleaseDate;
        private System.Windows.Forms.TextBox txtbxPublishHouse;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblPublishHouse;
    }
}