﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Kamla_Raul_Lab2_HW.Data;
using Kamla_Raul_Lab2_HW.Models;

namespace Kamla_Raul_Lab2_HW.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Kamla_Raul_Lab2_HW.Data.Kamla_Raul_Lab2_HWContext _context;

        public CreateModel(Kamla_Raul_Lab2_HW.Data.Kamla_Raul_Lab2_HWContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Publisher == null || Publisher == null)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
