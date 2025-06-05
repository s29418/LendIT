using System.ComponentModel.DataAnnotations;

namespace LendIT.Models.Entities;

public class KategoriaSprzetu
{
    public int Id { get; set; }

    [Required]
    private string Nazwa { get; set; }

    private List<Sprzet> SprzetyWKategorii { get; set; } = new();
}