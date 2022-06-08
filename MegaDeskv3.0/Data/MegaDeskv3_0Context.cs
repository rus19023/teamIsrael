using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDeskv3._0.Models;

namespace MegaDeskv3._0.Data
{
    public class MegaDeskv3_0Context : DbContext
    {
        public MegaDeskv3_0Context (DbContextOptions<MegaDeskv3_0Context> options)
            : base(options)
        {
        }

        public DbSet<MegaDeskv3._0.Models.DeskQuote> DeskQuote { get; set; }
    }
}
