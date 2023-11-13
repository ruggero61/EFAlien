using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore;
using ConsoleApp1;
namespace ConsoleApp1.DataModel;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL(GlobalVars.connectionToDataBase);
    }
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
}