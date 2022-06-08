using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskv3._0.Data;
using MegaDeskv3._0.Models;

namespace MegaDeskv3._0.Pages.DeskQuotes
{
    public class DetailsModel : PageModel
    {
        private readonly MegaDeskv3._0.Data.MegaDeskv3_0Context _context;

        public DetailsModel(MegaDeskv3._0.Data.MegaDeskv3_0Context context)
        {
            _context = context;
        }

        public DeskQuote DeskQuote { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DeskQuote = await _context.DeskQuote.FirstOrDefaultAsync(m => m.Id == id);

            if (DeskQuote == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
