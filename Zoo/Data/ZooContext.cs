using Zoo.Models;
using Microsoft.EntityFrameworkCore;

namespace Zoo.Data;

public class ZooContext : DbContext
{
    public ZooContext(DbContextOptions<ZooContext> options)
            : base(options)
    {
    }

    public DbSet<Animal> Animal { get; set; }
    public DbSet<Category> Category { get; set; }
}

