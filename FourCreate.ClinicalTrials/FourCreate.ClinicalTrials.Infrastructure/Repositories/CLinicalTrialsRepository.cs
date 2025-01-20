using FourCreate.ClinicalTrials.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace FourCreate.ClinicalTrials.Infrastructure.Repositories;

/// ctor
public class CLinicalTrialsRepository(ClinicalTrialsContext context) : ICLinicalTrialsRepository
{
    public async Task<CLinicalTrial?> Get(CancellationToken ct)
    {
        return await context.CLinicalTrials
            .AsNoTracking()
            .FirstOrDefaultAsync(ct);
    }

    public async Task Create(CancellationToken ct)
    {
        var id = Guid.NewGuid();
        var txt = $"{id} test clinical trial item";
        var entity = new CLinicalTrial
        {
            Id = id,
            Title = txt,
            CreatedAt = DateTime.UtcNow,
            StartDate = DateTime.UtcNow,
            EndDate = DateTime.UtcNow.AddMonths(1),
            TrialId = txt,
        };

        await context.CLinicalTrials.AddAsync(entity, ct);
        await context.SaveChangesAsync(ct);
    }
}

public interface ICLinicalTrialsRepository
{
    Task<CLinicalTrial?> Get(CancellationToken ct);

    Task Create(CancellationToken ct);
}