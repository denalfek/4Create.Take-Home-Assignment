using FourCreate.ClinicalTrials.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace FourCreate.ClinicalTrials.Infrastructure.Builders;

public partial class Builder
{
    public static void BuildClinicalTrials(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CLinicalTrial>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity
                .Property(e => e.Id);
            
            entity.Property(e => e.TrialId)
                .HasColumnType("char(60)")
                .IsRequired();
            
            entity
                .Property(e => e.Title)
                .HasColumnType("varchar(32)")
                .IsRequired();

            entity
                .Property(e => e.StartDate)
                .HasColumnType("timestamp with time zone");

            entity
                .Property(e => e.EndDate)
                .HasColumnType("timestamp with time zone");

            entity
                .Property(e => e.CreatedAt)
                .HasColumnType("timestamp with time zone")
                .IsRequired()
                .HasDefaultValueSql("now()");
        });
    }
}
