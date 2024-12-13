using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Thetford_Family_Recipes_Webapp.Models;

namespace Thetford_Family_Recipes_Webapp.Pages
{
    public class ViewRecipeModel : PageModel
    {
        private readonly AppDbContext _context;
        private readonly ILogger<ViewRecipeModel> _logger;

        public Recipe Recipe { get; set; } = default!;

        public ViewRecipeModel(AppDbContext context, ILogger<ViewRecipeModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var recipe = _context.Recipes.Include(r => r.RecipeIngredients!).ThenInclude(r => r.Ingredients).FirstOrDefault(x => x.RecipeID == id);
            // var recipe = _context.Recipes.Find(id);

            if (recipe == null)
            {
                return NotFound();
            }
            else
            {
                Recipe = recipe;
            }
            return Page();
        }
    }
}