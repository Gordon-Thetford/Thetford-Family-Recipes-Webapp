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
    public class IndexModel : PageModel
    {
        private readonly Thetford_Family_Recipes_Webapp.Models.AppDbContext _context;

        public IndexModel(Thetford_Family_Recipes_Webapp.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Ingredient> Ingredient { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Ingredient = await _context.Ingredients.ToListAsync();
        }
    }
}
