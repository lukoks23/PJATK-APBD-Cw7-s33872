namespace Cw7.DTOs;

public record PCDto
(
    int Id,
    string Name,
    decimal Weight,
    int Warranty,
    DateTime CreatedAt,
    int Stock
);