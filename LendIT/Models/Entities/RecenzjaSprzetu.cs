using System.ComponentModel.DataAnnotations;

namespace LendIT.Models.Entities;

public class RecenzjaSprzetu
{
    [Key]
    [Required]
    private int Id { get; set; }

    [Required]
    [Range(1, 5)]
    private int Ocena { get; set; }

    private string? Komentarz { get; set; }

    [Required]
    private DateTime DataDodania { get; set; }

    [Required]
    private Sprzet Sprzet { get; set; }

    [Required]
    private int SprzetId { get; set; }
}