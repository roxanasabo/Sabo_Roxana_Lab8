using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sabo_Roxana_Lab8.Models;

namespace Sabo_Roxana_Lab8.Data
{
    public class Sabo_Roxana_Lab8Context : DbContext
    {
        public Sabo_Roxana_Lab8Context (DbContextOptions<Sabo_Roxana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Sabo_Roxana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Sabo_Roxana_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Sabo_Roxana_Lab8.Models.Category> Category { get; set; }
    }
}
