﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDeskV1._0_Rush_Lopez
{
    public partial class MegaDeskMainMenu : Form
    {
        public MegaDeskMainMenu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddQuote_Click_1(object sender, EventArgs e)
        {
            
            {
                AddQuote addQuote = new AddQuote();
                addQuote.ShowDialog();
            }

        }

        private void btnViewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotes = new ViewAllQuotes();
            viewAllQuotes.ShowDialog();

        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotes = new SearchQuotes();
            searchQuotes.ShowDialog();
        }
    }
}
