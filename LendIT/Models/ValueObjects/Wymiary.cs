using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LendIT.Models.ValueObjects;

[Owned]
public class Wymiary
{
    [Required]
    public double Wysokosc { get; set; }

    [Required]
    public double Szerokosc { get; set; }

    [Required]
    public double Glebokosc { get; set; }

    [Required]
    public double Waga { get; set; }
}