using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace MegaDeskV1._0_Rush_Lopez
{
    public class SavedQuotes
    {

        // Initialize json file
        private static readonly string JSON_PATH = "data/quotes.json";
        
        // Initialize saved quotes list
        public List<DeskQuote> savedQuotes { get; set; }

        public SavedQuotes()
        {
            // Initialize saved quotes list from json file
            this.savedQuotes = getSavedQuotes().ToList();
        }

        public List<DeskQuote> getSavedQuotes()
        {
            // Check if json file exists
            if (!File.Exists(JSON_PATH))
            {
                // Create json file
                File.Create(JSON_PATH);
            }
            // File exists, read from file
            string savedJSON = File.ReadAllText(JSON_PATH);

            // debug statement
            Console.WriteLine(savedJSON);

            // convert json to savedQuotes list
            List<DeskQuote> savedQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(savedJSON);
            if (savedQuotes == null)
            {
                savedQuotes = new List<DeskQuote>();
            }
            
            Console.WriteLine("savedQuotes in class: " + savedQuotes);
            return savedQuotes; 
        }
    }
}
