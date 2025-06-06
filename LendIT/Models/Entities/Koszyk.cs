using System.ComponentModel.DataAnnotations;

namespace LendIT.Models.Entities;

public class Koszyk
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public Klient Klient { get; set; }

    [Required]
    public int KlientId { get; set; }

    [Required]
    public List<PozycjaKoszyka> Pozycje { get; set; } = new();
}