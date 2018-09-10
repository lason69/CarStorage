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
    private static ICarBusinessLogic _iCarBusinessLogic;

    public HomePageController(IConfiguration config)
    {
      _configuration = config;
      _iCarBusinessLogic = new CarBusinessLogic(_configuration["CarStorageDBConnectionString"]);
    }

    [HttpGet]
    public IEnumerable<Car> GetMainPageCars()
    {
      return _iCarBusinessLogic.GetMainPageCars();
    }
  }
}
