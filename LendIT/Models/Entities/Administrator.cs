using System.ComponentModel.DataAnnotations;

namespace LendIT.Models.Entities;

public class Administrator : Uzytkownik
{
    [Required]
    private string PoziomDostepu { get; set; }

    public override void ZarzadzajKontem(string[] noweDane)
    {
        throw new NotImplementedException();
    }

    public void DodajSprzet(Sprzet sprzet)
    {
        throw new NotImplementedException();
    }

    public void EdytujSprzet(Sprzet sprzet, string[] noweDane)
    {
        throw new NotImplementedException();
    }

    public void UsunSprzet(Sprzet sprzet)
    {
        throw new NotImplementedException();
    }

    public void PotwierdzZwrot(Zwrot zwrot)
    {
        throw new NotImplementedException();
    }

    public void DodajNowaKategorie(string nazwa)
    {
        throw new NotImplementedException();
    }
}