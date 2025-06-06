using System.ComponentModel.DataAnnotations;
using LendIT.Models.Enums;
using LendIT.Models.ValueObjects;

namespace LendIT.Models.Entities;

public class Administrator : Uzytkownik
{
    [Required]
    public string PoziomDostepu { get; set; }

    public override void ZarzadzajKontem(string[] noweDane)
    {
    //     if (noweDane.Length >= 2)
    //     {
    //         this.Imie = noweDane[0];
    //         this.Nazwisko = noweDane[1];
    //         
    //     }
    }

    public Sprzet DodajSprzet(string nazwa, string opis, decimal cena, decimal kaucja, StatusSprzetu status, Wymiary wymiary, List<KategoriaSprzetu> kategorie, List<string> zdjeciaUrl)
    {
        var sprzet = new Sprzet
        {
            Nazwa = nazwa,
            Opis = opis,
            Cena = cena,
            Kaucja = kaucja,
            Status = status,
            Wymiary = wymiary,
            Kategorie = kategorie,
            Zdjecia = zdjeciaUrl.Select(url => new ZdjecieSprzetu { Url = url }).ToList()
        };

        return sprzet;
    }

    public void EdytujSprzet(Sprzet sprzet, string nazwa, string opis, decimal cena, decimal kaucja)
    {
        sprzet.Nazwa = nazwa;
        sprzet.Opis = opis;
        sprzet.Cena = cena;
        sprzet.Kaucja = kaucja;
    }

    public void UsunSprzet(Sprzet sprzet)
    {
        sprzet.Status = StatusSprzetu.Niedostepny; 
    }

    public KategoriaSprzetu DodajNowaKategorie(string nazwa)
    {
        return new KategoriaSprzetu
        {
            Nazwa = nazwa
        };
    }

    // public void PotwierdzZwrot(Zwrot zwrot)
    // {
    //     zwrot.CzyPrzetworzony = true;
    //     zwrot.DataPrzetworzenia = DateTime.Now;
    // }
}