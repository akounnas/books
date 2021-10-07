
namespace books
{
    partial class inputForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.bookTitle = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.bookTitleTxt = new System.Windows.Forms.TextBox();
            this.isbnTxt = new System.Windows.Forms.TextBox();
            this.authorTxt = new System.Windows.Forms.TextBox();
            this.yearTxt = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.cleearBtn = new System.Windows.Forms.Button();
            this.genresSelect = new System.Windows.Forms.ComboBox();
            this.showBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(321, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(231, 30);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Books Inventory";
            // 
            // bookTitle
            // 
            this.bookTitle.AutoSize = true;
            this.bookTitle.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookTitle.Location = new System.Drawing.Point(13, 59);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(108, 24);
            this.bookTitle.TabIndex = 1;
            this.bookTitle.Text = "Book Title: ";
            this.bookTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.genre.Location = new System.Drawing.Point(13, 155);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(71, 24);
            this.genre.TabIndex = 2;
            this.genre.Text = "Genre: ";
            // 
            // isbn
            // 
            this.isbn.AutoSize = true;
            this.isbn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.isbn.Location = new System.Drawing.Point(13, 131);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(52, 24);
            this.isbn.TabIndex = 3;
            this.isbn.Text = "ISBN";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.year.Location = new System.Drawing.Point(13, 107);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(128, 24);
            this.year.TabIndex = 4;
            this.year.Text = "Release Year: ";
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.author.Location = new System.Drawing.Point(13, 83);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(81, 24);
            this.author.TabIndex = 5;
            this.author.Text = "Author: ";
            this.author.Click += new System.EventHandler(this.label5_Click);
            // 
            // bookTitleTxt
            // 
            this.bookTitleTxt.Location = new System.Drawing.Point(213, 63);
            this.bookTitleTxt.Name = "bookTitleTxt";
            this.bookTitleTxt.Size = new System.Drawing.Size(487, 23);
            this.bookTitleTxt.TabIndex = 6;
            // 
            // isbnTxt
            // 
            this.isbnTxt.Location = new System.Drawing.Point(213, 131);
            this.isbnTxt.Name = "isbnTxt";
            this.isbnTxt.Size = new System.Drawing.Size(487, 23);
            this.isbnTxt.TabIndex = 7;
            // 
            // authorTxt
            // 
            this.authorTxt.Location = new System.Drawing.Point(213, 83);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.Size = new System.Drawing.Size(487, 23);
            this.authorTxt.TabIndex = 8;
            // 
            // yearTxt
            // 
            this.yearTxt.Location = new System.Drawing.Point(213, 107);
            this.yearTxt.Name = "yearTxt";
            this.yearTxt.Size = new System.Drawing.Size(60, 23);
            this.yearTxt.TabIndex = 9;
            this.yearTxt.TextChanged += new System.EventHandler(this.yearTxt_TextChanged);
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.submitBtn.Location = new System.Drawing.Point(213, 211);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(184, 73);
            this.submitBtn.TabIndex = 10;
            this.submitBtn.Text = "submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // cleearBtn
            // 
            this.cleearBtn.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cleearBtn.Location = new System.Drawing.Point(516, 211);
            this.cleearBtn.Name = "cleearBtn";
            this.cleearBtn.Size = new System.Drawing.Size(184, 73);
            this.cleearBtn.TabIndex = 11;
            this.cleearBtn.Text = "Clear Form";
            this.cleearBtn.UseVisualStyleBackColor = true;
            this.cleearBtn.Click += new System.EventHandler(this.cleearBtn_Click);
            // 
            // genresSelect
            // 
            this.genresSelect.FormattingEnabled = true;
            this.genresSelect.Items.AddRange(new object[] {
            "Fantasy",
            "Sci-fi",
            "Thriller",
            "Drama",
            "Mystery",
            "Science",
            "History"});
            this.genresSelect.Location = new System.Drawing.Point(213, 155);
            this.genresSelect.Name = "genresSelect";
            this.genresSelect.Size = new System.Drawing.Size(235, 23);
            this.genresSelect.TabIndex = 12;
            this.genresSelect.Text = "Select Genre...";
            this.genresSelect.SelectedIndexChanged += new System.EventHandler(this.genresSelect_SelectedIndexChanged);
            // 
            // showBtn
            // 
            this.showBtn.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.showBtn.Location = new System.Drawing.Point(272, 322);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(329, 42);
            this.showBtn.TabIndex = 13;
            this.showBtn.Text = "search the database";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // inputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 376);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.genresSelect);
            this.Controls.Add(this.cleearBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.yearTxt);
            this.Controls.Add(this.authorTxt);
            this.Controls.Add(this.isbnTxt);
            this.Controls.Add(this.bookTitleTxt);
            this.Controls.Add(this.author);
            this.Controls.Add(this.year);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.bookTitle);
            this.Controls.Add(this.lbl1);
            this.Name = "inputForm";
            this.Text = "Book Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label bookTitle;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Label isbn;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.TextBox bookTitleTxt;
        private System.Windows.Forms.TextBox isbnTxt;
        private System.Windows.Forms.TextBox authorTxt;
        private System.Windows.Forms.TextBox yearTxt;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button cleearBtn;
        private System.Windows.Forms.ComboBox genresSelect;
        private System.Windows.Forms.Button showBtn;
    }
}

