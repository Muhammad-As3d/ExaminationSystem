using ExaminationSystem.Application.Abstractions.Messaging;
using ExaminationSystem.Application.Features.Diplomas.Queries.GetAllDiplomas;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController(ISender sender) : ControllerBase
{
    [HttpGet("")]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var result = await sender.Send(new GetAllDiplomasQuery(), cancellationToken);

        return Ok(result);
    }
}
