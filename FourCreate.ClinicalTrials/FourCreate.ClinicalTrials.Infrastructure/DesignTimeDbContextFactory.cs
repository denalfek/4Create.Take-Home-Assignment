using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FourCreate.ClinicalTrials.Infrastructure;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ClinicalTrialsContext>
{
    public ClinicalTrialsContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ClinicalTrialsContext>();
        return new ClinicalTrialsContext(optionsBuilder.Options);
    }
}
