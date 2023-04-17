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

       Task< Vehicle> GetById(int id);

        Task<List<Vehicle>> GetByVehicleNumber(string vehicleNumber);

        Task<Vehicle> Add(Vehicle vehicle);

        Task<List<VehicleFuelQuota>> GetQoutaByType(int typeId);

    }
}
