using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class FuelDbContext : DbContext
    {
        public FuelDbContext(DbContextOptions<FuelDbContext> options) : base(options)
        { }


        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Fuel> Fuel { get; set; }
        public DbSet<VehicleFuelQuota> VehicleFuelQuota { get; set; }
    }

}
