using FourCreate.ClinicalTrials.Infrastructure.Entities;
using FourCreate.ClinicalTrials.Infrastructure.Repositories;

namespace FourCreate.ClinicalTrials.Domain.Services;

public class ClinicalTrialsSerivce(ICLinicalTrialsRepository repository) : IClinicalTrialsSerivce
{
    public Task<CLinicalTrial?> Get(CancellationToken ct)
        => repository.Get(ct);

    public Task Create(CancellationToken ct)
        => repository.Create(ct);
}

public interface IClinicalTrialsSerivce
{
    Task<CLinicalTrial?> Get(CancellationToken ct);
    Task Create(CancellationToken ct);
}
