using Microsoft.EntityFrameworkCore;
using TheatricalPlayersRefactoringKata.Domain.Model;

namespace TheatricalPlayersRefactoringKata.Info;

public class DbConfig : DbContext
{
    public DbSet<Play> Play { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<Performance> Performances { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<PlayType> PlayTypes { get; set; }
   
    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        =>optionBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=postgres"); 
}