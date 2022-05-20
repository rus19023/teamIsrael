using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MegaDeskV1._0_Rush_Lopez
{
    public static class Globals
    {
        private static readonly string JSON_PATH = "data/quotes.json";
        public static List<DeskQuote> savedQuotes { get; set; }

        public static List<DeskQuote> getSavedQuotes()
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
            var savedQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(savedJSON);
            
            Console.WriteLine("savedQuotes in class: " + savedQuotes);
            return savedQuotes;
        }
    }
}
