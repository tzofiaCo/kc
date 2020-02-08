using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KocDL;

namespace KoCNihul.Pages.Populations
{
    public class DetailsModel : PageModel
    {
        private readonly KocDL.DKContext _context;

        public DetailsModel(KocDL.DKContext context)
        {
            _context = context;
        }

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
    }
}
