using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Thetford_Family_Recipes_Webapp.Models;

namespace Thetford_Family_Recipes_Webapp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AppDbContext _context;
        public IList<Recipe> RecipeFavorites { get; set; } = default!;
        
        public IndexModel(ILogger<IndexModel> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task OnGetAsync()
        {
            // Brings in favorited recipes for the alternating display on the homepage
            RecipeFavorites = await _context.Recipes.Where(r => r.IsFavorite == true).ToListAsync();
            _logger.LogInformation($"OnGetAsync() Called, {RecipeFavorites.Count()} Recipes in List<RecipeFavorites>");
        }
        
        // public void OnGet()
        // {

        // }
    }
}
