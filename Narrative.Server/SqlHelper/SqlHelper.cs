using Microsoft.Data.SqlClient;
using System.Data;

namespace Narrative.Server.SqlHelper
{
    public static class SqlHelper
    {
        static string connectionString = "Data Source=NARRATIVE;Initial Catalog=Narrative.Data;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Connect Timeout=60;Encrypt=True;Trust Server Certificate=False;Command Timeout=0";
        static SqlConnection? sqlConnection;

        public static int ExecuteNonQuery(string sqlQuery)
        {
            EstablishConnection();

            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            return sqlCommand.ExecuteNonQuery();
        }

        public static DataSet FillDataSet(string sqlQuery)
        {
            EstablishConnection();

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, sqlConnection))
            {
                DataSet dataSet = new DataSet();
                
                dataAdapter.Fill(dataSet);

                return dataSet;
            }
        }

        static void EstablishConnection()
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(connectionString);

                sqlConnection.Open();
            }
        }
    }
}
