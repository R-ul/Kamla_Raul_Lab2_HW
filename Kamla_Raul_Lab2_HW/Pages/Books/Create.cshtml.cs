﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Kamla_Raul_Lab2_HW.Data;
using Kamla_Raul_Lab2_HW.Models;

namespace Kamla_Raul_Lab2_HW.Pages.Books
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
            ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID","PublisherName");
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Book == null || Book == null)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
