using System;
using System.Collections.Generic;

namespace CarStorageDAL.Entities.Vehicle
{
	public abstract class Vehicle
	{
		public int VehicleID { get; set; }
		public int OwnerID { get; set; }
		public List<VehiclePhoto> VehiclePhotoList { get; set; }
		public VehicleGeneralInformation VehicleInformation { get; set; }
		public VehicleEngineDetails VehicleEngineDetails { get; set; }
		public DateTime DateAdded { get; set; }
		public string Country { get; set; }
		public string City { get; set; }
	}
}
