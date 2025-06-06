using System.ComponentModel.DataAnnotations;

namespace LendIT.Models.Entities;

public class Klient : Uzytkownik
{
    [Required]
    public string NrTelefonu { get; set; }

    [Required]
    public List<Adres> Adresy { get; set; } = new();

    [Required]
    public Koszyk Koszyk { get; set; }
    

    public List<Wypozyczenie> Wypozyczenia { get; set; } = new();


    public override void ZarzadzajKontem(string[] noweDane)
    {
        throw new NotImplementedException();
    }

    public void DodajAdres(Adres adres)
    {
        throw new NotImplementedException();
    }

    public void DodajDoKoszyka(Sprzet sprzet, int ilosc)
    {
        throw new NotImplementedException();
    }

    public void UsunZKoszyka(PozycjaKoszyka pozycja)
    {
        throw new NotImplementedException();
    }

    public void WypozyczSprzet(Sprzet sprzet, int ilosc)
    {
        throw new NotImplementedException();
    }

    public void PrzegladajHistorieWypozyczen()
    {
        throw new NotImplementedException();
    }

    public void OplacWypozyczenie(Platnosc platnosc)
    {
        throw new NotImplementedException();
    }

    public void DodajRecenzje(Sprzet sprzet, int ocena, string? komentarz)
    {
        throw new NotImplementedException();
    }

    public void StworzWypozyczenieZKoszyka(DateTime terminOd, DateTime terminDo)
    {
        if (Koszyk == null || !Koszyk.Pozycje.Any())
            throw new InvalidOperationException("Koszyk jest pusty.");

        var noweWypozyczenie = new Wypozyczenie
        (
            dataOd: terminOd,
            dataDo: terminDo
        );

        foreach (var pozycja in Koszyk.Pozycje)
        {
            var sprzet = pozycja.Sprzet;

            if (!sprzet.SprawdzDostepnosc(terminOd, terminDo))
                throw new InvalidOperationException($"Sprzęt '{sprzet.Nazwa}' jest niedostępny w wybranym terminie.");

            var pozycjaWyp = new PozycjaWypozyczenia
            (
                sprzet,
                pozycja.Ilosc,
                noweWypozyczenie
            );

            noweWypozyczenie.DodajPozycje(pozycjaWyp);
        }

        Wypozyczenia.Add(noweWypozyczenie);
        Koszyk.Pozycje.Clear();
    }

}