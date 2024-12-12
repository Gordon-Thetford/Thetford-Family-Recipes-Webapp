using System.ComponentModel.DataAnnotations;

namespace Thetford_Family_Recipes_Webapp.Models;

public class Ingredient
{
    public int IngredientID { get; set; } //PK

    public string BaseName { get; set; } = string.Empty;

    // public string Adjectives { get; set; } = string.Empty;

    public List<RecipeIngredient> RecipeIngredients { get; set; } = default!; //Nav property to RecipeIngredients
}