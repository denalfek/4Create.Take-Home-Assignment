using FourCreate.ClinicalTrials.Domain.Services;
using FourCreate.ClinicalTrials.Infrastructure.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FourCreate.ClinicalTrials.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClinicalTrialsController(IClinicalTrialsSerivce serivce) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<CLinicalTrial>> GetFirst(CancellationToken ct = default)
    {
        var result = await serivce.Get(ct);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Post(CancellationToken ct = default)
    {
        await serivce.Create(ct);
        return Ok();
    }
}
