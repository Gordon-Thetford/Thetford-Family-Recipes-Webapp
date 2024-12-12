using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Thetford_Family_Recipes_Webapp.Models;

namespace Thetford_Family_Recipes_Webapp.Pages_Ingredients
{
    public class DetailsModel : PageModel
    {
        private readonly Thetford_Family_Recipes_Webapp.Models.AppDbContext _context;

        public DetailsModel(Thetford_Family_Recipes_Webapp.Models.AppDbContext context)
        {
            _context = context;
        }

        public Ingredient Ingredient { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingredient = await _context.Ingredients.FirstOrDefaultAsync(m => m.IngredientID == id);

            if (ingredient is not null)
            {
                Ingredient = ingredient;

                return Page();
            }

            return NotFound();
        }
    }
}
