using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MegaDeskV1._0_Rush_Lopez     
{
        public partial class AddQuote : Form
    {
        // Initialize json file
        private static readonly string JSON_PATH = @"data/quotes.json";
        //private static readonly string JSON_PATH = $"{Application.StartupPath}\\{JSON_FILE}";
        
        public AddQuote()
        {
            InitializeComponent();
            
            // Initialize the combo box with the list of materials
            var materials = Enum.GetValues(typeof(surfaceMaterials)).Cast<surfaceMaterials>().ToList();
            cbMaterial.DataSource = materials;
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
            // todo: handle exception?
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
            

            // Get new quote object data from AddQuote form
            // Sanitize inputs: trim, then convert? try.parse?
            string sWidth = tbDesktopWidth.Text;
            string sDepth = tbDesktopDepth.Text;
            string sDrawers = Convert.ToString(cbDrawers.SelectedItem);
            string surfaceMaterial = Convert.ToString(cbMaterial.SelectedItem);
            string sRushDays = Convert.ToString(cbRushDays.SelectedItem);
            string customerFirstName = tbFirstName.Text.Trim();
            string customerLastName = tbLastName.Text.Trim();

            //Validate that no fields are empty before continuing. If empty, display error messagebox and exit out of event
            if (string.IsNullOrWhiteSpace(sWidth) || string.IsNullOrWhiteSpace(sDepth) ||
                string.IsNullOrWhiteSpace(sDrawers) || string.IsNullOrWhiteSpace(surfaceMaterial) 
                || string.IsNullOrWhiteSpace(sRushDays) || string.IsNullOrWhiteSpace(customerFirstName) 
                || string.IsNullOrWhiteSpace(customerLastName))
            {
                MessageBox.Show("Please fill out all the information.", "ERROR!!");
                return;
            }

            int width = Convert.ToInt32(sWidth);
            int depth = Convert.ToInt32(sDepth);
            int drawers = Convert.ToInt32(sDrawers);
            int rushDays = Convert.ToInt32(sRushDays);

            // Create new DeskQuote object from inputs
            DeskQuote newQuote = new DeskQuote(width, depth, drawers, surfaceMaterial, rushDays, customerFirstName, customerLastName);

            // Add new quote to list
            SavedQuotes.savedQuotes.Add(newQuote);
            
            // Convert list to json string
            string json = JsonConvert.SerializeObject(SavedQuotes.savedQuotes);

            // Write the serialized list to the json file
            if (File.Exists(JSON_PATH))
            {
                Console.WriteLine("json variable contents: " + json);
                File.WriteAllText(JSON_PATH, json);
                Console.WriteLine("New quotes written to quotes.json ");
            }
            else
            {
                Console.WriteLine("File not found! Creating one;");
                // Create a json file
                File.WriteAllText(JSON_PATH, json);
            }
            // Create new DisplayQuote form instance with the DeskQuote object
            DisplayQuote formDisplayQuote = new DisplayQuote(newQuote);
            formDisplayQuote.Tag = (MegaDeskMainMenu)Tag;
            formDisplayQuote.Show((MegaDeskMainMenu)Tag);

            // close addQuote form
            Close();
        }

        private void returnToMenu(object sender, FormClosingEventArgs e)
        {
                var mainMenu = (MegaDeskMainMenu)Tag;
                mainMenu.Show();
            //}
            
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDesktopWidth_TextChanged(object sender, EventArgs e)
        {

        }
    }        
 }
    
