using System.ComponentModel.DataAnnotations;

namespace LendIT.Models.Entities;

public class EtykietaZwrotna
{
    [Key]
    [Required]
    private int Id { get; set; }

    [Required]
    private string Kod { get; set; }

    [Required]
    private Zwrot Zwrot { get; set; }

    [Required]
    private int ZwrotId { get; set; }

    public void GenerujEtykiete()
    {
        throw new NotImplementedException();
    }
}