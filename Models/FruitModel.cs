using System.ComponentModel.DataAnnotations;


namespace ServerApp.Models;

public class FruitModel
{
    [Key]
    public int id { get; set; }

    [Display(Name="Fruit Name")]
    public string? name { get; set; }
    [Display(Name ="Available?")]
    public bool instock { get; set; }
}
