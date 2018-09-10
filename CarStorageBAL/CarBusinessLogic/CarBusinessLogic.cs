using System.Collections.Generic;
using CarStorage.DataLayer;
using CarStorage.Entities;

namespace CarStorageBAL
{
	public class CarBusinessLogic : ICarBusinessLogic
	{
		private static ICarRepository _ICarRepository;

		public CarBusinessLogic(string connectionString)
		{
			_ICarRepository = new CarRepository(connectionString);

		}
		public IEnumerable<Car> GetMainPageCars()
		{
			return _ICarRepository.GetMainPageCars();
		}
		public Car GetCarById(int id)
		{
			return _ICarRepository.Get(id);
		}
	}
}
