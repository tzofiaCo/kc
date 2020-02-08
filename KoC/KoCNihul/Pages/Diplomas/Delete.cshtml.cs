using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KocDL;

namespace KoCNihul.Pages.Diplomas
{
    public class DeleteModel : PageModel
    {
        private readonly KocDL.DKContext _context;

        public DeleteModel(KocDL.DKContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Diploma = await _context.Diplomas.FindAsync(id);

            if (Diploma != null)
            {
                _context.Diplomas.Remove(Diploma);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
