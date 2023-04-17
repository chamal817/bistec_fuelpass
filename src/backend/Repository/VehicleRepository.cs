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
        public async Task<Vehicle> GetById(int id)
        {
            return _context.Vehicles.Find(id);
        }
        public async Task<List<Vehicle>> GetByVehicleNumber(string vehicleNumber)
        {
            return  _context.Vehicles.Where(x => x.VehicleNumber == vehicleNumber).ToList();
        }
        public async Task<Vehicle> Add(Vehicle vehicle)
        {
             _context.Vehicles.Add(vehicle);
            _context.SaveChanges();
            return await Task.FromResult(vehicle);
        }
        public async Task<List<VehicleFuelQuota>> GetQoutaByType(int typeId)
        {
            //return _context.VehicleFuelQuota.Where(x => x.Type == typeId).ToList();
            return new List<VehicleFuelQuota>();
        }

    }
}
