using System;

namespace CarStorageDAL.Entities.Owner
{
	public class Owner
	{
		public int OwnerID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime BirthDate { get; set; }
		public Address Address { get; set; }
		public string EmailAddress { get; set; }
		public string PhoneNumber { get; set; }
		public DateTime DateAdded { get; set; }
		public DateTime DateLastModified { get; set; }
	}
}
