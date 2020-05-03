using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InvestCar.Models;

namespace InvestCar.Data
{
    public class InvestCarDbContext : DbContext
    {
        public InvestCarDbContext (DbContextOptions<InvestCarDbContext> options)
            : base(options)
        {
        }

        public DbSet<Fabricante> Fabricante { get; set; }
        public DbSet<ModeloCar> ModeloCar { get; set; }
        public DbSet<Veiculo> Veiculo { get; set; }

    }
}
