using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebForms
{
    public class DbCon
    {
        string connection = "Data Source=DESKTOP-E4T9PG6;Initial Catalog=VP_Class;Integrated Security=True";

        public bool CUDI(string query)
        {
            SqlConnection sqlConnection = new SqlConnection(connection);
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public DataTable Search(string query)
        {
            string connection = "Data Source=DESKTOP-E4T9PG6;Initial Catalog=VP_Class;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            try
            {
                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}