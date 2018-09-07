namespace CarStorageDAL.Entities.Vehicle
{
	class Bus : Vehicle
	{
		public int BusID { get; set; }
		public bool Articulated { get; set; }
		public int WheelAmount { get; set; }
		public int RoofsAmount { get; set; }
		public BusType BusT { get; set; }
		public enum BusType
		{
			Touristic,
			PKS,
			Urban
		}
	}
}
