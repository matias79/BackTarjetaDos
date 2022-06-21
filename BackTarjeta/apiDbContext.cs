using BackTarjeta.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackTarjeta
{
    public class apiDbContext: DbContext
    {
        public DbSet<tarjetaCredito> CreditoTarjeta { get; set; }
        public apiDbContext (DbContextOptions<apiDbContext> options) : base(options) {

        }

    }

   
}
