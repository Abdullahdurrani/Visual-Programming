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

namespace EmployeeApp
{
    public partial class Form1 : Form
    {


        void ConnectionDatabase(string query, string success, string fail)
        {

            string connection = "Data Source=DESKTOP-E4T9PG6;Initial Catalog=VP_CLASS;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show(success);
                }
                else
                {
                    MessageBox.Show(fail);
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
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            
            string query = "SELECT * FROM Employees WHERE Email='" + textBoxEmail.Text + "'";
            string connection = "Data Source=DESKTOP-E4T9PG6;Initial Catalog=VP_CLASS;Integrated Security=True";

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
                    textBoxAge.Text = dataTable.Rows[0]["Age"].ToString();
                    textBoxEducation.Text = dataTable.Rows[0]["Education"].ToString();
                    textBoxSalary.Text = dataTable.Rows[0]["Salary"].ToString();
                    textBoxDepartment.Text = dataTable.Rows[0]["Department"].ToString();
                    textBoxPosition.Text = dataTable.Rows[0]["Position"].ToString();
                }
                else
                {
                    MessageBox.Show("Record Not Found!");
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

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Employees(Email,Name,Cellphone,Age,Education,Salary,Department,Position) " +
                           "VALUES ('" + textBoxEmail.Text + "','" + textBoxName.Text + "','" + textBoxCellphone.Text + "'," + int.Parse(textBoxAge.Text) + ",'" + textBoxEducation.Text + 
                           "'," + int.Parse(textBoxSalary.Text) + ",'" + textBoxDepartment.Text + "','" + textBoxPosition.Text + "')";
            ConnectionDatabase(query: query, success: "Data Added!", fail: "Failed to Add Data!");
            
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Employees SET Name='" + textBoxName.Text + "',Cellphone='" + textBoxCellphone.Text + "',Age=" + int.Parse(textBoxAge.Text) +
                           ",Education='" + textBoxEducation.Text + "',Salary='" + textBoxSalary.Text + "',Department='" + textBoxDepartment.Text + 
                           "',Position='" + textBoxPosition.Text + "' WHERE Email='" + textBoxEmail.Text + "';";

            ConnectionDatabase(query: query, success: "Data Updated!", fail: "Failed to Update Data");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Employees WHERE Email='" + textBoxEmail.Text + "'";

            ConnectionDatabase(query: query, success: "Data Deleted!", fail: "Failed to Delete Data!");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxEmail.Text = "";
            textBoxName.Text = "";
            textBoxCellphone.Text = "";
            textBoxAge.Text = "";
            textBoxEducation.Text = "";
            textBoxSalary.Text = "";
            textBoxDepartment.Text = "";
            textBoxPosition.Text = "";
        }
    }
}
