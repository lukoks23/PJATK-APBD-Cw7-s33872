using Cw7.DTOs;
using Cw7.Infrastructure;
using Cw7.Models;
using Microsoft.EntityFrameworkCore;

namespace Cw7.Service;

public class ComputerService(DatabaseContext ctx) : IComputerService
{
    public async Task<IEnumerable<PCDto>> GetPCsAsync(CancellationToken cancellationToken)
    {
        return await ctx.PCs.Select(pc => new PCDto(
            pc.Id,
            pc.Name,
            pc.Stock,
            pc.Warranty,
            pc.CreatedAt,
            pc.Warranty
        )).ToListAsync(cancellationToken);
    }

    public async Task<PCComponentsResponseDto?> GetPcComponentsAsync(int id, CancellationToken cancellationToken)
    {
        return await ctx.PCs.Where(pc => pc.Id == id).Select(pc => new PCComponentsResponseDto(
            pc.Id,
            pc.Name,
            pc.Weight,
            pc.Warranty,
            pc.CreatedAt,
            pc.Stock, 
            pc.PCcomponents.Select(comp => new PCComponentsDto(
                comp.Amount,
                new ComponentDto(
                    comp.Component.Code,
                    comp.Component.Name,
                    comp.Component.Description,
                    new ManufacturerDto(
                        comp.Component.ComponentManufacturer.Id,
                        comp.Component.ComponentManufacturer.Abrreviation,
                        comp.Component.ComponentManufacturer.FullName,
                        comp.Component.ComponentManufacturer.FoundationDate
                    ),
                    new TypeDto(
                        comp.Component.ComponentType.Id,
                        comp.Component.ComponentType.Abbreviation,
                        comp.Component.ComponentType.Name
                    )
                )
            )).ToList()
        )).FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<PCDto> CreatePCAsync(CreatePcDto pc, CancellationToken cancellationToken)
    {
        var PC = new PC
        {
            Name = pc.name,
            Stock = pc.stock,
            CreatedAt = pc.createdAt,
            Warranty = pc.warranty,
            Weight = pc.weight
        };
        
        await ctx.AddAsync(PC,cancellationToken);
        await ctx.SaveChangesAsync(cancellationToken);
        return new PCDto(PC.Id,PC.Name,PC.Weight,PC.Warranty,PC.CreatedAt,PC.Stock);
    }
}