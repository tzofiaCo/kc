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
    public class IndexModel : PageModel
    {
        private readonly KocDL.DKContext _context;

        public IndexModel(KocDL.DKContext context)
        {
            _context = context;
        }

        public IList<Population> Population { get;set; }

        public async Task OnGetAsync()
        {
            Population = await _context.Populations.ToListAsync();
        }
    }
}
