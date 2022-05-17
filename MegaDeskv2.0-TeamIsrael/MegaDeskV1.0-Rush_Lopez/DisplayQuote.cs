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
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();
            lblQuote.Text = deskQuote.displayQuote();
            displayFirstName.Text = deskQuote.customerFirstName;
        }

        private void returnToMenu(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MegaDeskMainMenu)Tag;
            mainMenu.Show();
        }

        private void lblQuote_Click(object sender, EventArgs e)
        {

        }
    }
}
