using FourCreate.ClinicalTrials.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using FourCreate.ClinicalTrials.Infrastructure.Builders;

namespace FourCreate.ClinicalTrials.Infrastructure;

public class ClinicalTrialsContext : DbContext
{
    public ClinicalTrialsContext(DbContextOptions opts) : base(opts) { }
    
    public DbSet<CLinicalTrial> CLinicalTrials { get; set; }

    private const string ConnectionString =
        "Host=localhost;Port=5432;Database=FourCreateDatabase;Username=FourCreate-user;Password=Four-4!Create_Password*);";

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Builder.BuildClinicalTrials(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
            .UseNpgsql(ConnectionString);
}
