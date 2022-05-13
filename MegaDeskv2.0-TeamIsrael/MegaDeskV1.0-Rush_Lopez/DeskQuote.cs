using System;

namespace MegaDeskV1._0_Rush_Lopez
{
    public class DeskQuote : Desk
    {
        private int rushDays;
        private string customerFirstName;
        private string customerLastName;
        private DateTime quoteDate;
        private int totalPrice;
        public DeskQuote(int width, int depth, int drawers, string surfaceMaterial, int rushDays, string customerFirstName, string customerLastName) :
            base(width, depth, drawers, surfaceMaterial)
        {
            this.rushDays = rushDays;
            this.customerFirstName = customerFirstName;
            this.customerLastName = customerLastName;
            quoteDate = DateTime.Today;
        }

        public int getRushDays()
        {
            return rushDays;
        }

        public void setRushDays(int rushDays)
        {
            this.rushDays = rushDays;
        }

        public string getCustomerFirstName()
        {
            return customerFirstName;
        }

        public void setCustomerFirstName(string customerFirstName)
        {
            this.customerFirstName = customerFirstName;
        }

        public string getCustomerLastName()
        {
            return customerLastName;
        }

        public void setCustomerLastName(string customerLastName)
        {
            this.customerLastName = customerLastName;
        }

        public DateTime getQuoteDate()
        {
            return quoteDate;
        }

        public void setQuoteDate(DateTime quoteDate)
        {
            this.quoteDate = quoteDate;
        }

        public int getTotalPrice()
        {
            return totalPrice;
        }

        public void setTotalPrice(int totalPrice)
        {
            this.totalPrice = totalPrice;
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
            return 50 * getDrawers();
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
            string material = getSurfaceMaterial();
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

        public void calcTotalPrice()
        {
            totalPrice = calcAreaPrice() + calcDrawerPrice() + calcMaterialPrice() + calcRushPrice();
        }

        public string displayQuote()
        {
            string quote =
                $"Customer: {customerFirstName} {customerLastName} - Date of Quote: {quoteDate}\nDesk Width: {getWidth()}\nDesk Depth: {getDepth()}\n"
                + $"Surface Area: {calcSurfaceArea()}\nSurface Material: {getSurfaceMaterial()}\nNumber of Drawers: {getDrawers()}\n"
                + $"Rush Days: {rushDays}\nTotal Price for Desk: ${totalPrice}";
            return quote;
        }
    }
}