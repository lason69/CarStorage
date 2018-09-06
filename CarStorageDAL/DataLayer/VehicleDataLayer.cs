using System.Collections.Generic;
using CarStorage.Entities;

namespace CarStorage.DataLayer
{
	public class VehicleDataLayer : IVehicleDataLayer
	{
		private static string _connectionString;
		public VehicleDataLayer(string connectionString)
		{
			_connectionString = connectionString;
		}
		public List<Car> GetMainPageCarsFromDB()
		{
			List<Car> resultList = new List<Car>();
			//using (SqlConnection connection =
			//  new SqlConnection(_connectionString))
			//{
			//    SqlCommand command = new SqlCommand("dbo.GetLatestCars", connection);
			//    connection.Open();
			//    var reader = command.ExecuteReader();
			//    while (reader.Read())
			//    {
			//        resultList.Add(new Car
			//          (int.Parse(reader["Id"].ToString()),
			//          reader["PhotoDirectoryId"].ToString()));
			//    }
			//    connection.Close();
			//}
			return resultList;
		}
	}
}
