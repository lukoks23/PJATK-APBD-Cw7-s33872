using Cw7.DTOs;
using Cw7.Models;
using Cw7.Service;
using Microsoft.AspNetCore.Mvc;

namespace Cw7.Controllers;

[ApiController]
[Route("api/pcs")]
public class PCsController(IComputerService service) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        return Ok(await service.GetPCsAsync(cancellationToken));
    }

    [HttpGet("{id:int}/components")]
    public async Task<IActionResult> GetComponents(int id, CancellationToken cancellationToken)
    {
        var componentsDto = await service.GetPcComponentsAsync(id, cancellationToken);
        if (componentsDto is null)
        {
            return NotFound();
        }
        return Ok(componentsDto);
    }

    [HttpPost]
    public async Task<IActionResult> CreatePC([FromBody] CreatePcDto pc, CancellationToken cancellationToken)
    {
        return Created("Added pc",service.CreatePCAsync(pc,cancellationToken));
    }
}