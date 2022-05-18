﻿using System;

namespace MegaDeskV1._0_Rush_Lopez
{
    public class DeskQuote : Desk
    {
        // todo: are these properties, members, fields or variables? or something else?
        private string customerFirstName { get; set; }
        private string customerLastName { get; set; }
        private string customerName { get; set; }
        private int rushDays { get; set; }
        private DateTime quoteDate { get; set; }
        private int totalPrice { get; set; }

        // todo: is this a constructor? Why does the top part have total and date, but not here?
        public DeskQuote(int width, int depth, int drawers, string surfaceMaterial, int rushDays, string customerFirstName, string customerLastName) :
            base(width, depth, drawers, surfaceMaterial)
        {
            this.rushDays = rushDays;
            this.customerFirstName = customerFirstName;
            this.customerLastName = customerLastName;
            this.totalPrice = getTotalPrice();
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

        public int getTotalPrice()
        {
            totalPrice = calcAreaPrice() + calcDrawerPrice() + calcMaterialPrice() + calcRushPrice();
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
            return "$" + totalPrice.ToString();
        }

        public string displayCustomerName()
        {
            return customerFirstName + " " + customerLastName;
        }

        public string displayQuote()
        {
            // Create string to pass to Display Quote form
            string quote =
                $"Customer: {customerName} - Date of Quote: {quoteDate}\nDesk Width: {width}\nDesk Depth: {depth}\n"
                + $"Surface Area: {calcSurfaceArea()}\nSurface Material: {surfaceMaterial}\nNumber of Drawers: {drawers}\n"
                + $"Rush Days: {rushDays}\nTotal Price for Desk: ${totalPrice}";
            return quote;
        }
    }
}