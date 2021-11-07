using System;
using System.Data;
using AppProps;
using BLL;

namespace _3Tier_Lab_25_Oct
{
    public partial class LoginForm : System.Web.UI.Page
    {
        UserBLL userBLL = new UserBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Id = int.Parse(txtId.Text);
            user.Password = txtPassword.Text;

            if (userBLL.UserSearchBLL(user) != null)
            {
                DataTable dataTable = userBLL.UserSearchBLL(user);


                if (dataTable.Rows.Count > 0)
                {
                    int accessLevel = int.Parse(dataTable.Rows[0]["AccessLevel"].ToString());
                    Session["Id"] = dataTable.Rows[0]["Id"].ToString();
                    Session["access_level"] = dataTable.Rows[0]["AccessLevel"].ToString();

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
                        case 3:
                            Response.Redirect("~/SupplierPanelForm.aspx");
                            break;
                        default:
                            Response.Redirect("~/LoginForm.aspx");
                            break;
                    }
                }
            }
            else
            {
                lblResult.Text = "User Id or password incorrect";
            }

        }


        protected void btnRegisterAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdminRegister.aspx");
        }

        protected void btnRegisterEmployee_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EmployeeRegisterForm.aspx");
        }

        protected void btnRegisterCustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CustomerRegisterForm.aspx");
        }

        protected void btnRegisterSupplier_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SupplierRegisterForm.aspx");
        }
    }
}