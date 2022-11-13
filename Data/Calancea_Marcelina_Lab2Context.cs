using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Calancea_Marcelina_Lab2.Models;

namespace Calancea_Marcelina_Lab2.Data
{
    public class Calancea_Marcelina_Lab2Context : DbContext
    {
        public Calancea_Marcelina_Lab2Context (DbContextOptions<Calancea_Marcelina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Calancea_Marcelina_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Calancea_Marcelina_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Calancea_Marcelina_Lab2.Models.Category> Category { get; set; }

        public DbSet<Calancea_Marcelina_Lab2.Models.Author> Author { get; set; }
    }
}
