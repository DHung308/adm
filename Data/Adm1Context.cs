using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Adm1.Models;

namespace Adm1.Data
{
    public class Adm1Context : DbContext
    {
        public Adm1Context (DbContextOptions<Adm1Context> options)
            : base(options)
        {
        }

        public DbSet<Adm1.Models.Student> Student { get; set; } = default!;

        public DbSet<Adm1.Models.Dongvat> Dongvat { get; set; } = default!;

        public DbSet<Adm1.Models.Cat> Cat { get; set; } = default!;

        public DbSet<Adm1.Models.Faculty> Faculty { get; set; } = default!;
    }
}
