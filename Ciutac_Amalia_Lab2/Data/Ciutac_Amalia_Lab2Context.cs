using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ciutac_Amalia_Lab2.Models;

namespace Ciutac_Amalia_Lab2.Data
{
    public class Ciutac_Amalia_Lab2Context : DbContext
    {
        public Ciutac_Amalia_Lab2Context (DbContextOptions<Ciutac_Amalia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ciutac_Amalia_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
