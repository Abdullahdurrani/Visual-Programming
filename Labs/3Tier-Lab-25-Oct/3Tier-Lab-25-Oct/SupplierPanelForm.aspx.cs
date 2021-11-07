using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppProps;
using BLL;

namespace _3Tier_Lab_25_Oct
{
    public partial class SupplierPanelForm : System.Web.UI.Page
    {
        UserBLL userBLL = new UserBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Id"] != null)
            {
                int accessLevel = Convert.ToInt32(Session["access_level"]);
                switch (accessLevel)
                {
                    case 0:
                        Response.Redirect("~/AdminPanelForm.aspx");
                        break;
                    case 1:
                        Response.Redirect("~/EmployeePanelForm.aspx");
                        break;
                    case 2:
                        Response.Redirect("~/CustomerPanelForm.aspx");
                        break;
                }
            }
            else
            {
                Response.Redirect("LoginForm.aspx");
            }

            LoadGridViewUser();
            GetData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Id = int.Parse(txtId.Text);

            if (userBLL.UserDeleteBLL(user))
            {
                Session["message"] = "Your account was deleted successfully! ";
                Response.Redirect("~/LoginForm.aspx");
            }
            else
            {
                lblResult.Text = "Failed to Delete User";
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Id = int.Parse(txtId.Text);
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;
            user.AccessLevel = 3;

            user.Address = txtAddress.Text;
            user.PhoneNumber = txtPhoneNumber.Text;
            if (txtBalance.Text != "")
            {
                user.Balance = float.Parse(txtBalance.Text);
            }
            if (txtAge.Text != "")
            {
                user.Age = int.Parse(txtAge.Text);
            }
            if (txtOrders.Text != "")
            {
                user.Orders = int.Parse(txtOrders.Text);
            }

            user.City = txtCity.Text;

            if (userBLL.UserUpdateBLL(user))
            {
                lblResult.Text = "User Data Updated!";
            }
            else
            {
                lblResult.Text = "Failed to Update User Data";
            }
            LoadGridViewUser();
        }

        private void LoadGridViewUser()
        {
            int id = Convert.ToInt32(Session["Id"]);
            User user = new User();
            user.Id = id;
            gridView.DataSource = userBLL.UserGetBLL(user);
            gridView.DataBind();
        }

        private void GetData()
        {
            User user = new User();

            int id = Convert.ToInt32(Session["Id"]);
            user.Id = id;

            if (userBLL.UserGetBLL(user) != null)
            {
                DataTable dataTable = userBLL.UserGetBLL(user);

                if (dataTable.Rows.Count > 0)
                {
                    txtId.Text = id.ToString();
                    txtFirstName.Text = dataTable.Rows[0]["FirstName"].ToString();
                    txtLastName.Text = dataTable.Rows[0]["LastName"].ToString();
                    txtEmail.Text = dataTable.Rows[0]["Email"].ToString();
                    txtPassword.Text = dataTable.Rows[0]["Password"].ToString();
                    txtAddress.Text = dataTable.Rows[0]["Address"].ToString();
                    txtPhoneNumber.Text = dataTable.Rows[0]["PhoneNumber"].ToString();
                    txtAge.Text = dataTable.Rows[0]["Age"].ToString();
                    txtBalance.Text = dataTable.Rows[0]["Balance"].ToString();
                    txtCity.Text = dataTable.Rows[0]["City"].ToString();
                    txtOrders.Text = dataTable.Rows[0]["Orders"].ToString();

                    lblResult.Text = "User Data Found!";
                }
            }
            else
            {
                lblResult.Text = "Failed to Search User Data!";
            }
        }
    }
}