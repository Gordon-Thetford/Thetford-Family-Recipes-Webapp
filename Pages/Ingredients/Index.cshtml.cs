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
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Ingredient> Ingredient { get;set; } = default!;

        // Paging support
        // PageNum is the current page number
        // PageSize is how many records will be displayed per page. 
        // SupportsGet = true allows us to pass the PageNum through the URL with an HTTP Get Parameter 
        // This is necessary, because page numbers are not passed through normal forms
        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;
        public int TotalPages {get; set;}

        // Sorting support
        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = string.Empty;

        // Search support
        [BindProperty(SupportsGet = true)]
        public string CurrentSearch {get; set;} = string.Empty;

        public async Task OnGetAsync()
        {
            // ".Select(s => s)" is required because var query is a partial query that simply selects all w/o filtering or converting to list
            var query = _context.Ingredients.Include(i => i.RecipeIngredients!).ThenInclude(ri => ri.Recipes).Select(o => o);

            if (!string.IsNullOrEmpty(CurrentSearch))
            {
                query = query.Where(o => o.BaseName.ToUpper().Contains(CurrentSearch.ToUpper()));
            }
            
            // Sorts the query based on input
            switch (CurrentSort)
            {
                case "name_asc":
                    query = query.OrderBy(o => o.BaseName);
                    break;
                case "name_desc":
                    query = query.OrderByDescending(o => o.BaseName);
                    break;
            }

            TotalPages = (int)Math.Ceiling(query.Count() / (double)PageSize);
            
            Ingredient = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }

    }
}
