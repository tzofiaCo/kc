using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KocDL;

namespace KoCNihul.Pages.OwnerTypes
{
    public class EditModel : PageModel
    {
        private readonly KocDL.DKContext _context;

        public EditModel(KocDL.DKContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(OwnerType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OwnerTypeExists(OwnerType.OwnerTypeId))
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

        private bool OwnerTypeExists(int id)
        {
            return _context.OwnerTypes.Any(e => e.OwnerTypeId == id);
        }
    }
}
