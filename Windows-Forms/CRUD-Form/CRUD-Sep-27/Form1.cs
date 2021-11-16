using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Sep_27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {

            string query = "Insert into Users(Name,Email,Cellphone) values ('" + textBoxName.Text + "','" + textBoxEmail.Text + "','" + textBoxCellphone.Text + "')";
            string connection = @"Data Source=DESKTOP-E4T9PG6;Initial Catalog=VP_CLASS;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connection);
            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Data Added!");
                }
                else
                {
                    MessageBox.Show("Failed to Add Data!");
                }
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

        private void buttonSelect_Click(object sender, EventArgs e)
        {

            string query = "Select * from Users where Email='"+textBoxEmail.Text+"'";
            string connection = @"Data Source=DESKTOP-E4T9PG6;Initial Catalog=VP_CLASS;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connection);
            try
            {
                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);   
                
                if (dataTable.Rows.Count > 0)
                {
                    textBoxName.Text = dataTable.Rows[0]["Name"].ToString();
                    textBoxCellphone.Text = dataTable.Rows[0]["Cellphone"].ToString();
                } else
                {
                    MessageBox.Show("Record Not Found");
                }
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            string query = "Update Users Set Name='" + textBoxName.Text + "',Cellphone='" + textBoxCellphone.Text + "' where Email='" + textBoxEmail.Text + "';";
            string connection = @"Data Source=DESKTOP-E4T9PG6;Initial Catalog=VP_CLASS;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connection);
            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Data Updated!");
                }
                else
                {
                    MessageBox.Show("Failed to Update Data!");
                }
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            string query = "Delete from Users where Email='" + textBoxEmail.Text + "'";
            string connection = @"Data Source=DESKTOP-E4T9PG6;Initial Catalog=VP_CLASS;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connection);
            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Data Deleted!");
                }
                else
                {
                    MessageBox.Show("Failed to Delete Data!");
                }
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
