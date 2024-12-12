using Microsoft.EntityFrameworkCore;

namespace Thetford_Family_Recipes_Webapp.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
    {
        
    }

    // This code tells EF Core that OrderID and ProductID combine for composite primary key
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RecipeIngredient>()
            .HasKey(e => new {e.RecipeID, e.IngredientID});
    }

    public DbSet<Recipe> Recipes {get; set;} = default!;
    public DbSet<Ingredient> Ingredients {get; set;} = default!;
    public DbSet<RecipeIngredient> RecipeIngredients {get; set;} = default!;
}