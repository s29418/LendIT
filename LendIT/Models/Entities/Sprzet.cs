using System.ComponentModel.DataAnnotations;
using LendIT.Models.Enums;
using LendIT.Models.ValueObjects;

namespace LendIT.Models.Entities;

public class Sprzet
{
    [Required]
    private int SerialNumber { get; set; }

    [Required]
    private string Nazwa { get; set; }

    [Required]
    private decimal Cena { get; set; }

    [Required]
    private decimal Kaucja { get; set; }

    [Required]
    private string Opis { get; set; }

    [Required]
    private StatusSprzetu Status { get; set; }

    [Required]
    private Wymiary Wymiary { get; set; }

    [Required]
    private static int LiczbaWszystkichSprzetow { get; set; }

    private List<KategoriaSprzetu> Kategorie { get; set; } = new();

    private List<ZdjecieSprzetu> Zdjecia { get; set; } = new();

    private List<RecenzjaSprzetu> Recenzje { get; set; } = new();

    public Sprzet()
    {
        LiczbaWszystkichSprzetow++;
    }

    public bool SprawdzDostepnosc(DateTime terminOd, DateTime terminDo)
    {
        return true;
    }

    public static int PodajLiczbeSprzetuDlaKategorii(KategoriaSprzetu kategoria)
    {
        throw new NotImplementedException();
    }

    public static int PodajLiczbeSprzetuDlaKategorii(string nazwaKategorii)
    {
        throw new NotImplementedException();
    }
}