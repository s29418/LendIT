using System.ComponentModel.DataAnnotations;

namespace LendIT.Models.Entities;

public class Adres
{
    [Key]
    [Required]
    private int Id { get; set; }

    [Required]
    private string Ulica { get; set; }

    [Required]
    private string NumerDomu { get; set; }

    [Required]
    private string Miasto { get; set; }

    [Required]
    private string KodPocztowy { get; set; }

    [Required]
    private Klient Klient { get; set; }

    [Required]
    private int KlientId { get; set; }
}