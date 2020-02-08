using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KocDL;

namespace KoCNihul.Pages.Genders
{
    public class IndexModel : PageModel
    {
        private readonly KocDL.DKContext _context;

        public IndexModel(KocDL.DKContext context)
        {
            _context = context;
        }

        public IList<Gender> Gender { get;set; }

        public async Task OnGetAsync()
        {
            Gender = await _context.Genders.ToListAsync();
        }
    }
}
