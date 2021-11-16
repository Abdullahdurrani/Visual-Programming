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
                Response.Redirect("~/LoginForm.aspx");
            }
            else
            {
                lblResult.Text = "Failed to Add User!";
            }
            
        }

    }
}