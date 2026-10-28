using C48_G01_EF01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C48_G01_EF01
{
    public class AppDbContext: DbContext
    {

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer( @"Server=(localdb)\MSSQLLocalDB;Database=ReadMoreBooksDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
