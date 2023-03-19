using System.ComponentModel.DataAnnotations;
using Zoo.Models;

namespace Zoo.Models;

public class Animal
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Price { get; set; }

    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }

    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}

