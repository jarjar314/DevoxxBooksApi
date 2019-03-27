using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DevoxxBooksApi
{
    public class BookDataContext : DbContext
    {
        //à créer un DbSet de votre model

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./devoxxbooksapi.sqlite");
        }
    }
}