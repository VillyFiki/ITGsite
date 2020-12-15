using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITGSite.Models.Manuals
{

    public class ManualContext : DbContext
    {
        public DbSet<Manual> Manuals { get; set; }
        public ManualContext(DbContextOptions<ManualContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
