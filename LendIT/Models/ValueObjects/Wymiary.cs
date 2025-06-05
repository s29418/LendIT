using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LendIT.Models.ValueObjects;

[Owned]
public class Wymiary
{
    [Required]
    private double Wysokosc { get; set; }

    [Required]
    private double Szerokosc { get; set; }

    [Required]
    private double Glebokosc { get; set; }

    [Required]
    private double Waga { get; set; }
}