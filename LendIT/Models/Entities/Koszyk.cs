using System.ComponentModel.DataAnnotations;

namespace LendIT.Models.Entities;

public class Koszyk
{
    [Key]
    [Required]
    private int Id { get; set; }

    [Required]
    private Klient Klient { get; set; }

    [Required]
    private int KlientId { get; set; }

    [Required]
    private List<PozycjaKoszyka> Pozycje { get; set; } = new();
}