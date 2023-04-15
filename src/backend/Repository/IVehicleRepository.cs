using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IVehicleRepository
    {
        IEnumerable<Vehicle> GetAll();

        Vehicle GetById(int id);

        List<Vehicle> GetByVehicleNumber(string vehicleNumber);

        void Add(Vehicle item);

    }
}
