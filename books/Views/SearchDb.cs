﻿using System;
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
    public partial class SearchDb : Form
    {
        public SearchDb()
        {
            InitializeComponent();
            Init();
        }

        private SqlController sqlController;
        private void Init()
        {
            sqlController = new SqlController();
        }

        private void SearchDb_Load(object sender, EventArgs e)
        {

        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            string selection = FilterSelect.Text;
            var data = sqlController.SelectData(selection);

            for (int i = 0; i < data.Count; i++)
            {
                resultsBox.Text+=($"Book Title: {data[i].title}, Author: {data[i].author}, Release Year: {data[i].year}/n");
            }
        }

        private void resultsBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
