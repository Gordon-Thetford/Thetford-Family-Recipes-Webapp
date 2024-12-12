using System.ComponentModel.DataAnnotations;

namespace Thetford_Family_Recipes_Webapp.Models;

public class RecipeIngredient
{
    public int RecipeID { get; set; } //Composite PK, FK1
    public int IngredientID { get; set;} //Composite PK, FK2

    public double UnitsCount { get; set; }

    public string UnitsType { get; set; } = string.Empty;

    public Recipe Recipes { get; set;} = default!; //Nav property to Recipe

    public Ingredient Ingredients { get; set; } = default!;
}