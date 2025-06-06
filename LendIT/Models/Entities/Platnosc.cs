using System.ComponentModel.DataAnnotations;
using LendIT.Models.Enums;

namespace LendIT.Models.Entities;

public class Platnosc
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public float Kwota { get; set; }

    [Required]
    public StatusPlatnosci StatusPlatnosci { get; set; }

    [Required]
    public Klient Klient { get; set; }

    [Required]
    public int KlientId { get; set; }

    [Required]
    public Wypozyczenie Wypozyczenie { get; set; }

    [Required]
    public int WypozyczenieId { get; set; }

    public void PrzetworzPlatnosc(Wypozyczenie wypozyczenie)
    {
        throw new NotImplementedException();
    }
}