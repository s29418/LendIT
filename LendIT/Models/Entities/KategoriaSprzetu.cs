using System.ComponentModel.DataAnnotations;

namespace LendIT.Models.Entities;

public class KategoriaSprzetu
{
    public int Id { get; set; }

    [Required]
    public string Nazwa { get; set; }

    public List<Sprzet> Sprzety { get; set; } = new();
}