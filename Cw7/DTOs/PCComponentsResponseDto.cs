namespace Cw7.DTOs;

public record PCComponentsResponseDto(
    int id,
    string name,
    decimal weight,
    int warranty,
    DateTime createdAt,
    int stock,
    IEnumerable<PCComponentsDto> components
);