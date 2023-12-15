using System.ComponentModel.DataAnnotations.Schema;
using Project1.Models.Structure;
using Project1.Models.Templates;
using Project1.Models.Templates.Interfaces;

namespace Project1.Models.Animals;

public class Shark : Animal, ISwimming
{
    public Color Color { get; set; }
    public double Length { get; set; }
}