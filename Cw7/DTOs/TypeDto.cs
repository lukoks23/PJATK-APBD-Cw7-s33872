using System.ComponentModel.DataAnnotations;

namespace Cw7.DTOs;

public record TypeDto(
    [Required]
    int id,
    [Required]
    [MaxLength(30)]
    string abbreviation,
    [Required]
    [MaxLength(150)]
    string name
);