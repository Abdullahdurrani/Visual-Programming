using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class Employee : System.Web.UI.Page
    {
        DbCon dbCon = new DbCon();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Employees " +
                           "VALUES ('" + txtEmail.Text + "','" + txtName.Text + "','" + txtPhone.Text + "','" + txtAge.Text +
                           "','" + txtEducation.Text + "'," + int.Parse(txtSalary.Text) + ",'" + txtDepartment.Text + "','" + txtPosition.Text + "')";
            if (dbCon.CUDI(query: query))
            {
                lblInfo.Text = "Data Inserted!";
            }
            else
            {
                lblInfo.Text = "Error Inserting Data!";
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Employees SET Name='" + txtName.Text + "',Cellphone='" + txtPhone.Text + "',Age='" + txtAge.Text +
                "',Education='" + txtEducation.Text + "',Salary=" + int.Parse(txtSalary.Text) + ",Department='" + txtDepartment.Text +
                "',Position='" + txtPosition.Text + "' WHERE Email='" + txtEmail.Text + "';";

            if (dbCon.CUDI(query: query))
            {
                lblInfo.Text = "Data Updated!";
            }
            else
            {
                lblInfo.Text = "Error Updating Data!";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Employees WHERE Email='" + txtEmail.Text + "'";

            if (dbCon.CUDI(query: query))
            {
                lblInfo.Text = "Data Deleted!";
            }
            else
            {
                lblInfo.Text = "Error Deleting Data!";
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Employees WHERE Email='" + txtEmail.Text + "'";

            DataTable dataTable = dbCon.Search(query);
            if (dataTable.Rows.Count > 0)
            {
                txtName.Text = dataTable.Rows[0]["Name"].ToString();
                txtPhone.Text = dataTable.Rows[0]["Cellphone"].ToString();
                txtAge.Text = dataTable.Rows[0]["Age"].ToString();
                txtEducation.Text = dataTable.Rows[0]["Education"].ToString();
                txtSalary.Text = dataTable.Rows[0]["Salary"].ToString();
                txtDepartment.Text = dataTable.Rows[0]["Department"].ToString();
                txtPosition.Text = dataTable.Rows[0]["Position"].ToString();

                lblInfo.Text = "Data Found!";
            }
            else
            {
                lblInfo.Text = "Data Not Found!";
            }
        }
    }
}
