using System;
using System.Collections.Generic;
using System.Text;

namespace CarStorageDAL.Entities.Vehicle
{
  public  class AdditionalEquipment
    {
        public int EquipmentID { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }

    }
}
