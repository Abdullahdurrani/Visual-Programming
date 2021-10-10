using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class Product : System.Web.UI.Page
    {
        DbCon dbCon = new DbCon();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Products " +
                                           "VALUES (" + int.Parse(txtId.Text) + ",'" + txtTitle.Text + "','" + txtDescription.Text + "','" + txtCategory.Text +
                                           "','" + txtSubCategory.Text + "'," + int.Parse(txtPrice.Text) + "," + int.Parse(txtWeight.Text) + ",'" + txtColor.Text +
                                           "'," + int.Parse(txtItems.Text) + ")";
                if (dbCon.CUDI(query: query))
                {
                    lblInfo.Text = "Data Inserted!";
                }
                else
                {
                    lblInfo.Text = "Error Inserting Data!";
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Products SET Title='" + txtTitle.Text + "',Description='" + txtDescription.Text + "',Category='" + txtCategory.Text +
                "',SubCategory='" + txtSubCategory.Text + "',Price=" + int.Parse(txtPrice.Text) + ",Weight=" + int.Parse(txtPrice.Text) +
                ",Color='" + txtColor.Text + "',Items_Available=" + int.Parse(txtItems.Text) + " WHERE Id=" + int.Parse(txtId.Text) + ";";

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
            string query = "DELETE FROM Products WHERE Id=" + int.Parse(txtId.Text) + "";

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
            string query = "SELECT * FROM Products WHERE Id=" + int.Parse(txtId.Text) + "";

            DataTable dataTable = dbCon.Search(query);
            if (dataTable.Rows.Count > 0)
            {
                txtTitle.Text = dataTable.Rows[0]["Title"].ToString();
                txtDescription.Text = dataTable.Rows[0]["Description"].ToString();
                txtCategory.Text = dataTable.Rows[0]["Category"].ToString();
                txtSubCategory.Text = dataTable.Rows[0]["SubCategory"].ToString();
                txtPrice.Text = dataTable.Rows[0]["Price"].ToString();
                txtWeight.Text = dataTable.Rows[0]["Weight"].ToString();
                txtColor.Text = dataTable.Rows[0]["Color"].ToString();
                txtItems.Text = dataTable.Rows[0]["Items_Available"].ToString();

                lblInfo.Text = "Data Found!";
            }
            else
            {
                lblInfo.Text = "Data Not Found!";
            }
        }
    }
}