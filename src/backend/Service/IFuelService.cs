using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IFuelService
    {
        Task<Fuel> AddFuelQty(Fuel qty);
        Task<int> GetAvailabaleQty(DateTime startDate, DateTime endDate, int vehicleId, int typeId);
    }
}
