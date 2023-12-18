using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using finalHerramientas.Models;

namespace FinalHerramientas.Data
{
    public class LugarContext : DbContext
    {
        public LugarContext (DbContextOptions<LugarContext> options)
            : base(options)
        {
        }

        public DbSet<finalHerramientas.Models.Lugar> Lugar { get; set; } = default!;
    }
}
