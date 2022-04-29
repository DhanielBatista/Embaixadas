using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace Embaixadas.Models.Context
{
    public class EmbaixadasContext : DbContext
    {
        public DbSet<Embaixada> Embaixadas { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public EmbaixadasContext(DbContextOptions<EmbaixadasContext> options) : base(options)
        {

        }



    }
}
