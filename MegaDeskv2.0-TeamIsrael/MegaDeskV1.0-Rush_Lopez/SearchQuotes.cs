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
    }
}
