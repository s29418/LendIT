using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LendIT.Models.Enums;

namespace LendIT.Models.Entities;

public class Wypozyczenie
{
    [Key]
    [Required]
    private int Id { get; set; }

    [Required]
    private DateTime DataWypozyczenia { get; set; }

    [Required]
    private StatusWypozyczenia Status { get; set; }
    
    [NotMapped]
    private float CalkowityKoszt
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    [Required]
    private List<PozycjaWypozyczenia> Pozycje { get; set; } = new();

    [Required]
    private Klient Klient { get; set; }

    [Required]
    private int KlientId { get; set; }

    [Required]
    private Platnosc Platnosc { get; set; }

    [Required]
    private int PlatnoscId { get; set; }

    public void PrzedluzWypozyczenie(DateTime nowaData)
    {
        throw new NotImplementedException();
    }

    public bool SprawdzOpoznieniaWypozyczen()
    {
        throw new NotImplementedException();
    }
}