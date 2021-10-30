using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppProps;
using BLL;

namespace _3TierWinApp
{
    public partial class Form1 : Form
    {
        UserBLL userBLL = new UserBLL();

        public Form1()
        {
            InitializeComponent();
            LoadGridView();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.Email = txtEmail.Text;

            if (userBLL.UserInsertBLL(user))
            {
                lblResult.Text = "Data Added!";
            }
            else
            {
                lblResult.Text = "Failed to Add Data";
            }
            LoadGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Email = txtEmail.Text;

            if (userBLL.UserSearchBLL(user) != null)
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
        }

        private void btnTeacherForm_Click(object sender, EventArgs e)
        {
            TeacherForm teacherForm = new TeacherForm();
            teacherForm.Show();
            this.Hide();
        }
    }
}
