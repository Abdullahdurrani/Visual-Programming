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

    public partial class EmployeeRegisterForm : System.Web.UI.Page
    {
        UserBLL userBLL = new UserBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Id"] != null)
            {
                int accessLevel = Convert.ToInt32(Session["access_level"]);
                switch (accessLevel)
                {
                    case 1:
                        Response.Redirect("~/EmployeePanelForm.aspx");
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
            user.Address = txtAddress.Text;
            user.PhoneNumber = txtPhoneNumber.Text;
            user.Salary = int.Parse(txtSalary.Text);
            user.Age = int.Parse(txtAge.Text);
            user.City = txtCity.Text;
            user.Department = txtDepartment.Text;
            user.Position = txtPosition.Text;


            if (userBLL.UserInsertBLL(user))
            {
                lblResult.Text = "User Added!";
            }
            else
            {
                lblResult.Text = "Failed to Add User!";
            }
            LoadGridView();
        }

        private void LoadGridView()
        {
            gridViewUser.DataSource = userBLL.UserGetAllBLL();
            gridViewUser.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Id = int.Parse(txtId.Text);

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
            user.Address = txtAddress.Text;
            user.PhoneNumber = txtPhoneNumber.Text;
            user.Salary = int.Parse(txtSalary.Text);
            user.Age = int.Parse(txtAge.Text);
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

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Id = int.Parse(txtId.Text);

            if (userBLL.UserSearchBLL(user) != null)
            {
                DataTable dataTable = userBLL.UserSearchBLL(user);

                if (dataTable.Rows.Count > 0)
                {
                    txtFirstName.Text = dataTable.Rows[0]["FirstName"].ToString();
                    txtLastName.Text = dataTable.Rows[0]["LastName"].ToString();
                    txtEmail.Text = dataTable.Rows[0]["Email"].ToString();
                    txtPassword.Text = dataTable.Rows[0]["Password"].ToString();
                    txtAccessLevel.Text = dataTable.Rows[0]["AccessLevel"].ToString();
                    txtAddress.Text = dataTable.Rows[0]["Address"].ToString();
                    txtPhoneNumber.Text = dataTable.Rows[0]["PhoneNumber"].ToString();
                    txtSalary.Text = dataTable.Rows[0]["Salary"].ToString();
                    txtAge.Text = dataTable.Rows[0]["Age"].ToString();
                    txtCity.Text = dataTable.Rows[0]["City"].ToString();
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
    }
}