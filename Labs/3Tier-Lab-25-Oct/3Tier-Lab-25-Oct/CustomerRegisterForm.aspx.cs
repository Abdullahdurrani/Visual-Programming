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
    public partial class CustomerRegisterForm : System.Web.UI.Page
    {
        UserBLL userBLL = new UserBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Id = int.Parse(txtId.Text);
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;
            user.AccessLevel = 2;
            user.Address = txtAddress.Text;
            user.PhoneNumber = txtPhoneNumber.Text;
            if (txtAge.Text != "")
            {
                user.Age = int.Parse(txtAge.Text);
            }
            user.City = txtCity.Text;


            if (userBLL.UserInsertBLL(user))
            {
                Session["message"] = "Registered Successfully login to continue! ";
                Response.Redirect("~/LoginForm.aspx");
            }
            else
            {
                lblResult.Text = "Failed to Register User!";
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/LoginForm.aspx");
        }

    }
}