using CarStorage.Entities;
using System.Collections.Generic;

namespace CarStorageBAL
{
    public interface IVehicle
    {
        List<Car> GetMainPageCars();
    }
}
