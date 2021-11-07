using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppProps;
using BLL;

namespace _3Tier_Lab_25_Oct
{
    public partial class AdminRegister : System.Web.UI.Page
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
    }
}