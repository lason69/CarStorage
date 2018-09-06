using System;
using System.Collections.Generic;
using System.Text;

namespace CarStorageDAL.Entities.Vehicle
{
    public class VehiclePhoto
    {
        public string PhotoGuid { get; set; }
        public int VehicleID { get; set; }
        public string LocationPath { get; set; }
        public string PhotoName { get; set; }
        public int OwnerID { get; set; }
    }
}
