using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DBProject
{
    class DBHelper : IDisposable
    {
        private SqlConnection conn = new SqlConnection("data source=localhost;initial catalog=PropertyManagement;persist security info=True;Integrated Security=SSPI;");
        public DBHelper()
        {
            // Start and connect to Server
            conn.Open();
        }

        public int SimpleQuery(string query)
        {
            Console.WriteLine("SimpleQuery: " + query);
            SqlCommand command = new SqlCommand(query, conn);
            return command.ExecuteNonQuery();
        }
        public int? InsertQueryWID(string query)
        {
            Console.WriteLine("SimpleQuery: " + query + ";SELECT CAST(scope_identity() AS int);");
            SqlCommand command = new SqlCommand(query+ ";SELECT CAST(scope_identity() AS int);", conn);
            object tmp = command.ExecuteScalar();
            return (int)tmp;
        }

        public SqlDataReader GetQuery(string SelectQuery)
        {
            Console.WriteLine("GetQuery: " + SelectQuery);
            SqlCommand command = new SqlCommand(SelectQuery, conn);

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            Console.WriteLine("Reader: " + reader.HasRows);
            return reader;
        }

        public DataTable QueryDataTable(string query)
        {
            Console.WriteLine("QueryDataTable: " + query);
            SqlCommand command = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);

            da.Fill(dt);
            return dt;
        }
        public DataRow QueryDataRow(string query)
        {
            Console.WriteLine("QueryDataRow: " + query);
            SqlCommand command = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);

            da.Fill(dt);
            return dt.Rows[0];
        }

        public bool DataExists(string SelectQuery)
        {
            SqlCommand command = new SqlCommand(SelectQuery, conn);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            return reader.HasRows;
        }

        public void Dispose()
        {
            conn.Close();
        }

    }
}
