using System;
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
        }

        private void dgvAllQuotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            var mainMenu = (MegaDeskMainMenu)Tag;
            mainMenu.Show();
            Close();
        }
    }
}
