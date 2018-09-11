using System.Collections.Generic;
using CarStorage.Entities;

public interface ICarRepository
{
	IEnumerable<Car> GetCar();
	Car FindCarById(int id);
}
