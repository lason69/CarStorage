using System.Collections.Generic;
using CarStorage.Entities;
using CarStorageBAL;
using Microsoft.AspNetCore.Mvc;

namespace CarStorage.Controllers
{
  [Route("api/[controller]")]
  public class CarController : Controller
  {
    private static ICarService _carService;

    public CarController(ICarService carService)
    {
      _carService = carService;
    }

    [HttpGet("GetCarList")]
    public IEnumerable<Car> GetCarList()
    {
      return _carService.GetCarList();
    }
  }
}
