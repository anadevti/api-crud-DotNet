using Microsoft.EntityFrameworkCore;
using MyApiV2.Studants;

namespace MyApiV2.Data;

public class AppDbContext : DbContext
{
    private DbSet<Studant> Studants { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(connectionString:"Data Source=app.db");
        
        base.OnConfiguring(optionsBuilder);
    }
}