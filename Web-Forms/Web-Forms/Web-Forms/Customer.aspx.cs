using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class Customer : System.Web.UI.Page
    {
        DbCon dbCon = new DbCon();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Customers " +
                           "VALUES ('" + txtEmail.Text + "','" + txtFName.Text + "','" + txtLName.Text + "','" + txtPhone.Text +
                           "','" + txtAddress.Text + "','" + txtCity.Text + "'," + int.Parse(txtBalance.Text) + "," + int.Parse(txtOrders.Text) + ")";
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
            string query = "UPDATE Customers SET First_Name='" + txtFName.Text + "',Last_Name='" + txtLName.Text + "',Phone='" + txtPhone.Text +
                "',Address='" + txtAddress.Text + "',City='" + txtCity.Text + "',Balance=" + int.Parse(txtBalance.Text) +
                ",Orders=" + int.Parse(txtOrders.Text) + " WHERE Email='" + txtEmail.Text + "';";

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
            string query = "DELETE FROM Customers WHERE Email='" + txtEmail.Text + "'";

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
            string query = "SELECT * FROM Customers WHERE Email='" + txtEmail.Text + "'";

            DataTable dataTable = dbCon.Search(query);
            if (dataTable.Rows.Count > 0)
            {
                txtFName.Text = dataTable.Rows[0]["First_Name"].ToString();
                txtLName.Text = dataTable.Rows[0]["Last_Name"].ToString();
                txtPhone.Text = dataTable.Rows[0]["Phone"].ToString();
                txtAddress.Text = dataTable.Rows[0]["Address"].ToString();
                txtCity.Text = dataTable.Rows[0]["City"].ToString();
                txtBalance.Text = dataTable.Rows[0]["Balance"].ToString();
                txtOrders.Text = dataTable.Rows[0]["Orders"].ToString();

                lblInfo.Text = "Data Found!";
            }
            else
            {
                lblInfo.Text = "Data Not Found!";
            }
        }
    }
}