using System.Collections.Generic;
using DevoxxBooksApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DevoxxBooksApi
{
    public class BookDataContext : DbContext
    {
        public DbSet<BookModel> Books {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./devoxxbooksapi.sqlite");
        }
    }
}