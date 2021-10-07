using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using books.Controllers;

namespace books
{
    public partial class inputForm : Form
    {
        public inputForm()
        {
            InitializeComponent();
            Init();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void yearTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cleearBtn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            var data = collectData();
            if (sqlController.InsertData(data))
            {
                MessageBox.Show("Registered to Database");
                reset();
            }
           // MessageBox.Show($"Title: {data.title}\nAuthor: {data.author} \nRelease Year: {data.year} \nISBN: {data.isbn} \nGenre: {data.genre}");
        }

        private DataModel collectData()
        {
            var dataModel = new DataModel()
            {
                title = bookTitleTxt.Text,
                author = authorTxt.Text,
                year = yearTxt.Text,
                isbn = isbnTxt.Text,
                genre = genresSelect.Text
            };
            return dataModel;
        }
        /// <summary>
        /// reset all fields function
        /// </summary>
        public void reset()
        {
            bookTitleTxt.Text = null;
            authorTxt.Text = null;
            yearTxt.Text = null;
            isbnTxt.Text = null;
            genresSelect.Text = null;
        }

        private void genresSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private SqlController sqlController;
        private void Init()
        {
            sqlController = new SqlController();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            var form2 = new SearchDb();
            form2.Show();
        }

        private void FilterSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
