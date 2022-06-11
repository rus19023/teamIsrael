using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDeskv3._0.Data;
using MegaDeskv3._0.Models;

namespace MegaDeskv3._0.Pages.DeskQuotes
{
    public class CreateModel : PageModel
    {
        private readonly MegaDeskv3._0.Data.MegaDeskv3_0Context _context;

        public CreateModel(MegaDeskv3._0.Data.MegaDeskv3_0Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {

                        return Page();
        }

        [BindProperty]
        public string MaterialSelected { get; set; } 

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }



        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            //automatically sets date to current date
            DeskQuote.quoteDate = DateTime.Today;
            DeskQuote.surfaceMaterial = MaterialSelected;

            //generates quote total from form data
            DeskQuote.quoteTotal = DeskQuote.getQuoteTotal(DeskQuote);

            _context.DeskQuote.Add(DeskQuote);
            await _context.SaveChangesAsync();

            //return RedirectToPage("/Details", "Edit", new { id = DeskQuote.Id});

            return RedirectToPage("./Details", new { id = DeskQuote.Id });


        }
    }
}
