namespace Library
{
    partial class FormAddBook
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
            this.pnBook = new System.Windows.Forms.Panel();
            this.txtbxNameBook = new System.Windows.Forms.TextBox();
            this.txtbxAuthor = new System.Windows.Forms.TextBox();
            this.txtbxCode = new System.Windows.Forms.TextBox();
            this.lblNameBook = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.pnControlBook = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnBook.SuspendLayout();
            this.pnControlBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBook
            // 
            this.pnBook.Controls.Add(this.txtbxNameBook);
            this.pnBook.Controls.Add(this.txtbxAuthor);
            this.pnBook.Controls.Add(this.txtbxCode);
            this.pnBook.Controls.Add(this.lblNameBook);
            this.pnBook.Controls.Add(this.lblAuthor);
            this.pnBook.Controls.Add(this.lblCode);
            this.pnBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBook.Location = new System.Drawing.Point(0, 0);
            this.pnBook.Name = "pnBook";
            this.pnBook.Size = new System.Drawing.Size(254, 224);
            this.pnBook.TabIndex = 0;
            // 
            // txtbxNameBook
            // 
            this.txtbxNameBook.Location = new System.Drawing.Point(86, 64);
            this.txtbxNameBook.Name = "txtbxNameBook";
            this.txtbxNameBook.Size = new System.Drawing.Size(154, 20);
            this.txtbxNameBook.TabIndex = 5;
            // 
            // txtbxAuthor
            // 
            this.txtbxAuthor.Location = new System.Drawing.Point(86, 35);
            this.txtbxAuthor.Name = "txtbxAuthor";
            this.txtbxAuthor.Size = new System.Drawing.Size(154, 20);
            this.txtbxAuthor.TabIndex = 4;
            // 
            // txtbxCode
            // 
            this.txtbxCode.Location = new System.Drawing.Point(86, 9);
            this.txtbxCode.Name = "txtbxCode";
            this.txtbxCode.Size = new System.Drawing.Size(154, 20);
            this.txtbxCode.TabIndex = 3;
            // 
            // lblNameBook
            // 
            this.lblNameBook.AutoSize = true;
            this.lblNameBook.ForeColor = System.Drawing.Color.Black;
            this.lblNameBook.Location = new System.Drawing.Point(9, 67);
            this.lblNameBook.Name = "lblNameBook";
            this.lblNameBook.Size = new System.Drawing.Size(77, 13);
            this.lblNameBook.TabIndex = 2;
            this.lblNameBook.Text = "Book\'s name..:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(10, 42);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(77, 13);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author............:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(10, 16);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(77, 13);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Code..............:";
            // 
            // pnControlBook
            // 
            this.pnControlBook.Controls.Add(this.btnCancel);
            this.pnControlBook.Controls.Add(this.btnAdd);
            this.pnControlBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControlBook.Location = new System.Drawing.Point(0, 224);
            this.pnControlBook.Name = "pnControlBook";
            this.pnControlBook.Size = new System.Drawing.Size(254, 38);
            this.pnControlBook.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(165, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // fmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 262);
            this.Controls.Add(this.pnControlBook);
            this.Controls.Add(this.pnBook);
            this.Name = "fmAddBook";
            this.Text = "Add Book";
            this.pnBook.ResumeLayout(false);
            this.pnBook.PerformLayout();
            this.pnControlBook.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBook;
        private System.Windows.Forms.Panel pnControlBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtbxNameBook;
        private System.Windows.Forms.TextBox txtbxAuthor;
        private System.Windows.Forms.TextBox txtbxCode;
        private System.Windows.Forms.Label lblNameBook;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblCode;
    }
}