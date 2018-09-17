using System.Collections.Generic;
using CarStorage.Entities;
using CarStorageBAL;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Examples;

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

    [HttpGet]
    public List<Car> Get()
    {
      return _carService.GetCarList();
    }
    //this method is only created for swagger tests so does not have any reasonable implementation yet
    [SwaggerRequestExample(typeof(Car), typeof(CarModelExample))]
    [HttpGet("{id:int}")]
    public Car GetById(Car car)
    {
      return car;
    }
  }
}
