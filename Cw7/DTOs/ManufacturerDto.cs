using System.ComponentModel.DataAnnotations;

namespace Cw7.DTOs;

public record ManufacturerDto(
    [Required]
    int id,
    [Required]
    [MaxLength(30)]
    string abbreviation,
    [Required]
    [MaxLength(300)]
    string fullName,
    [Required]
    DateTime foundationDate);