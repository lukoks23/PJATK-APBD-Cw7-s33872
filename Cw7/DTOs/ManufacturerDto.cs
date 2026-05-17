namespace Cw7.DTOs;

public record ManufacturerDto(
    int id,
    string abbreviation,
    string fullName,
    DateTime foundationDate);