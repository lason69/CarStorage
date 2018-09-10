using System.Collections.Generic;
using CarStorage.Entities;

namespace CarStorageBAL
{
	public interface ICarBusinessLogic
	{
		IEnumerable<Car> GetMainPageCars();
		Car GetCarById(int id);
	}
}
