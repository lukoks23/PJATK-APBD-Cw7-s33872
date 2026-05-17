using System.ComponentModel.DataAnnotations;

namespace Cw7.DTOs;

public record ComponentDto(
    [Required]
    [MaxLength(10)]
    [MinLength(10)]
    string code,
    [Required]
    [MaxLength(300)]
    string name,
    [Required]
    string description,
    [Required]
    ManufacturerDto manufacturer,
    [Required]
    TypeDto type
);