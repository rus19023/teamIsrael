using System.Windows.Forms;

namespace MegaDeskV1._0_Rush_Lopez
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void returnToMenu(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MegaDeskMainMenu)Tag;
            mainMenu.Show();
        }
    }
}
