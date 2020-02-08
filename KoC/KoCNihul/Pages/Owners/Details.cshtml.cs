using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KocDL;

namespace KoCNihul.Pages.Owners
{
    public class DetailsModel : PageModel
    {
        private readonly KocDL.DKContext _context;

        public DetailsModel(KocDL.DKContext context)
        {
            _context = context;
        }

        public Owner Owner { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Owner = await _context.Owners
                .Include(o => o.OwnerType).FirstOrDefaultAsync(m => m.OwnerId == id);

            if (Owner == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
