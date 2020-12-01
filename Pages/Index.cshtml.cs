using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApplication5.Models;

namespace WebApplication5
{
    public class IndexRecipe : PageModel
    {
        private readonly ILogger<IndexRecipe> _logger;
        private readonly WebApplication5.Data.WebApplication5Context _context;

        public IndexRecipe(ILogger<IndexRecipe> logger,
            WebApplication5.Data.WebApplication5Context context)
        {
            _logger = logger;
            _context = context;
        }
        
        public IList<Recipe> Recipe { get; set; }
        
        public async Task OnGetAsync()
        {
            Recipe = await _context.Recipe.ToListAsync();
        }
        


    }
}

