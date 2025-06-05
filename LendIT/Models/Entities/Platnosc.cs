using System.ComponentModel.DataAnnotations;
using LendIT.Models.Enums;

namespace LendIT.Models.Entities;

public class Platnosc
{
    [Key]
    [Required]
    private int Id { get; set; }

    [Required]
    private float Kwota { get; set; }

    [Required]
    private StatusPlatnosci StatusPlatnosci { get; set; }

    [Required]
    private Klient Klient { get; set; }

    [Required]
    private int KlientId { get; set; }

    [Required]
    private Wypozyczenie Wypozyczenie { get; set; }

    [Required]
    private int WypozyczenieId { get; set; }

    public void PrzetworzPlatnosc(Wypozyczenie wypozyczenie)
    {
        throw new NotImplementedException();
    }
}