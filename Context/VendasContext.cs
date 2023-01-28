using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using desafioFinal.Entities;

namespace desafioFinal.Context
{
    public class VendasContext : DbContext
    {
        public VendasContext(DbContextOptions<VendasContext> options) : base(options)
        {

        }

        public DbSet<Venda> Venda {get; set;}
    }
}