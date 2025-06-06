using System.ComponentModel.DataAnnotations;

namespace LendIT.Models.Entities;

public class PozycjaWypozyczenia
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public int Ilosc { get; set; }

    [Required]
    public Sprzet Sprzet { get; set; }

    [Required]
    public int SprzetId { get; set; }

    [Required]
    public Wypozyczenie Wypozyczenie { get; set; }

    [Required]
    public int WypozyczenieId { get; set; }
    
    public PozycjaWypozyczenia() { } 
    
    public PozycjaWypozyczenia(Sprzet sprzet, int ilosc, Wypozyczenie wypozyczenie)
    {
        Sprzet = sprzet;
        Ilosc = ilosc;
        Wypozyczenie = wypozyczenie;
    }
    
    
    
}