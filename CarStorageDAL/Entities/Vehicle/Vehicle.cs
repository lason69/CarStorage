using System;
using System.Collections.Generic;

namespace CarStorageDAL.Entities.Vehicle
{
	public abstract class Vehicle
	{
		public int VehicleID { get; set; }
		public string OwnerID { get; set; }
		public List<VehiclePhoto> VehiclePhotoList { get; set; }
		public DateTime DateAdded { get; set; }
		public DateTime DateLastModified { get; set; }
		public string Description { get; set; }
		public int Power { get; set; }
		public string Manufacturer { get; set; }
		public string Model { get; set; }
		public string ProductionYear { get; set; }
		public int SeatAmount { get; set; }
		public int DoorsAmount { get; set; }
		public int OwnerInARow { get; set; }
		public FuelType FuelT { get; set; }
		public string OriginCountry { get; set; }
		public Color Col { get; set; }
		public double EngineCapacity { get; set; }
		public List<AdditionalEquipment> AdditionalEquipment { get; set; }
		public OwnerType OwnerT { get; set; }
		public VehicleStatus VehicleStat { get; set; }

		public enum FuelType
		{
			PB,
			Diesel,
			LPG,
			Hybrid,
			Electric,
			Other

		}
		public enum Color
		{
			Yellow,
			Black,
			Green,
			Red
		}
		public enum OwnerType
		{
			Company,
			Private
		}
		public enum VehicleStatus
		{
			New,
			Used,
			Damaged
		}
	}
}
