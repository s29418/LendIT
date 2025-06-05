using System.ComponentModel.DataAnnotations;

namespace LendIT.Models.Entities;

public class ZdjecieSprzetu
{
    public int Id { get; set; }

    [Required]
    private string Url { get; set; }

    [Required]
    private Sprzet Sprzet { get; set; }

    [Required]
    private int SprzetId { get; set; }
}