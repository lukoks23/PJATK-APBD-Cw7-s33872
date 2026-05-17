namespace Cw7.DTOs;

public record ComponentDto(
    string code,
    string name,
    string description,
    ManufacturerDto manufacturer,
    TypeDto type
);