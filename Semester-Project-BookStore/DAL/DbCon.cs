using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DbCon
    {
        SqlConnection sqlConnection;

        public DbCon()
        {
            sqlConnection = new SqlConnection("Data Source=DESKTOP-E4T9PG6;Initial Catalog=BookStore-VP;Integrated Security=True");
        }

        public bool UDI(string query)
        {
            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                bool check = sqlCommand.ExecuteNonQuery() > 0;

                return check;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }

        }

        public DataTable Search(string query)
        {
            try
            {
                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                sqlConnection.Close();

                if (dataTable.Rows.Count > 0)
                {
                    return dataTable;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }

        }
    }
}
