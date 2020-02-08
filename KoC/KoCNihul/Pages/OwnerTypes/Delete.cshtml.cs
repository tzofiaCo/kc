using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KocDL;

namespace KoCNihul.Pages.OwnerTypes
{
    public class DeleteModel : PageModel
    {
        private readonly KocDL.DKContext _context;

        public DeleteModel(KocDL.DKContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OwnerType OwnerType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OwnerType = await _context.OwnerTypes.FirstOrDefaultAsync(m => m.OwnerTypeId == id);

            if (OwnerType == null)
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

            OwnerType = await _context.OwnerTypes.FindAsync(id);

            if (OwnerType != null)
            {
                _context.OwnerTypes.Remove(OwnerType);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
