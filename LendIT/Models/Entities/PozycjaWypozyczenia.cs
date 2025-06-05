using System.ComponentModel.DataAnnotations;

namespace LendIT.Models.Entities;

public class PozycjaWypozyczenia
{
    [Key]
    [Required]
    private int Id { get; set; }

    [Required]
    private int Ilosc { get; set; }

    [Required]
    private Sprzet Sprzet { get; set; }

    [Required]
    private int SprzetId { get; set; }

    [Required]
    private Wypozyczenie Wypozyczenie { get; set; }

    [Required]
    private int WypozyczenieId { get; set; }
}