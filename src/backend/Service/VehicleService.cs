using Entity;
using Microsoft.EntityFrameworkCore;
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
        public Vehicle GetById(int id)
        {
            return _repository.GetById(id);
        }
        public List<Vehicle> GetByVehicleNumber(string number)
        {
            return _repository.GetByVehicleNumber(number);
        }

        public void Add(Vehicle item)
        {
            _repository.Add(item);
        }
    }
}
