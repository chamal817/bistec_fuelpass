using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IFuelRepository
    {
        Task<Fuel> AddFuelQty(Fuel qty);
        Task<int> GetWeeklyQty(DateTime startDate, DateTime endDate, int vehicleId);
        Task<int> GetVehicleQty(int typeId);


    }
}
