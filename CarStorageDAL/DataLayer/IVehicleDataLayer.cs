using CarStorage.Entities;
using System.Collections.Generic;

namespace CarStorage.DataLayer
{
  public interface IVehicleDataLayer
  {
     List<Car> GetMainPageCarsFromDB();
  }
}
