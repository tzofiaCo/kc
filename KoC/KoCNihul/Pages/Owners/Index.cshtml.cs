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
    public class IndexModel : PageModel
    {
        private readonly KocDL.DKContext _context;

        public IndexModel(KocDL.DKContext context)
        {
            _context = context;
        }

        public IList<Owner> Owner { get;set; }

        public async Task OnGetAsync()
        {
            Owner = await _context.Owners
                .Include(o => o.OwnerType).ToListAsync();
        }
    }
}
