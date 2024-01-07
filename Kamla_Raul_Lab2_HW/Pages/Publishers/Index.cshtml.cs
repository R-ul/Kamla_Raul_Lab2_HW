using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Kamla_Raul_Lab2_HW.Data;
using Kamla_Raul_Lab2_HW.Models;

namespace Kamla_Raul_Lab2_HW.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Kamla_Raul_Lab2_HW.Data.Kamla_Raul_Lab2_HWContext _context;

        public IndexModel(Kamla_Raul_Lab2_HW.Data.Kamla_Raul_Lab2_HWContext context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
