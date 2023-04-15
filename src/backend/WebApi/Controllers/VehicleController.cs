using Entity;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace WebApi.Controllers
{
    [Route("api/vehicle")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _service;

        public VehicleController(IVehicleService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("allVehicle")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_service.GetAll());
        }
        [HttpGet]
        [Route("vehicle/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_service.GetById(id));
        }

        [HttpGet]
        [Route("checkVehicle/{vehicleNumber}")]
        public async Task<IActionResult> GetByVehicleNumber(string vehicleNumber)
        {
            return Ok(_service.GetByVehicleNumber(vehicleNumber));
        }

        [HttpPost]
        [Route("addvehicle")]
        public void AddProduct(Vehicle vehicle)
        {
            _service.Add(vehicle);
        }
    }
}
