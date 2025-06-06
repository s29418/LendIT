using System.ComponentModel.DataAnnotations;

namespace LendIT.Models.Entities;

public class RecenzjaSprzetu
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    [Range(1, 5)]
    public int Ocena { get; set; }

    public string? Komentarz { get; set; }

    [Required]
    public DateTime DataDodania { get; set; }

    [Required]
    public Sprzet Sprzet { get; set; }

    [Required]
    public int SprzetId { get; set; }
}