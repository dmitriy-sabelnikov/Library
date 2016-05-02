namespace Library
{
    partial class FormLibrary
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
            this.pnGrid = new System.Windows.Forms.Panel();
            this.gridLibrary = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodicity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MagazineTheme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewspaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMagazineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchNewspaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMagazineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAllBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAllNewspapersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAllMagazinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadNewspapersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMagazinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLibrary)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnGrid
            // 
            this.pnGrid.Controls.Add(this.gridLibrary);
            this.pnGrid.Controls.Add(this.menuStrip1);
            this.pnGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGrid.Location = new System.Drawing.Point(0, 0);
            this.pnGrid.Name = "pnGrid";
            this.pnGrid.Size = new System.Drawing.Size(584, 362);
            this.pnGrid.TabIndex = 0;
            // 
            // gridLibrary
            // 
            this.gridLibrary.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.gridLibrary.AllowUserToAddRows = false;
            this.gridLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLibrary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Author,
            this.NameBook,
            this.CodeBook,
            this.PublishHouse,
            this.ReleaseDate,
            this.Periodicity,
            this.PublishMonth,
            this.MagazineTheme,
            this.Type});
            this.gridLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLibrary.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridLibrary.Location = new System.Drawing.Point(0, 24);
            this.gridLibrary.Name = "gridLibrary";
            this.gridLibrary.ShowCellErrors = false;
            this.gridLibrary.ShowCellToolTips = false;
            this.gridLibrary.ShowEditingIcon = false;
            this.gridLibrary.ShowRowErrors = false;
            this.gridLibrary.Size = new System.Drawing.Size(584, 338);
            this.gridLibrary.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // NameBook
            // 
            this.NameBook.HeaderText = "Name";
            this.NameBook.Name = "NameBook";
            this.NameBook.ReadOnly = true;
            // 
            // CodeBook
            // 
            this.CodeBook.HeaderText = "Code Book";
            this.CodeBook.Name = "CodeBook";
            this.CodeBook.ReadOnly = true;
            // 
            // PublishHouse
            // 
            this.PublishHouse.HeaderText = "Publish House ";
            this.PublishHouse.Name = "PublishHouse";
            this.PublishHouse.ReadOnly = true;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.HeaderText = "Release Date";
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
            // 
            // Periodicity
            // 
            this.Periodicity.HeaderText = "Periodicity";
            this.Periodicity.Name = "Periodicity";
            this.Periodicity.ReadOnly = true;
            // 
            // PublishMonth
            // 
            this.PublishMonth.HeaderText = "Publish Month";
            this.PublishMonth.Name = "PublishMonth";
            // 
            // MagazineTheme
            // 
            this.MagazineTheme.HeaderText = "Magazine\'s Theme";
            this.MagazineTheme.Name = "MagazineTheme";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.eDITToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.lOADToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.addNewspaperToolStripMenuItem,
            this.addMagazineToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fToolStripMenuItem.Text = "FILE";
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addBookToolStripMenuItem.Text = "Add book";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // addNewspaperToolStripMenuItem
            // 
            this.addNewspaperToolStripMenuItem.Name = "addNewspaperToolStripMenuItem";
            this.addNewspaperToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addNewspaperToolStripMenuItem.Text = "Add newspaper";
            this.addNewspaperToolStripMenuItem.Click += new System.EventHandler(this.addNewspaperToolStripMenuItem_Click);
            // 
            // addMagazineToolStripMenuItem
            // 
            this.addMagazineToolStripMenuItem.Name = "addMagazineToolStripMenuItem";
            this.addMagazineToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addMagazineToolStripMenuItem.Text = "Add magazine";
            this.addMagazineToolStripMenuItem.Click += new System.EventHandler(this.addMagazineToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.searchNewspaperToolStripMenuItem,
            this.searchMagazineToolStripMenuItem});
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.eDITToolStripMenuItem.Text = "SEARCH";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.searchToolStripMenuItem.Text = "Search book";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // searchNewspaperToolStripMenuItem
            // 
            this.searchNewspaperToolStripMenuItem.Name = "searchNewspaperToolStripMenuItem";
            this.searchNewspaperToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.searchNewspaperToolStripMenuItem.Text = "Search newspaper";
            this.searchNewspaperToolStripMenuItem.Click += new System.EventHandler(this.searchNewspaperToolStripMenuItem_Click);
            // 
            // searchMagazineToolStripMenuItem
            // 
            this.searchMagazineToolStripMenuItem.Name = "searchMagazineToolStripMenuItem";
            this.searchMagazineToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.searchMagazineToolStripMenuItem.Text = "Search magazine";
            this.searchMagazineToolStripMenuItem.Click += new System.EventHandler(this.searchMagazineToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToXMLToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.exportToolStripMenuItem.Text = "SAVE";
            // 
            // exportToXMLToolStripMenuItem
            // 
            this.exportToXMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAllBooksToolStripMenuItem,
            this.exportAllNewspapersToolStripMenuItem,
            this.exportAllMagazinesToolStripMenuItem});
            this.exportToXMLToolStripMenuItem.Name = "exportToXMLToolStripMenuItem";
            this.exportToXMLToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exportToXMLToolStripMenuItem.Text = "Save to XML";
            // 
            // exportAllBooksToolStripMenuItem
            // 
            this.exportAllBooksToolStripMenuItem.Name = "exportAllBooksToolStripMenuItem";
            this.exportAllBooksToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exportAllBooksToolStripMenuItem.Text = "Save books";
            this.exportAllBooksToolStripMenuItem.Click += new System.EventHandler(this.exportAllBooksToolStripMenuItem_Click);
            // 
            // exportAllNewspapersToolStripMenuItem
            // 
            this.exportAllNewspapersToolStripMenuItem.Name = "exportAllNewspapersToolStripMenuItem";
            this.exportAllNewspapersToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exportAllNewspapersToolStripMenuItem.Text = "Save newspapers";
            this.exportAllNewspapersToolStripMenuItem.Click += new System.EventHandler(this.exportAllNewspapersToolStripMenuItem_Click);
            // 
            // exportAllMagazinesToolStripMenuItem
            // 
            this.exportAllMagazinesToolStripMenuItem.Name = "exportAllMagazinesToolStripMenuItem";
            this.exportAllMagazinesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exportAllMagazinesToolStripMenuItem.Text = "Save magazines";
            this.exportAllMagazinesToolStripMenuItem.Click += new System.EventHandler(this.exportAllMagazinesToolStripMenuItem_Click);
            // 
            // lOADToolStripMenuItem
            // 
            this.lOADToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFromXMLToolStripMenuItem});
            this.lOADToolStripMenuItem.Name = "lOADToolStripMenuItem";
            this.lOADToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.lOADToolStripMenuItem.Text = "LOAD";
            // 
            // loadFromXMLToolStripMenuItem
            // 
            this.loadFromXMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadBooksToolStripMenuItem,
            this.loadNewspapersToolStripMenuItem,
            this.loadMagazinesToolStripMenuItem});
            this.loadFromXMLToolStripMenuItem.Name = "loadFromXMLToolStripMenuItem";
            this.loadFromXMLToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.loadFromXMLToolStripMenuItem.Text = "Load from XML";
            // 
            // loadBooksToolStripMenuItem
            // 
            this.loadBooksToolStripMenuItem.Name = "loadBooksToolStripMenuItem";
            this.loadBooksToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.loadBooksToolStripMenuItem.Text = "Load books";
            this.loadBooksToolStripMenuItem.Click += new System.EventHandler(this.loadBooksToolStripMenuItem_Click);
            // 
            // loadNewspapersToolStripMenuItem
            // 
            this.loadNewspapersToolStripMenuItem.Name = "loadNewspapersToolStripMenuItem";
            this.loadNewspapersToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.loadNewspapersToolStripMenuItem.Text = "Load newspapers";
            this.loadNewspapersToolStripMenuItem.Click += new System.EventHandler(this.loadNewspapersToolStripMenuItem_Click);
            // 
            // loadMagazinesToolStripMenuItem
            // 
            this.loadMagazinesToolStripMenuItem.Name = "loadMagazinesToolStripMenuItem";
            this.loadMagazinesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.loadMagazinesToolStripMenuItem.Text = "Load magazines";
            this.loadMagazinesToolStripMenuItem.Click += new System.EventHandler(this.loadMagazinesToolStripMenuItem_Click);
            // 
            // FormLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.pnGrid);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormLibrary";
            this.Text = "Library";
            this.pnGrid.ResumeLayout(false);
            this.pnGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLibrary)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnGrid;
        private System.Windows.Forms.DataGridView gridLibrary;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewspaperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchNewspaperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addMagazineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchMagazineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAllBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAllNewspapersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAllMagazinesToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodicity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn MagazineTheme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.ToolStripMenuItem lOADToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadNewspapersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMagazinesToolStripMenuItem;
    }
}

