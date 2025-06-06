using System.ComponentModel.DataAnnotations;

namespace LendIT.Models.Entities;

public class PozycjaKoszyka
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public Sprzet Sprzet { get; set; }

    [Required]
    public int SprzetId { get; set; }

    [Required]
    public int Ilosc { get; set; }

    [Required]
    public Koszyk Koszyk { get; set; }

    [Required]
    public int KoszykId { get; set; }
}