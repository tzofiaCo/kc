using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KocDL;

namespace KoCNihul.Pages.Diplomas
{
    public class EditModel : PageModel
    {
        private readonly KocDL.DKContext _context;

        public EditModel(KocDL.DKContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Diploma Diploma { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Diploma = await _context.Diplomas.FirstOrDefaultAsync(m => m.DiplomaId == id);

            if (Diploma == null)
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

            _context.Attach(Diploma).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DiplomaExists(Diploma.DiplomaId))
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

        private bool DiplomaExists(int id)
        {
            return _context.Diplomas.Any(e => e.DiplomaId == id);
        }
    }
}
