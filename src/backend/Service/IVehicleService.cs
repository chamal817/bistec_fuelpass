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

       Vehicle GetById(int id);

        List<Vehicle> GetByVehicleNumber(string number);

        void Add(Vehicle item);
    }
}
