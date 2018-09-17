using CarStorageDAL.Entities.Enum;
using CarStorageDAL.Entities.Vehicle;

namespace CarStorage.Entities
{
	public class Car : Vehicle
	{
		public ExteriorType ExType { get; set; }
		public CylinderSettingType CylinderStgs { get; set; }
		public Car()
		{
		}
		public Car(int vehicleID, int ownerID)
		{
			VehicleID = vehicleID;
			OwnerID = ownerID;
		}
	}
}
