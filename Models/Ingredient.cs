using System.ComponentModel.DataAnnotations;

namespace Thetford_Family_Recipes_Webapp.Models;

public class Ingredient
{
    public int IngredientID { get; set; } //PK

    public string BaseName { get; set; } = string.Empty;

    // i.e. jack, cheddar or cotija cheese or diced, minced, or sliced onion
    // public string TypeCategory { get; set; } = string.Empty;

    // Descriptor or Adjective? probably redundant with TypeCategory, may remove entirely
    // public string Descriptor { get; set; } = string.Empty;

    public List<RecipeIngredient> RecipeIngredients { get; set; } = default!; //Nav property to RecipeIngredients
}