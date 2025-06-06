using LendIT.Models.Enums;
using LendIT.Models.ValueObjects;

namespace LendIT.DTOs;

public class SprzetCreateDto
{
    public string Nazwa { get; set; }
    public string Opis { get; set; }
    public decimal Cena { get; set; }
    public decimal Kaucja { get; set; }
    public StatusSprzetu Status { get; set; }

    public WymiaryDto Wymiary { get; set; }

    public List<int> KategorieIds { get; set; }
    public List<string> ZdjeciaUrl { get; set; }
}
