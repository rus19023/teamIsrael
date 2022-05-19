using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.IO;

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
            // Create list for saved quotes
            List<DeskQuote> savedQuotes = new SavedQuotes().getSavedQuotes();

            // Get new quote object data from AddQuote form
            // Sanitize inputs: trim, then convert? try.parse?
            int width = Convert.ToInt32(tbDesktopWidth.Text);
            int depth = Convert.ToInt32(tbDesktopDepth.Text);
            int drawers = Convert.ToInt32(cbDrawers.SelectedItem);
            string surfaceMaterial = Convert.ToString(cbMaterial.SelectedItem);
            int rushDays = Convert.ToInt32(cbRushDays.SelectedItem);
            string customerFirstName = tbFirstName.Text;
            string customerLastName = tbLastName.Text;           

            // Create new DeskQuote object from inputs
            DeskQuote newQuote = new DeskQuote(width, depth, drawers, surfaceMaterial, rushDays, customerFirstName, customerLastName);

            // Add new quote to list
            savedQuotes.Add(newQuote);

            // Convert list to json string
            string json = JsonConvert.SerializeObject(savedQuotes);

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
                // Create a file to write to.
                //string createText = "Hello and Welcome" + Environment.NewLine;
                File.WriteAllText(JSON_PATH, json);
            }
            
            // Save quote to json file
            //if (File.Exists(JSON_FILE))
            //{
            // Read the json file
            //savedJSON = File.ReadAllText(JSON_FILE);
            //Console.WriteLine(savedJSON);

            // check for new quote validity
            //if (newQuote != null) // probably a better way! this lets process continue if there is an empty object
            //{
            // Deserialize the json file
            ////var quotes = JsonConvert.DeserializeObject<List<savedQuotes>>(savedJSON);

            // Serialize the list
            //string serializedQuotes = JsonConvert.SerializeObject(savedJSON, Formatting.Indented);



            //}

            //// Deserialize the json file
            //JArray deskQuotes = JsonConvert.DeserializeObject<JArray>(json);
            ////List<DeskQuote> deskQuotes = new List<DeskQuote>();

            //// Add the new quote to the list
            //deskQuotes.Add(deskQuote);

            //// Serialize the list
            //string converted = JsonConvert.SerializeObject(deskQuotes, Formatting.Indented);

            //// Write the converted list to the json file
            //File.WriteAllText(JSON_FILE, converted);
            //}
            //else
            //{
            // Create a new array of desk quotes
            //JArray JSON = new JArray
            //{
            //    // Add the new quote to the list
            //    deskQuote
            //};

            //    // create a new list of desk quotes
            //    List<DeskQuote> quotes = new List<DeskQuote>();
            //    quotes.Add(newQuote);

            //    // Convert the list to JSON
            //    string converted = JsonConvert.SerializeObject(quotes, Formatting.Indented);

            //    // Write the converted list to the json file
            //    File.WriteAllText(JSON_FILE, converted);
            //}

            // Create new DisplayQuote form instance with the DeskQuote object
            DisplayQuote formDisplayQuote = new DisplayQuote(newQuote);
            formDisplayQuote.Tag = (MegaDeskMainMenu)Tag;
            formDisplayQuote.Show((MegaDeskMainMenu)Tag);


            //Console.WriteLine("width: " + width);
            //Console.WriteLine("depth: " + depth);
            //Console.WriteLine("drawers: " + drawers);
            //Console.WriteLine("surfaceMaterial: " + surfaceMaterial);
            //Console.WriteLine("rushDays: " + rushDays);
            //Console.WriteLine("customerFirstName: " + customerFirstName);
            //Console.WriteLine("customerLastName: " + customerLastName);
            //Console.WriteLine("getQuoteDate: " + newQuote.displayQuoteDate());
            //Console.WriteLine("getQuoteTotal: " + newQuote.getQuoteTotal());
            //Console.WriteLine("json: " + json);
            //Console.WriteLine("x ");
            //Console.WriteLine("quotes.Count(): " + savedQuotes.Count());
            //Console.WriteLine("x ");
            //Console.WriteLine("x ");
            //Console.Write("serializedQuotes: " + serializedQuotes);
            Console.WriteLine(savedQuotes.ToString());
            //Console.WriteLine("x ");

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
    }        
 }
    
