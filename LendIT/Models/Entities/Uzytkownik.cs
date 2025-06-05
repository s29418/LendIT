using System.ComponentModel.DataAnnotations;

namespace LendIT.Models.Entities;

public abstract class Uzytkownik
{
    [Key]
    [Required]
    private int Id { get; set; }

    [Required]
    private string Imie { get; set; }

    [Required]
    private string Nazwisko { get; set; }

    [Required]
    private string Email { get; set; }

    [Required]
    private string Haslo { get; set; }

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