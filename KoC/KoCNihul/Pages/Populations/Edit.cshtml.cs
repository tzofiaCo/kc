using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KocDL;

namespace KoCNihul.Pages.Populations
{
    public class EditModel : PageModel
    {
        private readonly KocDL.DKContext _context;

        public EditModel(KocDL.DKContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Population Population { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Population = await _context.Populations.FirstOrDefaultAsync(m => m.PopulationId == id);

            if (Population == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Population).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PopulationExists(Population.PopulationId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PopulationExists(int id)
        {
            return _context.Populations.Any(e => e.PopulationId == id);
        }
    }
}
