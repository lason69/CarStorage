using System.Collections.Generic;
using CarStorage.DataLayer;
using CarStorage.Entities;
using CarStorageDAL.Repository;
using Connections;
using Microsoft.Extensions.Options;

namespace CarStorageBAL
{
	public class CarService : ICarService
	{
		private IRepository<Car> _carRepository;
		private ConnectionStrings _dbConnectionStrings;

		public CarService(IOptions<ConnectionStrings> dbConnectionsString)
		{
			_dbConnectionStrings = dbConnectionsString.Value;

			_carRepository = new CarRepository(_dbConnectionStrings.CarStorageDBConnectionString);
		}
		public List<Car> GetCarList()
		{
			return _carRepository.Get();
		}
		public Car FindCarById(int id)
		{
			return _carRepository.FindById(id);
		}
	}
}
