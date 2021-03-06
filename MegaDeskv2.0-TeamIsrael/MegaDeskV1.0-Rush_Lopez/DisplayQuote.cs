using System;
using System.Windows.Forms;

namespace MegaDeskV1._0_Rush_Lopez
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();
            displayCustomerName.Text = deskQuote.displayCustomerName();
            displayWidth.Text = deskQuote.displayWidth();
            displayDepth.Text = deskQuote.displayDepth();
            displayDrawers.Text = deskQuote.displayDrawers();
            displayMaterial.Text = deskQuote.displayMaterial();
            displayRushDays.Text = deskQuote.displayRushDays();
            displayQuoteDate.Text = deskQuote.displayQuoteDate();
            displayQuoteTotal.Text = deskQuote.displayQuoteTotal();
        }

        private void returnToMenu(object sender, FormClosingEventArgs e)
        {
        }

        private void lblQuote_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveQuote_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form
            Close();
        }
    }
}
