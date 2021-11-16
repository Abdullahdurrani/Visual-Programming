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
    public partial class EmployeePanelForm : System.Web.UI.Page
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
                    case 2:
                        Response.Redirect("~/CustomerPanelForm.aspx");
                        break;
                    case 3:
                        Response.Redirect("~/SupplierPanelForm.aspx");
                        break;
                }
            }
            else
            {
                Response.Redirect("LoginForm.aspx");
            }
            LoadGridView();
            LoadGridViewUser();
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Id = int.Parse(txtId.Text);
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;
            user.AccessLevel = int.Parse(txtAccessLevel.Text);
            if (user.AccessLevel == 0 || user.AccessLevel == 1)
            {
                Response.Redirect("~/EmployeePanelForm.aspx");
            }
            
            user.Address = txtAddress.Text;
            user.PhoneNumber = txtPhoneNumber.Text;
            if (txtSalary.Text != "")
            {
                user.Salary = int.Parse(txtSalary.Text);
            }
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
            user.Department = txtDepartment.Text;
            user.Position = txtPosition.Text;

            if (userBLL.UserInsertBLL(user))
            {
                lblResult.Text = "User Added";
            }
            else
            {
                lblResult.Text = "Failed Add User";
            }
            LoadGridView();
        }
        private void LoadGridView()
        {
            gridViewUser.DataSource = userBLL.UserGetLimitedBLL();
            gridViewUser.DataBind();
        }
        private void LoadGridViewUser()
        {
            int id = Convert.ToInt32(Session["Id"]);
            User user = new User();
            user.Id = id;
            gridView.DataSource = userBLL.UserGetBLL(user);
            gridView.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Id = int.Parse(txtId.Text);
            user.Password = txtPassword.Text;

            if (userBLL.UserGetBLL(user) != null)
            {
                DataTable dataTable = userBLL.UserGetBLL(user);

                if (dataTable.Rows.Count > 0)
                {
                    txtFirstName.Text = dataTable.Rows[0]["FirstName"].ToString();
                    txtLastName.Text = dataTable.Rows[0]["LastName"].ToString();
                    txtEmail.Text = dataTable.Rows[0]["Email"].ToString();
                    txtPassword.Text = dataTable.Rows[0]["Password"].ToString();
                    int accessLevel = int.Parse(dataTable.Rows[0]["AccessLevel"].ToString());
                    if(accessLevel == 0 || accessLevel == 1)
                    {
                        Response.Redirect("~/EmployeePanelForm.aspx");
                    }
                    txtAccessLevel.Text = dataTable.Rows[0]["AccessLevel"].ToString();
                    txtAddress.Text = dataTable.Rows[0]["Address"].ToString();
                    txtPhoneNumber.Text = dataTable.Rows[0]["PhoneNumber"].ToString();
                    txtSalary.Text = dataTable.Rows[0]["Salary"].ToString();
                    txtAge.Text = dataTable.Rows[0]["Age"].ToString();
                    txtBalance.Text = dataTable.Rows[0]["Balance"].ToString();
                    txtCity.Text = dataTable.Rows[0]["City"].ToString();
                    txtOrders.Text = dataTable.Rows[0]["Orders"].ToString();
                    txtDepartment.Text = dataTable.Rows[0]["Department"].ToString();
                    txtPosition.Text = dataTable.Rows[0]["Position"].ToString();

                    lblResult.Text = "User Data Found!";
                }
            }
            else
            {
                lblResult.Text = "Failed to Search User Data!";
            }

            LoadGridView();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Id = int.Parse(txtId.Text);

            DataTable dataTable = userBLL.UserGetBLL(user);
            if (dataTable.Rows.Count > 0)
            {
                int accessLevel = int.Parse(dataTable.Rows[0]["AccessLevel"].ToString());
                if (accessLevel == 0 || accessLevel == 1)
                {
                    Response.Redirect("~/EmployeePanelForm.aspx");
                }
            }
            
            if (userBLL.UserDeleteBLL(user))
            {
                lblResult.Text = "User Deleted!";
            }
            else
            {
                lblResult.Text = "Failed to Delete User";
            }
            LoadGridView();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Id = int.Parse(txtId.Text);
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;
            user.AccessLevel = int.Parse(txtAccessLevel.Text);
            if (user.AccessLevel == 0 || user.AccessLevel == 1)
            {
                Response.Redirect("~/EmployeePanelForm.aspx");
            }
            
            user.Address = txtAddress.Text;
            user.PhoneNumber = txtPhoneNumber.Text;
            if (txtSalary.Text != "")
            {
                user.Salary = int.Parse(txtSalary.Text);
            }
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
            user.Department = txtDepartment.Text;
            user.Position = txtPosition.Text;

            if (userBLL.UserUpdateBLL(user))
            {
                lblResult.Text = "User Data Updated!";
            }
            else
            {
                lblResult.Text = "Failed to Update User Data";
            }
            LoadGridView();
        }
    }
}