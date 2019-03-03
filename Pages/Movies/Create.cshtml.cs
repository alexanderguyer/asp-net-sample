using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using aspNetSample.Models;

namespace aspNetSample.Pages_Movies
{
    public class CreateModel : PageModel
    {
        private readonly aspNetSample.Models.MovieContext _context;

        public CreateModel(aspNetSample.Models.MovieContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        //Just messing around to understand the BindProperty, I extracted the title from the form "manually"
        public async Task<IActionResult> OnPostAsync(string title)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Movie.Title = title;
            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
