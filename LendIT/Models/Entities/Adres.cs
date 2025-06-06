using System.ComponentModel.DataAnnotations;

namespace LendIT.Models.Entities;

public class Adres
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public string Ulica { get; set; }

    [Required]
    public string NumerDomu { get; set; }

    [Required]
    public string Miasto { get; set; }

    [Required]
    public string KodPocztowy { get; set; }

    [Required]
    public Klient Klient { get; set; }

    [Required]
    public int KlientId { get; set; }
    
    public List<Zwrot> Zwroty { get; set; } = new();
}