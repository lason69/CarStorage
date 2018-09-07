using System;
using System.Collections.Generic;

namespace CarStorageDAL.Entities.Vehicle
{
	public abstract class Vehicle
	{
		public int VehicleID { get; set; }
		public string OwnerID { get; set; }
		public List<VehiclePhoto> VehiclePhotoList { get; set; }
		public VehicleGeneralInformation VehicleInformation { get; set; }
		public VehicleEngineDetails VehicleEngineDetails { get; set; }
		public DateTime DateAdded { get; set; }
		public DateTime DateLastModified { get; set; }

	}
}
