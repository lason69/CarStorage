using CarStorage.Entities;
using CarStorage.SwaggerExamples;
using CarStorageDAL.Entities.Enum;

public class CarModelExample : ICarProvider
{
  public Car GetExamples()
  {
    return

      new Car
      {
        VehicleID = 1,
        City = "Testcity",
        OwnerID = 1,
        CylinderStgs = CylinderSettingType.V6

      };
  }
}
