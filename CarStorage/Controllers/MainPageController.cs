using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CarStorage.BusinessLogic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using ConnectionStringsSpace;
namespace CarStorage
{

  [Route("api/[controller]")]
  public class MainPageController : Controller
  {
    private readonly IConfiguration _configuration;

    public MainPageController(IConfiguration config)
    {
      this._configuration = config;
    }

    [HttpGet]
    public IEnumerable<string> GetMainPageCars()
    {
      return MainPageCarsLogic.GetMainPageCars(_configuration["CarStorageDBConnectionString"]);
    }
  }
}

