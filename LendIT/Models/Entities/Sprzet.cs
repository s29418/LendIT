using System.ComponentModel.DataAnnotations;
using LendIT.Models.Enums;
using LendIT.Models.ValueObjects;

namespace LendIT.Models.Entities;

public class Sprzet
{
    [Required]
    public int SerialNumber { get; set; }

    [Required]
    public string Nazwa { get; set; }

    [Required]
    public decimal Cena { get; set; }

    [Required]
    public decimal Kaucja { get; set; }

    [Required]
    public string Opis { get; set; }

    [Required]
    public StatusSprzetu Status { get; set; }

    [Required]
    public Wymiary Wymiary { get; set; }

    [Required]
    public static int LiczbaWszystkichSprzetow { get; set; }

    public List<KategoriaSprzetu> Kategorie { get; set; } = new();

    public List<ZdjecieSprzetu> Zdjecia { get; set; } = new();

    public List<RecenzjaSprzetu> Recenzje { get; set; } = new();
    
    public List<PozycjaWypozyczenia> PozycjeWypozyczenia { get; set; } = new();

    public Sprzet()
    {
        LiczbaWszystkichSprzetow++;
    }

    public bool SprawdzDostepnosc(DateTime terminOd, DateTime terminDo)
    {
        foreach (var pozycja in PozycjeWypozyczenia)
        {
            var wypozyczenie = pozycja.Wypozyczenie;
            
            if (wypozyczenie.Status == StatusWypozyczenia.Zwrocone ||
                wypozyczenie.Status == StatusWypozyczenia.Anulowane)
                continue;
            
            bool nakladanie = terminOd < wypozyczenie.DataZakonczenia &&
                              terminDo > wypozyczenie.DataWypozyczenia;

            if (nakladanie)
                return false;
        }

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