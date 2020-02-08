﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KocDL;

namespace KoCNihul.Pages.Diplomas
{
    public class CreateModel : PageModel
    {
        private readonly KocDL.DKContext _context;

        public CreateModel(KocDL.DKContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Diploma Diploma { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Diplomas.Add(Diploma);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
