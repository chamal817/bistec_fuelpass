using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _repository;

        public VehicleService(IVehicleRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<Vehicle> GetAll()
        {
            return _repository.GetAll();
        }
        public async Task<Vehicle> GetById(int id)
        {
            return await _repository.GetById(id);
        }
        public async Task<List<Vehicle>> GetByVehicleNumber(string number)
        {
            return await _repository.GetByVehicleNumber(number);
        }

        public async Task<Vehicle> Add(Vehicle vehicle)
        {
            return  await _repository.Add(vehicle);
        }
        public async Task<List<VehicleFuelQuota>> GetQoutaByType(int typeId)
        {
            return await _repository.GetQoutaByType(typeId);
        }
        
    }
}
