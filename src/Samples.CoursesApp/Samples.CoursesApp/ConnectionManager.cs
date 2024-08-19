using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Samples.CoursesApp
{
	internal sealed class ConnectionManager
	{
		internal static SqlConnection GetConnection()
		{
			string connectionString = ConfigurationManager.ConnectionStrings["Courses"].ConnectionString;
			SqlConnection connection = new SqlConnection(connectionString);
			return connection;
		}
	}
}
