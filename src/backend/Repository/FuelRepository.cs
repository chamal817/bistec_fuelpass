using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class FuelRepository : IFuelRepository
    {
        private readonly FuelDbContext _context;

        public FuelRepository(FuelDbContext context)
        {
            _context = context;
        }
        public async Task<Fuel> AddFuelQty(Fuel qty)
        {
            _context.Fuel.Add(qty);
            _context.SaveChanges();
            return await Task.FromResult(qty);
        }
        public async Task<int> GetWeeklyQty(DateTime startDate, DateTime endDate, int vehicleId)
        {
            var qty = _context.Fuel.Where(c => c.Date >= startDate && c.Date <= endDate && c.VehicleId == vehicleId).Sum(c => c.Fuelqty);
            return await Task.FromResult(qty);
        }
        public async Task<int> GetVehicleQty(int typeId)
        {
           
            var qty = _context.VehicleFuelQuota.Where(c => c.Id == typeId).Sum(c => c.qouta);
            return await Task.FromResult(qty);
        }

    }
}
