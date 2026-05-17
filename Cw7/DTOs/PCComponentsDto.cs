using System.ComponentModel.DataAnnotations;

namespace Cw7.DTOs;

public record PCComponentsDto(
    [Required]
    int amount,
    [Required]
    ComponentDto component
);