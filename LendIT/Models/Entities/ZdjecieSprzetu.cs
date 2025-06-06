using System.ComponentModel.DataAnnotations;

namespace LendIT.Models.Entities;

public class ZdjecieSprzetu
{
    public int Id { get; set; }

    [Required]
    public string Url { get; set; }

    [Required]
    public Sprzet Sprzet { get; set; }

    [Required]
    public int SprzetId { get; set; }
}