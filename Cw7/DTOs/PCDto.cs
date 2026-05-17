using System.ComponentModel.DataAnnotations;

namespace Cw7.DTOs;

public record PCDto
(
    [Required]
    int Id,
    [Required]
    [MaxLength(50)]
    string Name,
    [Required]
    decimal Weight,
    [Required]
    int Warranty,
    [Required]
    DateTime CreatedAt,
    [Required]
    int Stock
);