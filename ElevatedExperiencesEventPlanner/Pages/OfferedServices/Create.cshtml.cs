using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ElevatedExperiencesEventPlanner.Data;
using ElevatedExperiencesEventPlanner.Models;

namespace ElevatedExperiencesEventPlanner.Pages.OfferedServices
{
    public class CreateModel : PageModel
    {
        private readonly ElevatedExperiencesEventPlanner.Data.ElevatedExperiencesEventPlannerContext _context;

        public CreateModel(ElevatedExperiencesEventPlanner.Data.ElevatedExperiencesEventPlannerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public OfferedService OfferedService { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.OfferedService.Add(OfferedService);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
