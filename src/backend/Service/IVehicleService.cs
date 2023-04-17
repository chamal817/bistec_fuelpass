using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IVehicleService
    {
        IEnumerable<Vehicle> GetAll();

       Task<Vehicle> GetById(int id);

        Task<List<Vehicle>> GetByVehicleNumber(string number);

        Task<Vehicle> Add(Vehicle vehicle);

        Task<List<VehicleFuelQuota>> GetQoutaByType(int typeId);



    }
}
