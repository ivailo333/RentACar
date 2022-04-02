#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RentACar.Models;

namespace RentACar.Data
{
    public class RentACarContext : DbContext
    {
        public RentACarContext (DbContextOptions<RentACarContext> options)
            : base(options)
        {
        }

        public DbSet<RentACar.Models.Employees> Employees { get; set; }

        public DbSet<RentACar.Models.Clients> Clients { get; set; }

        public DbSet<RentACar.Models.Cars> Cars { get; set; }

        public DbSet<RentACar.Models.CarRentalTime> CarRentalTime { get; set; }
    }
}
