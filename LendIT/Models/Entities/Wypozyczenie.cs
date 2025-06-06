using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LendIT.Models.Enums;

namespace LendIT.Models.Entities;

public class Wypozyczenie
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public DateTime DataWypozyczenia { get; set; }

    [Required]
    public StatusWypozyczenia Status { get; set; }
    
    [NotMapped]
    public float CalkowityKoszt
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    [Required]
    public List<PozycjaWypozyczenia> Pozycje { get; set; } = new();

    [Required]
    public Klient Klient { get; set; }

    [Required]
    public int KlientId { get; set; }

    [Required]
    public Platnosc Platnosc { get; set; }
    
    [Required]
    public DateTime DataZakonczenia { get; set; }

    [Required]
    public int PlatnoscId { get; set; }
    
    public Wypozyczenie() { }

    public Wypozyczenie(DateTime dataOd, DateTime dataDo)
    {
        DataWypozyczenia = dataOd;
        DataZakonczenia = dataDo;
        Status = StatusWypozyczenia.Oczekujace;
    }
    
    public void DodajPozycje(PozycjaWypozyczenia pozycja)
    {
        Pozycje.Add(pozycja);
    }
    
    public void PrzedluzWypozyczenie(DateTime nowaData)
    {
        throw new NotImplementedException();
    }

    public bool SprawdzOpoznieniaWypozyczen()
    {
        throw new NotImplementedException();
    }
    
    
}