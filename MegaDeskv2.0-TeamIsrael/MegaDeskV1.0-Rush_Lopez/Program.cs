using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MegaDeskV1._0_Rush_Lopez
{
        internal static class Program
        {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        // Initialize list for saved quotes
        public static List<DeskQuote> savedQuotes = new List<DeskQuote>();
        

        [STAThread]
                static void Main()
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MegaDeskMainMenu());
                }            
        }
}
