using System.Collections.Generic;
using CarStorage.Entities;
using CarStorageBAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CarStorage
{

  [Route("api/[controller]")]
  public class HomePageController : Controller
  {
    private readonly IConfiguration _configuration;
    private static IVehicle _iVehicle;

    public HomePageController(IConfiguration config)
    {
      this._configuration = config;
      _iVehicle = new Vehicle(_configuration["CarStorageDBConnectionString"]);
    }

    [HttpGet]
    public IEnumerable<Car> GetMainPageCars()
    {
      return _iVehicle.GetMainPageCars();
    }
  }
}
