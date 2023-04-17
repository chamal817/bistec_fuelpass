using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class FuelService : IFuelService
    {
        private readonly IFuelRepository _repository;

        public FuelService(IFuelRepository repository)
        {
            _repository = repository;
        }
        public Task<Fuel> AddFuelQty(Fuel qty)
        {
            return _repository.AddFuelQty(qty);

        }
        public async Task<int> GetAvailabaleQty(DateTime startDate, DateTime endDate, int vehicleId, int typeId)
        {
            var vehicleTypeQty = await _repository.GetVehicleQty(typeId);
            var usedQty = await _repository.GetWeeklyQty(startDate, endDate, vehicleId);
            var final = vehicleTypeQty - usedQty;
            return final;
        }
    }
}
