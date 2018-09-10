using System.Collections.Generic;
using CarStorage.Entities;

public interface ICarRepository
{
	IEnumerable<Car> GetMainPageCars();
	Car Get(int id);
}
