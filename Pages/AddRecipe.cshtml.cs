using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Thetford_Family_Recipes_Webapp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Thetford_Family_Recipes_Webapp.Pages
{
    public class AddRecipeModel : PageModel
    {
        private readonly AppDbContext _context;
        private readonly ILogger<AddRecipeModel> _logger;

        [BindProperty]
        public Recipe Recipe { get; set; } = default!;

        public SelectList IngredientsDropDown { get; set; } = default!;

        public AddRecipeModel(AppDbContext context, ILogger<AddRecipeModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            IngredientsDropDown = new SelectList(_context.Ingredients.ToList(), "IngredientID", "BaseName");
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                var allErrors = ModelState.Values.SelectMany(v => v.Errors);
                foreach(var e in allErrors)
                {
                    _logger.LogError($"Error: {e.ErrorMessage}");
                }
                return Page();
            }
            _context.Recipes.Add(Recipe);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}