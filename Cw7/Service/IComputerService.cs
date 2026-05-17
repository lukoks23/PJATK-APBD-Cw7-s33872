using Cw7.DTOs;

namespace Cw7.Service;

public interface IComputerService
{
    Task<IEnumerable<PCDto>> GetPCsAsync(CancellationToken cancellationToken);
    Task<PCComponentsResponseDto?> GetPcComponentsAsync(int id, CancellationToken cancellationToken);
    Task<PCDto> CreatePCAsync(CreatePcDto pc, CancellationToken cancellationToken);
    Task PutPcAsync(CreatePcDto pc, int id, CancellationToken cancellationToken);
    Task DeletePcAsync(int id, CancellationToken cancellationToken);
}