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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            var materials = Enum.GetValues(typeof(surfaceMaterials)).Cast<surfaceMaterials>().ToList();
            cbMaterial.DataSource = materials;
        }

        private void returnToMenu(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MegaDeskMainMenu)Tag;
            mainMenu.Show();
        }

        private void searchQuoteButton_Click(object sender, EventArgs e)
        {
            //clear data and reset to delete results from previous searches
            quoteSearchResults.Rows.Clear();
            quoteSearchResults.Refresh();

            //get selected material
            var material = cbMaterial.SelectedItem;

            //loop through the saved quotes to find matches
            foreach (var quote in SavedQuotes.savedQuotes.Where(quote => material.ToString() == quote.surfaceMaterial.ToString()))
            {
                //add new row for successful match with required column data
                quoteSearchResults.Rows.Add($"{quote.customerFirstName} {quote.customerLastName}", quote.quoteDate.ToString("MM/dd/yyyy"), quote.width, quote.depth,
                    quote.drawers, quote.surfaceMaterial, quote.rushDays, quote.getQuoteTotal());
            }
            
        }
    }
}
