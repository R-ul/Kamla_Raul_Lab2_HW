using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Kamla_Raul_Lab2_HW.Models;

namespace Kamla_Raul_Lab2_HW.Data
{
    public class Kamla_Raul_Lab2_HWContext : DbContext
    {
        public Kamla_Raul_Lab2_HWContext (DbContextOptions<Kamla_Raul_Lab2_HWContext> options)
            : base(options)
        {
        }

        public DbSet<Kamla_Raul_Lab2_HW.Models.Book> Book { get; set; } = default!;

        public DbSet<Kamla_Raul_Lab2_HW.Models.Publisher>? Publisher { get; set; }
    }
}
