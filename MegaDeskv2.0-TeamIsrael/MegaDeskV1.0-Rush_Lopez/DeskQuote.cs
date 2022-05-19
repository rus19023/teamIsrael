using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Xml;

namespace MegaDeskV1._0_Rush_Lopez
{
    public class DeskQuote : Desk
    {
        // todo: are these properties, members, fields or variables? or something else?
        public string customerFirstName { get; set; }
        public string customerLastName { get; set; }
        public int rushDays { get; set; }
        public DateTime quoteDate { get; set; }
        public int quoteTotal { get; set; }

        // todo: is this a constructor? Why does the top part have total and date, but not here?
        public DeskQuote(int width, int depth, int drawers, string surfaceMaterial, int rushDays, string customerFirstName, string customerLastName) :
            base(width, depth, drawers, surfaceMaterial)
        {
            this.rushDays = rushDays;
            this.customerFirstName = customerFirstName;
            this.customerLastName = customerLastName;
            this.quoteTotal = getQuoteTotal();
            this.quoteDate = DateTime.Today;
        }

        public int calcRushPrice()
        {
            int surfaceArea = calcSurfaceArea();
            int rushPrice;

            switch (rushDays)
            {
                case 3:
                    if (surfaceArea < 1000) rushPrice = 60;
                    else if (surfaceArea <= 2000) rushPrice = 70;
                    else rushPrice = 80;
                    break;
                case 5:
                    if (surfaceArea < 1000) rushPrice = 40;
                    else if (surfaceArea <= 2000) rushPrice = 50;
                    else rushPrice = 60;
                    break;
                case 7:
                    if (surfaceArea < 1000) rushPrice = 30;
                    else if (surfaceArea <= 2000) rushPrice = 35;
                    else rushPrice = 40;
                    break;
                default:
                    rushPrice = 0;
                    break;
            }
            return rushPrice;
        }

        public int calcDrawerPrice()
        {
            return 50 * drawers;
        }

        public int calcAreaPrice()
        {
            int surfaceArea = calcSurfaceArea();
            if (surfaceArea > 1000)
            {
                return 200 + (surfaceArea - 1000);
            }
            else
            {
                return 200;
            }
        }

        public int calcMaterialPrice()
        {
            string material = surfaceMaterial;
            int materialPrice = 0;

            switch (material)
            {
                case "Oak":
                    materialPrice = 200;
                    break;
                case "Laminate":
                    materialPrice = 100;
                    break;
                case "Pine":
                    materialPrice = 50;
                    break;
                case "Rosewood":
                    materialPrice = 300;
                    break;
                case "Veneer":
                    materialPrice = 125;
                    break;
            }
            return materialPrice;
        }

        public int getQuoteTotal()
        {
            int totalPrice = calcAreaPrice() + calcDrawerPrice() + calcMaterialPrice() + calcRushPrice();
            return totalPrice;
        }

        public string displayWidth()
        {
            return width.ToString() + " inches";
        }

        public string displayDepth()
        {
            return depth.ToString() + " inches";
        }

        public string displayDrawers()
        {
            return drawers.ToString();
        }

        public string displayMaterial()
        {
            return surfaceMaterial;
        }

        //public string readFromJSON()
        //{
        //    // convert into list from JSON file
        //    List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonFile.ReadAllText(jsonFile));

        //    Console.WriteLine(json);
        //    return List < DeskQuote > deskQuotes;
        //}

//        public void writeToJSON()
//        {
//            Create list for saved quotes
//            public static List<DeskQuote> savedQuotes = new List<DeskQuote>();

//        serialize JSON directly to a file
//            using (StreamWriter file = File.CreateText())
//            {
//                JsonSerializer serializer = new JsonSerializer();
//    serializer.Serialize(file, this);
//    }
//}

// internal static void SaveDeskQuote(DeskQuote deskQuote)
//{
//    // collect data from JSON file            
//    //string json = deskQuote.readFromJSON();

//    // Convert JSON into list of desk quote objects
//    //List<DeskQuote> deskQuotes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DeskQuote>>(json);

//    // add new deskQuote to list

//    // write list to JSON file
//    deskQuote.writeToJSON(deskQuote);
//}

public string displayRushDays()
        {
            return rushDays.ToString() + " days";
        }

        public string displayQuoteDate()
        {
            return quoteDate.ToString("MM/dd/yyyy");
        }

        public string displayQuoteTotal()
        {
            return "$" + quoteTotal.ToString();
        }

        public string displayCustomerName()
        {
            return customerFirstName + " " + customerLastName;
        }

        public string displayQuote()
        {
            // Create string to pass to Display Quote form
            string quote = "";
            //    $"Customer: {customerName} - Date of Quote: {quoteDate}\nDesk Width: {width}\nDesk Depth: {depth}\n"
            //    + $"Surface Area: {calcSurfaceArea()}\nSurface Material: {surfaceMaterial}\nNumber of Drawers: {drawers}\n"
            //    + $"Rush Days: {rushDays}\nTotal Price for Desk: ${quoteTotal}";
            return quote;
        }
    }
}