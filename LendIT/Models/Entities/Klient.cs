using System.ComponentModel.DataAnnotations;

namespace LendIT.Models.Entities;

public class Klient : Uzytkownik
{
    [Required]
    private string NrTelefonu { get; set; }

    [Required]
    private List<Adres> Adresy { get; set; } = new();

    [Required]
    private Koszyk Koszyk { get; set; }

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

    public void StworzWypozyczenieZKoszyka()
    {
        throw new NotImplementedException();
    }
}