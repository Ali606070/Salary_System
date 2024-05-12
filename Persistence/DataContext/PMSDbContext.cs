using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DataContext
{
    public class PMSDbContext:DbContext
    {
        public PMSDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {

        }
        public DbSet<TaxBracket> SC_Brackets { get; set; }

    }
}
