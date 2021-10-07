
namespace books
{
    partial class SearchDb
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
            this.label1 = new System.Windows.Forms.Label();
            this.FilterSelect = new System.Windows.Forms.ComboBox();
            this.showBtn = new System.Windows.Forms.Button();
            this.resultsBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(338, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "FILTERS";
            // 
            // FilterSelect
            // 
            this.FilterSelect.FormattingEnabled = true;
            this.FilterSelect.Items.AddRange(new object[] {
            "Fantasy",
            "Sci-fi",
            "Thriller",
            "Drama",
            "Mystery",
            "Science",
            "History"});
            this.FilterSelect.Location = new System.Drawing.Point(297, 39);
            this.FilterSelect.Name = "FilterSelect";
            this.FilterSelect.Size = new System.Drawing.Size(184, 23);
            this.FilterSelect.TabIndex = 15;
            this.FilterSelect.Text = "Select Genre to Show Books";
            // 
            // showBtn
            // 
            this.showBtn.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.showBtn.Location = new System.Drawing.Point(297, 113);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(184, 73);
            this.showBtn.TabIndex = 16;
            this.showBtn.Text = "show";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // resultsBox
            // 
            this.resultsBox.Location = new System.Drawing.Point(12, 213);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(776, 225);
            this.resultsBox.TabIndex = 18;
            this.resultsBox.Text = "";
            this.resultsBox.TextChanged += new System.EventHandler(this.resultsBox_TextChanged);
            // 
            // SearchDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.FilterSelect);
            this.Controls.Add(this.label1);
            this.Name = "SearchDb";
            this.Text = "Search the Database";
            this.Load += new System.EventHandler(this.SearchDb_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FilterSelect;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.RichTextBox resultsBox;
    }
}