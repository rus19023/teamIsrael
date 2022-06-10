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
    public class IndexModel : PageModel
    {
        private readonly MegaDeskv3._0.Data.MegaDeskv3_0Context _context;

        public IndexModel(MegaDeskv3._0.Data.MegaDeskv3_0Context context)
        {
            _context = context;
        }

        public string firstNameSort { get; set; }
        public string dateSort { get; set; }
        public string currentFilter { get; set; }
        public IList<DeskQuote> DeskQuote { get;set; }

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            firstNameSort = sortOrder == "firstName_asc" ? "firstName_desc" : "firstName_asc";
            dateSort = sortOrder == "date_asc" ? "date_desc" : "date_asc";
            currentFilter = searchString;

            IQueryable<DeskQuote> deskQuoteIQ = from dq in _context.DeskQuote
                                                select dq;

            if (!String.IsNullOrEmpty(searchString))
            {
                deskQuoteIQ = deskQuoteIQ.Where(dq => dq.customerFirstName.Contains(searchString)
                                                      || dq.customerLastName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "firstName_asc":
                    deskQuoteIQ = deskQuoteIQ.OrderBy(dq => dq.customerFirstName);
                    break;
                case "firstName_desc":
                    deskQuoteIQ = deskQuoteIQ.OrderByDescending(dq => dq.customerFirstName);
                    break;
                case "date_asc":
                    deskQuoteIQ = deskQuoteIQ.OrderBy(dq => dq.quoteDate);
                    break;
                case "date_desc":
                    deskQuoteIQ = deskQuoteIQ.OrderByDescending(dq => dq.quoteDate);
                    break;
            }

            DeskQuote = await deskQuoteIQ.AsNoTracking().ToListAsync();
        }
    }
}
