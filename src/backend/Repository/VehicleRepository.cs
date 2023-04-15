using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly FuelDbContext _context;

        public VehicleRepository(FuelDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Vehicle> GetAll()
        {
            return _context.Vehicles.ToList();
        }
        public Vehicle GetById(int id)
        {
            return _context.Vehicles.Find(id);
        }
        public List<Vehicle> GetByVehicleNumber(string vehicleNumber)
        {
            return _context.Vehicles.Where(x => x.VehicleNumber == vehicleNumber).ToList();
        }
        public void Add(Vehicle item)
        {
            _context.Vehicles.Add(item);
            _context.SaveChanges();
        }
    }
}
