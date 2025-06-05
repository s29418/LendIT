using System.ComponentModel.DataAnnotations;

namespace LendIT.Models.Entities;

public class Zwrot
{
    [Key]
    [Required]
    private int Id { get; set; }

    [Required]
    private DateTime DataZgloszenia { get; set; }

    private DateTime? DataOdbioru { get; set; }

    private string? KomentarzAdministratora { get; set; }

    [Required]
    private Wypozyczenie Wypozyczenie { get; set; }

    [Required]
    private int WypozyczenieId { get; set; }

    [Required]
    private Adres Adres { get; set; }

    [Required]
    private int AdresId { get; set; }

    [Required]
    private EtykietaZwrotna EtykietaZwrotna { get; set; }

    [Required]
    private int EtykietaZwrotnaId { get; set; }

    public void ZarejestrujZwrot(Wypozyczenie wypozyczenie, string metodaZwrotu)
    {
        throw new NotImplementedException();
    }
}