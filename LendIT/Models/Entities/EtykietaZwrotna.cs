using System.ComponentModel.DataAnnotations;

namespace LendIT.Models.Entities;

public class EtykietaZwrotna
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public string Kod { get; set; }

    [Required]
    public Zwrot Zwrot { get; set; }

    [Required]
    public int ZwrotId { get; set; }

    public void GenerujEtykiete()
    {
        throw new NotImplementedException();
    }
}