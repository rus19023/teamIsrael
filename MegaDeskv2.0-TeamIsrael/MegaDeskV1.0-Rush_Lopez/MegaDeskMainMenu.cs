using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace MegaDeskV1._0_Rush_Lopez
{
    public partial class MegaDeskMainMenu : Form
    {

        // Initialize list for saved quotes
       // public static List<DeskQuote> savedQuotes = new List<DeskQuote>();
       
        public MegaDeskMainMenu()
        {
            InitializeComponent();
            SavedQuotes.getSavedQuotes();
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

        private void MegaDeskMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
