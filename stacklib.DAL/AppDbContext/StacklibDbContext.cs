using Microsoft.EntityFrameworkCore;
using stacklib.DAL.Entities;

namespace stacklib.DAL.AppDbContext;

public class StacklibDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=ACCESS-8F7NRQ3;Database=StacklibDB;Trusted_Connection=True;");
    }
}