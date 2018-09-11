using CarStorageDAL.Entities.Enum;

namespace CarStorageDAL.Entities.Vehicle
{
	public class VehicleEngineDetails
	{
		public double EngineCapacity { get; set; }
		public int Power { get; set; }
		public FuelType FuelT { get; set; }
		public PowerTrainType PowerTrainT { get; set; }
	}
}
