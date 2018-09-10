using System.Collections.Generic;
using System.Data.SqlClient;
using CarStorage.Entities;


namespace CarStorage.DataLayer
{
	public class CarRepository : BaseRepository<Car>, ICarRepository
	{
		public CarRepository(string connectionString) :
			base(connectionString)
		{

		}
		public IEnumerable<Car> GetMainPageCars()
		{
			using (var command = new SqlCommand("dbo.GetLatestCars"))
			{
				return GetAll(command);
			}
		}
		public Car Get(int id)
		{
			using (var command = new SqlCommand("dbo.GetCarByID"))
			{
				command.Parameters.Add(new SqlParameter("id", id));
				return Get(command);
			}
		}
		public override Car PopulateRecord(SqlDataReader reader)
		{
			return new Car(reader.GetInt32(0), reader.GetInt32(2));
		}
	}
}
