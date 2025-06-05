using System.ComponentModel.DataAnnotations;

namespace LendIT.Models.Entities;

public class PozycjaKoszyka
{
    [Key]
    [Required]
    private int Id { get; set; }

    [Required]
    private Sprzet Sprzet { get; set; }

    [Required]
    private int SprzetId { get; set; }

    [Required]
    private int Ilosc { get; set; }

    [Required]
    private Koszyk Koszyk { get; set; }

    [Required]
    private int KoszykId { get; set; }
}