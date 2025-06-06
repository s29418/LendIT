using System.ComponentModel.DataAnnotations;

namespace LendIT.Models.Entities;

public class Zwrot
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public DateTime DataZgloszenia { get; set; }

    public DateTime? DataOdbioru { get; set; }

    public string? KomentarzAdministratora { get; set; }

    [Required]
    public Wypozyczenie Wypozyczenie { get; set; }

    [Required]
    public int WypozyczenieId { get; set; }

    [Required]
    public Adres Adres { get; set; }

    [Required]
    public int AdresId { get; set; }

    [Required]
    public EtykietaZwrotna EtykietaZwrotna { get; set; }

    [Required]
    public int EtykietaZwrotnaId { get; set; }

    public void ZarejestrujZwrot(Wypozyczenie wypozyczenie, string metodaZwrotu)
    {
        throw new NotImplementedException();
    }
}