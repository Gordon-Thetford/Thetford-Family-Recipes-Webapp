using Microsoft.EntityFrameworkCore;

namespace Thetford_Family_Recipes_Webapp.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

        if (context.Recipes.Any() || context.Ingredients.Any()) 
        {
            return;
        }
        context.Recipes.AddRange(
            new Recipe {
                RecipeName = "Street Corn Chicken Chili",
                Description = "A mix between a white chicken chili recipe and Mexican street corn, delicious flavors for a perfect one pot dish!",
                Notes = "Recipe as written yields a medium heat, consider reducing spicy ingredients for a mild outcome. Beer and hot sauce was omitted from recipe transcription.",
                Instructions = "Set a large soup pot over medium heat. Add the onion, jalapenos, corn kernels, kosher salt, and pepper. Cook 7 to 9 minutes stirring a few times. Add the garlic, ground chicken, chili powder, paprika, cumin, more kosher salt, and pepper. Cook 7 to 9 minutes, stirring and breaking apart the chicken with a spatula. Add the chicken broth, beer (if using), and chicken base. Bring to a boil then reduce the heat to medium low and simmer for 25 to 30 minutes. Add the hot sauce, sour cream, cilantro, and lime juice. Cook 5 to 10 more minutes. Taste for seasoning and add more chili powder, kosher salt, and/or pepper if needed. Serve with toppings such as more cilantro, crumbled cotija cheese, chili powder, lime wedges if desired.",
                Effort = 3,
                IsFavorite = true,
                ImageURL = "img/Street-Corn-Chicken-Chili.jpg",
                Source = "https://cookswellwithothers.com/2023/12/24/street-corn-chicken-chili/",
            },
            new Recipe {
                RecipeName = "Chopped Steaks",
                Description = "Delicious chopped steaks with hamburger, mushrooms, onions, and brown gravy.",
                Notes = "The secret is adding a beef bouillion cube to the brown gravy mix. Anything extra to add to the ground beef mixture was omitted from recipe transcription. Recipe instructions were modified significantly.",
                Instructions = "Chop mushrooms and onions. Heat oil in a large skillet and saute until tender adding the mushrooms when the onions are about halfway done. At some point add salt, pepper, garlic powder, and onion powder. When finished cooking, sprinkle the flour over the mushrooms and onions to absorb any excess liquid. Heat the oil in a large skillet over medium heat. Form ground beef into flat, thin patties. Salt and pepper the patties and cook until internal temp is 165F. Can add worcestershire sauce if desired Dissolve a beef bouillion cube into the water for the brown gravy packets and begin cooking per packet instructions. Ingredients can be combined in skillet or on plate. Serve.",
                Effort = 2,
                IsFavorite = true,
                ImageURL = "img/Chopped-Steak.jpg",
                Source = "https://thesaltymarshmallow.com/easy-chopped-steaks-and-gravy/",
            },
            new Recipe {
                RecipeName = "Lynn's Enchilada Casserole",
                Description = "A Miller family recipe. Delicious and easy to make comfort food. ",
                Notes = "Can use red or green enchilada sauce. Press spinach after cooking to remove excess water.",
                Instructions = "Combine beef and onion in a frying pan and brown over high heat, stirring meat to crumble. Stir in taco seasoning mix and water: cover and simmer 10 minutes. Choose a 2.5-3qt baking pan and pour half of the taco sauce into it. Turn turn five of the tortillas in the sauce to coat lightly and spread them, overlapping int the bottom of the dish. In a wire strainer, press out most of the water from the spinach and stir half into the beef; spoon the beef mixture over the tortillas and sprinkle with 1/2 of the cheese. Cover with remaining tortillas, overlapping, and spread the balance of the balance of taco sauce over them. Spread sour cream over top. Scatter the spinach over the sour cream then top with remaining cheese. To cook immediately, bake in a 375 degree oven for 40 minutes, covered for the first 25 minutes. If made ahead, bake at 375 for 1hr 10 min or until heated through and bubbling around the edges. Cover for the first 35 minutes. Freezes well.",
                Effort = 3,
                IsFavorite = true,
                ImageURL = "img/Enchilada-Casserole.jpg",
                Source = "Lynn Miller",
            },
            new Recipe {
                RecipeName = "Salmon Pate",
                Description = "Easy and quick to make, goes great on crackers or in a lettuce wrap.",
                Notes = "I like to go heavy on the flavoring ingredients - Measure with your heart",
                Instructions = "Allow cream cheese to warm ahead of time for easier mixing. Drain liquid from canned salmon. Combine all except cream cheese and salmon. Mix in cream cheese then salmon. Serve.",
                Effort = 1,
                IsFavorite = default,
                ImageURL = "Salmon-Pate.jpg",
                Source = "Alice",
            }
        );
        
                context.Ingredients.AddRange(
            // Recipe 1
            /* 1 */ new Ingredient {BaseName = "Olive Oil"},
            /* 2 */ new Ingredient {BaseName = "Diced Onion"},
            /* 3 */ new Ingredient {BaseName = "Diced Jalapeno"},
            /* 4 */ new Ingredient {BaseName = "Sweet Corn Kernels"},
            /* 5 */ new Ingredient {BaseName = "Salt"},
            /* 6 */ new Ingredient {BaseName = "Pepper"},
            /* 7 */ new Ingredient {BaseName = "Minced Garlic"},
            /* 8 */ new Ingredient {BaseName = "Ground Chicken"},
            /* 9 */ new Ingredient {BaseName = "Chili Powder"},
            /* 10 */ new Ingredient {BaseName = "Paprika"},
            /* 11 */ new Ingredient {BaseName = "Cumin"},
            /* 12 */ new Ingredient {BaseName = "Chicken Broth"},
            /* 13 */ new Ingredient {BaseName = "Chicken Base"},
            /* 14 */ new Ingredient {BaseName = "Sour Cream"},
            /* 15 */ new Ingredient {BaseName = "Cilantro"},
            /* 16 */ new Ingredient {BaseName = "Lime Juice"},
            /* 17 */ new Ingredient {BaseName = "Cotija Cheese"},
            // Recipe 2
            /* 18 */ new Ingredient {BaseName = "Ground Beef"},
            /* 19 */ new Ingredient {BaseName = "Brown Gravy Packet"},
            /* 20 */ new Ingredient {BaseName = "Garlic Powder"},
            /* 21 */ new Ingredient {BaseName = "Onion Powder"},
            /* 22 */ new Ingredient {BaseName = "Sliced Onion"},
            /* 23 */ new Ingredient {BaseName = "Sliced Mushrooms"},
            /* 24 */ new Ingredient {BaseName = "Flour"},
            /* 25 */ new Ingredient {BaseName = "Beef Bouillion Cube"},
            // Recipe 3
            /* 26 */ new Ingredient {BaseName = "Taco Seasoning Mix"},
            /* 27 */ new Ingredient {BaseName = "Water"},
            /* 28 */ new Ingredient {BaseName = "Enchilada Sauce"},
            /* 29 */ new Ingredient {BaseName = "Corn Tortillas"},
            /* 30 */ new Ingredient {BaseName = "Frozen Spinach"},
            /* 31 */ new Ingredient {BaseName = "Shredded Cheese"},
            /* 32 */ new Ingredient {BaseName = "Sour Cream"},
            // Recipe 4
            /* 33 */ new Ingredient {BaseName = "Canned Salmon"},
            /* 34 */ new Ingredient {BaseName = "Cream Cheese"},
            /* 35 */ new Ingredient {BaseName = "Mayo"},
            /* 36 */ new Ingredient {BaseName = "Lemon Juice"},
            /* 37 */ new Ingredient {BaseName = "Liquid Smoke"},
            /* 38 */ new Ingredient {BaseName = "Dill Weed"}
        );

        context.RecipeIngredients.AddRange(
            // Recipe 1 Begin
            new RecipeIngredient {RecipeID = 1, IngredientID = 1, UnitsCount = 2, UnitsType = "tbsp"},
            new RecipeIngredient {RecipeID = 1, IngredientID = 2, UnitsCount = 1, UnitsType = "medium"},
            new RecipeIngredient {RecipeID = 1, IngredientID = 3, UnitsCount = 2,},
            new RecipeIngredient {RecipeID = 1, IngredientID = 4, UnitsCount = 16, UnitsType = "oz"},
            new RecipeIngredient {RecipeID = 1, IngredientID = 5, UnitsCount = 1, UnitsType = "to taste"},
            new RecipeIngredient {RecipeID = 1, IngredientID = 6, UnitsCount = 1, UnitsType = "to taste"},
            new RecipeIngredient {RecipeID = 1, IngredientID = 7, UnitsCount = 8, UnitsType = "cloves"},
            new RecipeIngredient {RecipeID = 1, IngredientID = 8, UnitsCount = 2, UnitsType = "lbs"},
            new RecipeIngredient {RecipeID = 1, IngredientID = 9, UnitsCount = 3, UnitsType = "tbsp"},
            new RecipeIngredient {RecipeID = 1, IngredientID = 10, UnitsCount = 2, UnitsType = "tbsp"},
            new RecipeIngredient {RecipeID = 1, IngredientID = 11, UnitsCount = 1, UnitsType = "tbsp"},
            new RecipeIngredient {RecipeID = 1, IngredientID = 12, UnitsCount = 4, UnitsType = "cups"},
            new RecipeIngredient {RecipeID = 1, IngredientID = 13, UnitsCount = 1, UnitsType = "tbsp"},
            new RecipeIngredient {RecipeID = 1, IngredientID = 14, UnitsCount = 1, UnitsType = "cup"},
            new RecipeIngredient {RecipeID = 1, IngredientID = 15, UnitsCount = 1, UnitsType = "cup"},
            new RecipeIngredient {RecipeID = 1, IngredientID = 16, UnitsCount = 3, UnitsType = "tbsp"},
            new RecipeIngredient {RecipeID = 1, IngredientID = 17, UnitsCount = 1, UnitsType = "to taste"},

            // Recipe 2 Begin
            new RecipeIngredient {RecipeID = 2, IngredientID = 18, UnitsCount = 1, UnitsType = "lbs"},
            new RecipeIngredient {RecipeID = 2, IngredientID = 19, UnitsCount = 2,},
            new RecipeIngredient {RecipeID = 2, IngredientID = 20, UnitsCount = 0.5, UnitsType = "tsp"},
            new RecipeIngredient {RecipeID = 2, IngredientID = 21, UnitsCount = 0.5, UnitsType = "tsp"},
            new RecipeIngredient {RecipeID = 2, IngredientID = 5, UnitsCount = 0.5, UnitsType = "tsp"},
            new RecipeIngredient {RecipeID = 2, IngredientID = 6, UnitsCount = 0.5, UnitsType = "tsp"},
            new RecipeIngredient {RecipeID = 2, IngredientID = 22, UnitsCount = 1, UnitsType = "small"},
            new RecipeIngredient {RecipeID = 2, IngredientID = 23, UnitsCount = 1, UnitsType = "cup"},
            new RecipeIngredient {RecipeID = 2, IngredientID = 24, UnitsCount = 2, UnitsType = "tbsp"},
            new RecipeIngredient {RecipeID = 2, IngredientID = 25, UnitsCount = 2,},
            new RecipeIngredient {RecipeID = 2, IngredientID = 1, UnitsCount = 1, UnitsType = "tbsp"},

            // Recipe 3 Begin
            new RecipeIngredient {RecipeID = 3, IngredientID = 18, UnitsCount = 1.5, UnitsType = "lbs"},
            new RecipeIngredient {RecipeID = 3, IngredientID = 2, UnitsCount = 1, UnitsType = "small"},
            new RecipeIngredient {RecipeID = 3, IngredientID = 26, UnitsCount = 1.25, UnitsType = "oz"},
            new RecipeIngredient {RecipeID = 3, IngredientID = 27, UnitsCount = 1, UnitsType = "cup"},
            new RecipeIngredient {RecipeID = 3, IngredientID = 28, UnitsCount = 8, UnitsType = "oz"},
            new RecipeIngredient {RecipeID = 3, IngredientID = 29, UnitsCount = 10, UnitsType = "1/2 Package"},
            new RecipeIngredient {RecipeID = 3, IngredientID = 30, UnitsCount = 10, UnitsType = "oz / 1 pkg"},
            new RecipeIngredient {RecipeID = 3, IngredientID = 31, UnitsCount = 3, UnitsType = "cup"},
            new RecipeIngredient {RecipeID = 3, IngredientID = 32, UnitsCount = 1, UnitsType = "cup"},
            
            // Recipe 4 Begin
            new RecipeIngredient {RecipeID = 4, IngredientID = 33, UnitsCount = 8, UnitsType = "oz"},
            new RecipeIngredient {RecipeID = 4, IngredientID = 34, UnitsCount = 8, UnitsType = "oz"},
            new RecipeIngredient {RecipeID = 4, IngredientID = 35, UnitsCount = 0.5, UnitsType = "cup"},
            new RecipeIngredient {RecipeID = 4, IngredientID = 21, UnitsCount = 2, UnitsType = "tbsp"},
            new RecipeIngredient {RecipeID = 4, IngredientID = 36, UnitsCount = 3, UnitsType = "tbsp"},
            new RecipeIngredient {RecipeID = 4, IngredientID = 37, UnitsCount = 3, UnitsType = "tbsp"},
            new RecipeIngredient {RecipeID = 4, IngredientID = 38, UnitsCount = 2, UnitsType = "tbsp"}
        );
        
        context.SaveChanges();
    }
}

// TEMPLATES
// new Recipe {
//     RecipeName = "",
//     Description = "",
//     Notes = "",
//     Instructions = "",
//     Effort = ,
//     IsFavorite = ,
//     ImageURL = "",
//     Source = "",
// },