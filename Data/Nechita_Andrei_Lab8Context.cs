using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nechita_Andrei_Lab8.Models;

namespace Nechita_Andrei_Lab8.Data
{
    public class Nechita_Andrei_Lab8Context : DbContext
    {
        public Nechita_Andrei_Lab8Context (DbContextOptions<Nechita_Andrei_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Nechita_Andrei_Lab8.Models.Book> Book { get; set; }

        public DbSet<Nechita_Andrei_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Nechita_Andrei_Lab8.Models.Category> Category { get; set; }
    }
}
