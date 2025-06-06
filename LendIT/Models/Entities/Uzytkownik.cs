using System.ComponentModel.DataAnnotations;

namespace LendIT.Models.Entities;

public abstract class Uzytkownik
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public string Imie { get; set; }

    [Required]
    public string Nazwisko { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Haslo { get; set; }

    public bool Zaloguj(string email, string haslo)
    {
        throw new NotImplementedException();
    }

    public void Wyloguj()
    {
        throw new NotImplementedException();
    }

    public abstract void ZarzadzajKontem(string[] noweDane);
}