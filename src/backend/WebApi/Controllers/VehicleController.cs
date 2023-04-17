using Entity;
using Microsoft.AspNetCore.Mvc;
using Service;
using System;

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
        [Route("vehicleGetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _service.GetById(id));
        }

        [HttpGet]
        [Route("checkVehicle/{vehicleNumber}")]
        public async Task<IActionResult> GetByVehicleNumber(string vehicleNumber)
        {
            return Ok(_service.GetByVehicleNumber(vehicleNumber));
        }

        [HttpPost]
        [Route("addvehicle")]
        public async Task<IActionResult> Add(Vehicle vehicle)
        {
            var result = await _service.Add(vehicle);
            return Ok(result);
        }
        [HttpGet]
        [Route("GetQoutaByType/{typeId}")]
        public async Task<IActionResult> GetQoutaByType(int typeId)
        {
            return Ok( await _service.GetQoutaByType(typeId));
        }


    }
}
