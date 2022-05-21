using System;
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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            dgvAllQuotes.DataSource = SavedQuotes.savedQuotes;
            dgvAllQuotes.Columns["quoteDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
            dgvAllQuotes.Columns["quoteTotal"].DefaultCellStyle.Format = "c";
        }

        private void returnToMenu(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MegaDeskMainMenu)Tag;
            mainMenu.Show();
        }
    }
}
