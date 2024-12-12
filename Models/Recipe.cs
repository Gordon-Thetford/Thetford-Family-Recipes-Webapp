using System.ComponentModel.DataAnnotations;

namespace Thetford_Family_Recipes_Webapp.Models;

public class Recipe
{
    public int RecipeID { get; set; } //PK

    [Display(Name = "Recipe Name")]
    public string RecipeName { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Notes { get; set; } = string.Empty;

    public string Instructions { get; set; } = string.Empty;

    [Range(1, 5)]
    public int Effort { get; set; }

    [Display(Name = "Favorite")]
    public bool IsFavorite { get; set; } = false;

    [Display(Name = "Image")]
    public string ImageURL { get; set; } = string.Empty;

    [Display(Name = "Source")]
    public string Source { get; set; } = string.Empty;

    public List<RecipeIngredient> RecipeIngredients { get; set; } = default!; //Nav property to RecipeIngredients
}