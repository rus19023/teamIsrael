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
    public partial class MegaDeskMainMenu : Form
    {
        public MegaDeskMainMenu()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void navAddQuote(object sender, EventArgs e)
        {
            AddQuote formAddQuote = new AddQuote();
            formAddQuote.Tag = this;
            formAddQuote.Show(this);
            Hide();
        }

        private void navViewQuotes(object sender, EventArgs e)
        {
            ViewAllQuotes formViewAllQuotes = new ViewAllQuotes();
            formViewAllQuotes.Tag = this;
            formViewAllQuotes.Show(this);
            Hide();
        }

        private void navSearchQuotes(object sender, EventArgs e)
        {
            SearchQuotes formSearchQuotes = new SearchQuotes();
            formSearchQuotes.Tag = this;
            formSearchQuotes.Show(this);
            Hide();
        }
    }
}
