namespace Library.Forms
{
    partial class FormAddMagazine
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
            this.pnMagazine = new System.Windows.Forms.Panel();
            this.cbPublishMonth = new System.Windows.Forms.ComboBox();
            this.txtbxMagazineTheme = new System.Windows.Forms.TextBox();
            this.lblMagazineTheme = new System.Windows.Forms.Label();
            this.lblPublishMonth = new System.Windows.Forms.Label();
            this.txtbxPublishHouse = new System.Windows.Forms.TextBox();
            this.lblPublishHouse = new System.Windows.Forms.Label();
            this.txtbxNameMagazine = new System.Windows.Forms.TextBox();
            this.lblNameMagazine = new System.Windows.Forms.Label();
            this.pnControlMagazine = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnMagazine.SuspendLayout();
            this.pnControlMagazine.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMagazine
            // 
            this.pnMagazine.Controls.Add(this.cbPublishMonth);
            this.pnMagazine.Controls.Add(this.txtbxMagazineTheme);
            this.pnMagazine.Controls.Add(this.lblMagazineTheme);
            this.pnMagazine.Controls.Add(this.lblPublishMonth);
            this.pnMagazine.Controls.Add(this.txtbxPublishHouse);
            this.pnMagazine.Controls.Add(this.lblPublishHouse);
            this.pnMagazine.Controls.Add(this.txtbxNameMagazine);
            this.pnMagazine.Controls.Add(this.lblNameMagazine);
            this.pnMagazine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMagazine.Location = new System.Drawing.Point(0, 0);
            this.pnMagazine.Name = "pnMagazine";
            this.pnMagazine.Size = new System.Drawing.Size(254, 224);
            this.pnMagazine.TabIndex = 0;
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
            this.cbPublishMonth.Location = new System.Drawing.Point(109, 62);
            this.cbPublishMonth.Name = "cbPublishMonth";
            this.cbPublishMonth.Size = new System.Drawing.Size(137, 21);
            this.cbPublishMonth.TabIndex = 19;
            // 
            // txtbxMagazineTheme
            // 
            this.txtbxMagazineTheme.Location = new System.Drawing.Point(108, 88);
            this.txtbxMagazineTheme.Name = "txtbxMagazineTheme";
            this.txtbxMagazineTheme.Size = new System.Drawing.Size(137, 20);
            this.txtbxMagazineTheme.TabIndex = 18;
            // 
            // lblMagazineTheme
            // 
            this.lblMagazineTheme.AutoSize = true;
            this.lblMagazineTheme.Location = new System.Drawing.Point(9, 95);
            this.lblMagazineTheme.Name = "lblMagazineTheme";
            this.lblMagazineTheme.Size = new System.Drawing.Size(101, 13);
            this.lblMagazineTheme.TabIndex = 17;
            this.lblMagazineTheme.Text = "MagazineTheme....:";
            // 
            // lblPublishMonth
            // 
            this.lblPublishMonth.AutoSize = true;
            this.lblPublishMonth.ForeColor = System.Drawing.Color.Black;
            this.lblPublishMonth.Location = new System.Drawing.Point(10, 69);
            this.lblPublishMonth.Name = "lblPublishMonth";
            this.lblPublishMonth.Size = new System.Drawing.Size(100, 13);
            this.lblPublishMonth.TabIndex = 15;
            this.lblPublishMonth.Text = "Publish month........:";
            // 
            // txtbxPublishHouse
            // 
            this.txtbxPublishHouse.Location = new System.Drawing.Point(109, 36);
            this.txtbxPublishHouse.Name = "txtbxPublishHouse";
            this.txtbxPublishHouse.Size = new System.Drawing.Size(137, 20);
            this.txtbxPublishHouse.TabIndex = 14;
            // 
            // lblPublishHouse
            // 
            this.lblPublishHouse.AutoSize = true;
            this.lblPublishHouse.Location = new System.Drawing.Point(10, 43);
            this.lblPublishHouse.Name = "lblPublishHouse";
            this.lblPublishHouse.Size = new System.Drawing.Size(99, 13);
            this.lblPublishHouse.TabIndex = 13;
            this.lblPublishHouse.Text = "Publish House.......:";
            // 
            // txtbxNameMagazine
            // 
            this.txtbxNameMagazine.Location = new System.Drawing.Point(109, 11);
            this.txtbxNameMagazine.Name = "txtbxNameMagazine";
            this.txtbxNameMagazine.Size = new System.Drawing.Size(137, 20);
            this.txtbxNameMagazine.TabIndex = 11;
            // 
            // lblNameMagazine
            // 
            this.lblNameMagazine.AutoSize = true;
            this.lblNameMagazine.ForeColor = System.Drawing.Color.Black;
            this.lblNameMagazine.Location = new System.Drawing.Point(10, 18);
            this.lblNameMagazine.Name = "lblNameMagazine";
            this.lblNameMagazine.Size = new System.Drawing.Size(98, 13);
            this.lblNameMagazine.TabIndex = 10;
            this.lblNameMagazine.Text = "Magazine\'s name..:";
            // 
            // pnControlMagazine
            // 
            this.pnControlMagazine.Controls.Add(this.btnCancel);
            this.pnControlMagazine.Controls.Add(this.btnAdd);
            this.pnControlMagazine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControlMagazine.Location = new System.Drawing.Point(0, 224);
            this.pnControlMagazine.Name = "pnControlMagazine";
            this.pnControlMagazine.Size = new System.Drawing.Size(254, 38);
            this.pnControlMagazine.TabIndex = 1;
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormAddMagazine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 262);
            this.Controls.Add(this.pnControlMagazine);
            this.Controls.Add(this.pnMagazine);
            this.Name = "FormAddMagazine";
            this.Text = "Add Magazine";
            this.pnMagazine.ResumeLayout(false);
            this.pnMagazine.PerformLayout();
            this.pnControlMagazine.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMagazine;
        private System.Windows.Forms.Panel pnControlMagazine;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtbxNameMagazine;
        private System.Windows.Forms.Label lblNameMagazine;
        private System.Windows.Forms.TextBox txtbxPublishHouse;
        private System.Windows.Forms.Label lblPublishHouse;
        private System.Windows.Forms.Label lblPublishMonth;
        private System.Windows.Forms.TextBox txtbxMagazineTheme;
        private System.Windows.Forms.Label lblMagazineTheme;
        private System.Windows.Forms.ComboBox cbPublishMonth;
    }
}