using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace WebApi.Controllers
{
    [Route("api/fuel")]
    [ApiController]
    public class FuelController : ControllerBase
    {
        private readonly IFuelService _fservice;


        public FuelController(IFuelService fservice)
        {
            _fservice = fservice;

        }

        [HttpPost]
        [Route("fuelQty")]
        public async Task<IActionResult> FuelQty(Fuel qty)
        {
            return Ok(await _fservice.AddFuelQty(qty));
        }

        [HttpGet]
        [Route("GetAvailableQty")]
        public async Task<IActionResult> GetAvailableQty(DateTime startDate, DateTime endDate, int vehicleId, int typeId)
        {
            var result = await _fservice.GetAvailabaleQty(startDate, endDate, vehicleId, typeId);
            return Ok(result);
        }
    }
}
