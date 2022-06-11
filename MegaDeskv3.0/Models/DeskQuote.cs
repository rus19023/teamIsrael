using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MegaDeskv3._0.Models
{
    public class DeskQuote
    {
        //properties of the DeskQuote model
        public int Id { get; set; }

        [Required(ErrorMessage = "Width must be specified")]
        [Range(24, 96, ErrorMessage = "Please enter a width from 24 to 96 inches")]
        [DisplayName("Width")]
        public int width { get; set; }

        [Required(ErrorMessage = "Depth must be specified")]
        [Range(12, 48, ErrorMessage = "Please enter a depth from 12 to 48 inches")]
        [DisplayName("Depth")]
        public int depth { get; set; }

        [DisplayName("Drawers")]
        public int drawers { get; set; }

        [Required(ErrorMessage = "Material must be specified")]
        [DisplayName("Material")]
        public string surfaceMaterial { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [DisplayName("First Name")]
        public string customerFirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [DisplayName("Last Name")]
        public string customerLastName { get; set; }

        [DisplayName("Rush Days")]
        public int rushDays { get; set; }


        [DisplayName("Date")]
        [DataType(DataType.Date)]
        public DateTime quoteDate { get; set; }
        [DisplayName("Price")]
        public int quoteTotal { get; set; }

        public int calcSurfaceArea(int depth, int width)
        {
            return width * depth;
        }

        public int calcRushPrice(int rushDays, int depth, int width)
        {
            int surfaceArea = calcSurfaceArea(depth, width);
            int rushPrice;
            int[,] rushPrices = getRushOrder();
            if (rushPrices == null)
            {
                return 0;
            }


            switch (rushDays)
            {
                case 3:
                    if (surfaceArea < 1000) rushPrice = rushPrices[0, 0];
                    else if (surfaceArea <= 2000) rushPrice = rushPrices[0, 1];
                    else rushPrice = rushPrices[0, 2];
                    break;
                case 5:
                    if (surfaceArea < 1000) rushPrice = rushPrices[1, 0];
                    else if (surfaceArea <= 2000) rushPrice = rushPrices[1, 1];
                    else rushPrice = rushPrices[1, 2];
                    break;
                case 7:
                    if (surfaceArea < 1000) rushPrice = rushPrices[2, 0];
                    else if (surfaceArea <= 2000) rushPrice = rushPrices[2, 1];
                    else rushPrice = rushPrices[2, 2];
                    break;
                default:
                    rushPrice = 0;
                    break;
            }
            return rushPrice;
        }

        public int[,] getRushOrder()
        {
            int[,] rushPrices = new int[3, 3];
            rushPrices[0, 0] = 60;
            rushPrices[0, 1] = 70;
            rushPrices[0, 2] = 80;
            rushPrices[1, 0] = 40;
            rushPrices[1, 1] = 50;
            rushPrices[1, 2] = 60;
            rushPrices[2, 0] = 30;
            rushPrices[2, 1] = 35;
            rushPrices[2, 2] = 40;
            return rushPrices;
        }

        public int calcDrawerPrice(int drawers)
        {
            return 50 * drawers;
        }

        public int calcAreaPrice(int width, int depth)
        {
            int surfaceArea = calcSurfaceArea(width, depth);
            if (surfaceArea > 1000)
            {
                return 200 + (surfaceArea - 1000);
            }
            else
            {
                return 200;
            }
        }

        public int calcMaterialPrice(string material)
        {
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

        

        public int getQuoteTotal(DeskQuote deskQuote)
        {
            int totalPrice = calcAreaPrice(deskQuote.width, deskQuote.depth) + calcDrawerPrice(deskQuote.drawers) + calcMaterialPrice(deskQuote.surfaceMaterial) + calcRushPrice(deskQuote.rushDays, deskQuote.depth, deskQuote.width);
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

        //public string displayQuote()
        //{
        //    // Create string to pass to Display Quote form
        //    string quote =
        //        $"Customer: {customerFirstName} - Date of Quote: {quoteDate}\nDesk Width: {width}\nDesk Depth: {depth}\n"
        //        + $"Surface Area: {calcSurfaceArea()}\nSurface Material: {surfaceMaterial}\nNumber of Drawers: {drawers}\n"
        //        + $"Rush Days: {rushDays}\nTotal Price for Desk: ${quoteTotal}";
        //    return quote;
        //}
    }  // End class

    
}  // End namespace
