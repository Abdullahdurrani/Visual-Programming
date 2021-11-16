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
    public partial class TeacherForm : System.Web.UI.Page
    {
        TeacherBLL teacherBLL = new TeacherBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();

            teacher.Id = int.Parse(txtId.Text);
            teacher.Name = txtName.Text;
            teacher.Email = txtEmail.Text;
            teacher.Education = txtEducation.Text;
            teacher.Department = txtDepartment.Text;
            teacher.Address = txtAddress.Text;
            teacher.Designation = txtDesignation.Text;


            if (teacherBLL.TeacherInsertBLL(teacher))
            {
                lblResult.Text = "Data Added!";
            }
            else
            {
                lblResult.Text = "Failed to Add Data";
            }
            LoadGridView();
        }

       

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();

            teacher.Id = int.Parse(txtId.Text);

            if (teacherBLL.TeacherDeleteBLL(teacher))
            {
                lblResult.Text = "Data Deleted!";
            }
            else
            {
                lblResult.Text = "Failed to Delete Data";
            }
            LoadGridView();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();

            teacher.Id = int.Parse(txtId.Text);
            teacher.Name = txtName.Text;
            teacher.Email = txtEmail.Text;
            teacher.Education = txtEducation.Text;
            teacher.Department = txtDepartment.Text;
            teacher.Address = txtAddress.Text;
            teacher.Designation = txtDesignation.Text;

            if (teacherBLL.TeacherUpdateBLL(teacher))
            {
                lblResult.Text = "Data Updated!";
            }
            else
            {
                lblResult.Text = "Failed to Update Data";
            }
            LoadGridView();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();

            teacher.Id = int.Parse(txtId.Text);

            if (teacherBLL.TeacherSearchBLL(teacher) != null)
            {
                DataTable dataTable = teacherBLL.TeacherSearchBLL(teacher);

                if (dataTable.Rows.Count > 0)
                {
                    txtName.Text = dataTable.Rows[0]["Name"].ToString();
                    txtEmail.Text = dataTable.Rows[0]["Email"].ToString();
                    txtEducation.Text = dataTable.Rows[0]["Education"].ToString();
                    txtDepartment.Text = dataTable.Rows[0]["Department"].ToString();
                    txtAddress.Text = dataTable.Rows[0]["Address"].ToString();
                    txtDesignation.Text = dataTable.Rows[0]["Designation"].ToString();

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
            gridViewUser.DataSource = teacherBLL.TeacherGetAllBLL();
            gridViewUser.DataBind();
        }
    }

}