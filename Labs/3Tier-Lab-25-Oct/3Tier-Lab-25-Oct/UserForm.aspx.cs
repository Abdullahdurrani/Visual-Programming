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
    public partial class UserForm : System.Web.UI.Page
    {
        UserBLL userBLL = new UserBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //AppProps.User user = new AppProps.User();
            User user = new User();
            
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.Email = txtEmail.Text;

            if(userBLL.UserInsertBLL(user))
            {
                lblResult.Text = "Data Added!";
            }
            else
            {
                lblResult.Text = "Failed to Add Data";
            }
            LoadGridView();
            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.Email = txtEmail.Text;

            if (userBLL.UserUpdateBLL(user))
            {
                lblResult.Text = "Data Updated!";
            }
            else
            {
                lblResult.Text = "Failed to Update Data";
            }
            LoadGridView();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Email = txtEmail.Text;

            if (userBLL.UserDeleteBLL(user))
            {
                lblResult.Text = "Data Deleted!";
            }
            else
            {
                lblResult.Text = "Failed to Delete Data";
            }
            LoadGridView();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Email = txtEmail.Text;

            if(userBLL.UserSearchBLL(user) != null)
            {
                DataTable dataTable = userBLL.UserSearchBLL(user);

                if (dataTable.Rows.Count > 0)
                {
                    txtFirstName.Text = dataTable.Rows[0]["FirstName"].ToString();
                    txtLastName.Text = dataTable.Rows[0]["LastName"].ToString();
                    lblResult.Text = "Data Found!";
                }               
            }
            else
            {
                lblResult.Text = "Failed to Search Data";
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