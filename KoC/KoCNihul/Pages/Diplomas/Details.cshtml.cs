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
    public class DetailsModel : PageModel
    {
        private readonly KocDL.DKContext _context;

        public DetailsModel(KocDL.DKContext context)
        {
            _context = context;
        }

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
    }
}
