using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace CarStorage.DataLayer
{
  public static class MainPageDataLayer
  {

    public static List<string> GetMainPageCarsFromDB(string connectionString)
    {
      List<string> resultList = new List<string>();
      resultList.Add(@"C:\Users\Jacek_Lason\source\repos\CarStorage\CarStorage\Cars\1.jpg");
      resultList.Add(@"C:\Users\Jacek_Lason\source\repos\CarStorage\CarStorage\Cars\2.jpg");
      //using (SqlConnection connection =
      //  new SqlConnection(connectionString))
      //{

      //  SqlCommand command = new SqlCommand("ProcedureName", connection);

      //  using (SqlDataAdapter da = new SqlDataAdapter(command))
      //  {
      //    // Fill the DataSet using default values for DataTable names, etc
      //    DataSet dataset = new DataSet();
      //    da.Fill(dataset);

      //  }

      //  command.Connection.Open();
      //  command.ExecuteNonQuery();

      //  connection.Close();
      //}

      return resultList;
    }
  }
}
