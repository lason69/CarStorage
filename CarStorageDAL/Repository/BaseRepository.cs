using System.Collections.Generic;
using System.Data.SqlClient;

public class BaseRepository<TEntity> where TEntity : class
{
	private static SqlConnection _connection;

	public BaseRepository(string connectionString)
	{
		_connection = new SqlConnection(connectionString);
	}
	public virtual TEntity PopulateRecord(SqlDataReader reader)
	{
		return null;
	}
	protected IEnumerable<TEntity> GetAll(SqlCommand command)
	{
		List<TEntity> resultList = new List<TEntity>();
		try
		{
			command.Connection = _connection;
			_connection.Open();

			var reader = command.ExecuteReader();
			try
			{
				while (reader.Read())
					resultList.Add(PopulateRecord(reader));
			}
			finally
			{
				reader.Close();
			}
		}
		finally
		{
			_connection.Close();
		}
		return resultList;
	}
	protected TEntity Get(SqlCommand command)
	{
		TEntity item = null;
		command.Connection = _connection;
		_connection.Open();
		try
		{
			var reader = command.ExecuteReader();
			try
			{
				while (reader.Read())
				{
					item = PopulateRecord(reader);
					break;
				}
			}
			finally
			{
				// Always call Close when done reading.
				reader.Close();
			}
		}
		finally
		{
			_connection.Close();
		}
		return item;
	}
}
