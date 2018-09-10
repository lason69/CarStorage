using System;

namespace CarStorageDAL.Entities.Owner
{
	public class Owner
	{
		public int OwnerID { get; set; }
		public string EmailAddress { get; set; }
		public string PhoneNumber { get; set; }
		public DateTime DateAdded { get; set; }

	}
}
