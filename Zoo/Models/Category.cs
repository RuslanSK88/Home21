using System.ComponentModel.DataAnnotations;

namespace Zoo.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public List<Animal>? Animals { get; set; }
}

