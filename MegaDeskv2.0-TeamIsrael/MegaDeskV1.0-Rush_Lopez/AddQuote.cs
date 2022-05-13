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
        public partial class AddQuote : Form
        {
            private bool displayingQuote;

        public AddQuote()
        {
            InitializeComponent();
            displayingQuote = false;
        }

        private void widthValidating(object sender, CancelEventArgs e)
        {
            string errMessage;
            int width;
            try
            {
                width = Convert.ToInt32(tbDesktopWidth.Text);
            }
            catch (Exception ex)
            {
                width = 0;
            }

            if (width < 24 || width > 96)
            {
                e.Cancel = true;
                tbDesktopWidth.Select(0, tbDesktopWidth.Text.Length);

                errMessage = "Please enter a number between 24 and 96";

                this.errProviderWidth.SetError(tbDesktopWidth, errMessage);
            }
        }

        private void widthValidated(object sender, EventArgs e)
        {
            errProviderWidth.Clear();
        }

        private void depthKeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                this.errProviderDepth.Clear();

            }
            else
            {

                this.errProviderDepth.SetError(tbDesktopDepth, "Please enter a digit between 0 - 9");
            }
        }

        private void depthValidating(object sender, CancelEventArgs e)
        {
            int depth = Convert.ToInt32(tbDesktopDepth.Text);

            if (depth < 12 || depth > 48)
            {
                e.Cancel = true;
                tbDesktopDepth.Select(0, tbDesktopDepth.Text.Length);

                this.errProviderDepth.SetError(tbDesktopDepth, "Please enter a number between 12 and 48");
            }
        }

        private void depthValidated(object sender, EventArgs e)
        {
            errProviderDepth.Clear();
        }

        private void textboxEnter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb != null)
            {
                tb.Select(0, tb.Text.Length);
            }
        }

        private void saveQuote(object sender, EventArgs e)
        {
            string customerFirstName = tbFirstName.Text;
            string customerLastName = tbLastName.Text;
            int rushDays = Convert.ToInt32(cbRushDays.SelectedItem);
            int width = Convert.ToInt32(tbDesktopWidth.Text);
            int depth = Convert.ToInt32(tbDesktopDepth.Text);
            string surfaceMaterial = Convert.ToString(cbMaterial.SelectedItem);
            int drawers = Convert.ToInt32(cbDrawers.SelectedItem);
            displayingQuote = true;

            DeskQuote deskQuote = new DeskQuote(width, depth, drawers, surfaceMaterial, rushDays, customerFirstName, customerLastName);
            deskQuote.calcTotalPrice();

            DisplayQuote formDisplayQuote = new DisplayQuote(deskQuote);
            formDisplayQuote.Tag = (MegaDeskMainMenu)Tag;
            formDisplayQuote.Show((MegaDeskMainMenu)Tag);
            Close();
        }

        private void returnToMenu(object sender, FormClosingEventArgs e)
        {
            if (!displayingQuote)
            {
                var mainMenu = (MegaDeskMainMenu)Tag;
                mainMenu.Show();
            }
            
        }
    }        
 }
    
