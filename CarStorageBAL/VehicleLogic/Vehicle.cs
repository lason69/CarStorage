using System.Collections.Generic;
using CarStorage.DataLayer;
using CarStorage.Entities;

namespace CarStorageBAL
{
    public class Vehicle : IVehicle
    {
        private static IVehicleDataLayer _IVehicleDataLayer;
        private static string _connectionString;
        public Vehicle(string connectionString)
        {
            _IVehicleDataLayer = new VehicleDataLayer(connectionString);
            _connectionString = connectionString;
        }
        public List<Car> GetMainPageCars()
        {
            return _IVehicleDataLayer.GetMainPageCarsFromDB();
        }
    }
}
