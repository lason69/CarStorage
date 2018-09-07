using System.Collections.Generic;

namespace CarStorageDAL.Entities.Vehicle
{
	public class VehicleGeneralInformation
	{
		public string Description { get; set; }
		public string Manufacturer { get; set; }
		public string Model { get; set; }
		public string ProductionYear { get; set; }
		public int SeatAmount { get; set; }
		public int DoorsAmount { get; set; }
		public int OwnerInARow { get; set; }
		public Color VehicleColor { get; set; }
		public string OriginCountry { get; set; }
		public List<AdditionalEquipment> AdditionalEquipment { get; set; }
		public OwnerType OwnerT { get; set; }
		public VehicleStatus VehicleStat { get; set; }
	}
}
