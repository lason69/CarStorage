using System.Collections.Generic;
using CarStorage.Entities;

namespace CarStorageBAL
{
	public interface ICarService
	{
		List<Car> GetCarList();
		Car FindCarById(int id);
	}
}
