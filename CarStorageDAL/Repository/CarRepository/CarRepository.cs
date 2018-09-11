using System.Collections.Generic;
using System.Data.SqlClient;
using CarStorage.Entities;
using CarStorageDAL.Repository;

namespace CarStorage.DataLayer
{
	public class CarRepository : IRepository<Car>
	{
		private SqlConnection _connection;
		public CarRepository(string connectionString)
		{
			_connection = new SqlConnection(connectionString);
		}

		private Car PopulateRecord(SqlDataReader reader)
		{
			return new Car(reader.GetInt32(0), reader.GetInt32(2));
		}
		public IEnumerable<Car> Get()
		{
			var command = new SqlCommand("dbo.GetLatestCars");

			List<Car> resultList = new List<Car>();
			try
			{
				command.Connection = _connection;
				_connection.Open();

				var reader = command.ExecuteReader();
				try
				{
					while (reader.Read())
						resultList.Add(PopulateRecord(reader));
				}
				finally
				{
					reader.Close();
				}
			}
			finally
			{
				_connection.Close();
			}
			return resultList;
		}
		public Car FindById(int id)
		{
			var command = new SqlCommand("dbo.GetCarByID");

			Car item = null;
			command.Connection = _connection;
			_connection.Open();
			try
			{
				var reader = command.ExecuteReader();
				try
				{
					while (reader.Read())
					{
						item = PopulateRecord(reader);
						break;
					}
				}
				finally
				{
					// Always call Close when done reading.// Always call Close when done reading.
					reader.Close();
				}
			}

			finally
			{
				_connection.Close();
			}
			return item;
		}
	}
}
