using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarStorage.DataLayer;
namespace CarStorage.BusinessLogic
{
  public static class MainPageCarsLogic
  {
    public static List<string> GetMainPageCars(string connectionString)
    {
      return MainPageDataLayer.GetMainPageCarsFromDB(connectionString);
    }
  }
}
