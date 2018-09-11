using System.Collections.Generic;
using CarStorage.Entities;

namespace CarStorageBAL
{
	public interface ICarService
	{
		IEnumerable<Car> GetCarList();
		Car FindCarById(int id);
	}
}
