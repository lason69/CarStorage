using CarStorageDAL.Entities.Vehicle;

namespace CarStorage.Entities
{
	public class Car : Vehicle
	{
		public ExteriorType ExType { get; set; }
		public CylinderSettingType CylinderStgs { get; set; }
		public enum ExteriorType
		{
			Saloon,
			Hatchback,
			Van,
			MiniVan,
			Kombi,
			Cabrio,
			Coupe
		}
		public enum CylinderSettingType
		{
			R2,
			R4,
			R6,
			V2,
			V4,
			V6,
			V8,
			V12,
			V16,
			Boxer,
			VR4,
			VR6,
			W8,
		}

		public Car(int vehicleID, int ownerID)
		{
			VehicleID = vehicleID;
			OwnerID = ownerID;
		}
	}
}
