using System.Collections.Generic;
using CarStorageDAL.Entities.Vehicle;

namespace CarStorage.Entities
{
	public class Car : Vehicle
	{
		public int CarID { get; set; }
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

		public Car(int vehicleID, int carID, ExteriorType exType, CylinderSettingType cylinderStgs, List<VehiclePhoto> carPhotos)
		{
			this.VehicleID = vehicleID;
			CarID = carID;
			ExType = exType;
			CylinderStgs = cylinderStgs;
			VehiclePhotoList = carPhotos;
		}
	}
}
