using System.ComponentModel.DataAnnotations;

namespace Cw7.DTOs;

public record CreatePcDto(
    [Required]
    [MaxLength(50)]
    string name,
    [Required]
    decimal weight,
    [Required]
    int warranty,
    [Required]
    DateTime createdAt,
    [Required]
    int stock
);