using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDeskV1._0_Rush_Lopez     
{
        public partial class AddQuote : Form
        {
            private bool displayingQuote;
            

        public AddQuote()
        {
            InitializeComponent();
            // Initialize the combo box with the list of materials
            var materials = Enum.GetValues(typeof(surfaceMaterials)).Cast<surfaceMaterials>().ToList();
            cbMaterial.DataSource = materials;
            displayingQuote = false;
        }

        private void widthValidating(object sender, CancelEventArgs e)
        {
            // Validate the width input
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
                // If the width is not between 24 and 96, display an error message
                e.Cancel = true;
                
                // todo: Why use Select()?
                tbDesktopWidth.Select(0, tbDesktopWidth.Text.Length);
                errMessage = "Please enter a number between 24 and 96";
                this.errProviderWidth.SetError(tbDesktopWidth, errMessage);
            }
        }

        private void widthValidated(object sender, EventArgs e)
        {
            // Clear the error message when the width is valid
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
            // Get the depth user input from AddQuote form
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
            // Get info from AddQuote form
            int width = Convert.ToInt32(tbDesktopWidth.Text);
            int depth = Convert.ToInt32(tbDesktopDepth.Text);
            int drawers = Convert.ToInt32(cbDrawers.SelectedItem);
            string surfaceMaterial = Convert.ToString(cbMaterial.SelectedItem);
            int rushDays = Convert.ToInt32(cbRushDays.SelectedItem);
            string customerFirstName = tbFirstName.Text;
            string customerLastName = tbLastName.Text;
            displayingQuote = true;

            
            // Create new DeskQuote object
            DeskQuote deskQuote = new DeskQuote(width, depth, drawers, surfaceMaterial, rushDays, customerFirstName, customerLastName);
            
            // Create new DeskQuote object
            DisplayQuote formDisplayQuote = new DisplayQuote(deskQuote);
            formDisplayQuote.Tag = (MegaDeskMainMenu)Tag;
            formDisplayQuote.Show((MegaDeskMainMenu)Tag);
            
            // todo: what does this close?
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

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }        
 }
    
