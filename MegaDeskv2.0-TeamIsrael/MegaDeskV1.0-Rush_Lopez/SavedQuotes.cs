using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace MegaDeskV1._0_Rush_Lopez
{
    public static class SavedQuotes
    {

        // Initialize json file
        private static readonly string JSON_PATH = "data/quotes.json";
        
        // Initialize saved quotes list
        public static List<DeskQuote> savedQuotes = new List<DeskQuote>(); 

        public static void getSavedQuotes()
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
           //Console.WriteLine("\n\n\nThis is the saved json: " + savedJSON);
           

            // convert json to savedQuotes list
            savedQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(savedJSON) ?? new List<DeskQuote>();

            //Console.WriteLine("\n\n\nsavedQuotes in class: " + savedQuotes.First().displayQuote());
            //return savedQuotes; 
        }
    }
}
