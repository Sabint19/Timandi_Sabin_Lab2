using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Timandi_Sabin_Lab2.Models;

namespace Timandi_Sabin_Lab2.Data
{
    public class Timandi_Sabin_Lab2Context : DbContext
    {
        public Timandi_Sabin_Lab2Context (DbContextOptions<Timandi_Sabin_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Timandi_Sabin_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Timandi_Sabin_Lab2.Models.Publisher> Publisher { get; set; }
    }
}
