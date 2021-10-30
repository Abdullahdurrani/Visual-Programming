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
    public partial class StudentForm : System.Web.UI.Page
    {
        StudentBLL studentBLL = new StudentBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            student.Id = int.Parse(txtId.Text);
            student.Name = txtName.Text;
            student.Email = txtEmail.Text;
            student.Degree = txtDegree.Text;
            student.Department = txtDepartment.Text;
            student.Address = txtAddress.Text;
            student.CGPA = float.Parse(txtCGPA.Text);


            if (studentBLL.StudentInsertBLL(student))
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
            Student student = new Student();

            student.Id = int.Parse(txtId.Text);

            if (studentBLL.StudentDeleteBLL(student))
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
            Student student = new Student();

            student.Id = int.Parse(txtId.Text);
            student.Name = txtName.Text;
            student.Email = txtEmail.Text;
            student.Degree = txtDegree.Text;
            student.Department = txtDepartment.Text;
            student.Address = txtAddress.Text;
            student.CGPA = float.Parse(txtCGPA.Text);

            if (studentBLL.StudentUpdateBLL(student))
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
            Student student = new Student();

            student.Id = int.Parse(txtId.Text);

            if (studentBLL.StudentSearchBLL(student) != null)
            {
                DataTable dataTable = studentBLL.StudentSearchBLL(student);

                if (dataTable.Rows.Count > 0)
                {
                    txtName.Text = dataTable.Rows[0]["Name"].ToString();
                    txtEmail.Text = dataTable.Rows[0]["Email"].ToString();
                    txtDegree.Text = dataTable.Rows[0]["Degree"].ToString();
                    txtDepartment.Text = dataTable.Rows[0]["Department"].ToString();
                    txtAddress.Text = dataTable.Rows[0]["Address"].ToString();
                    txtCGPA.Text = dataTable.Rows[0]["CGPA"].ToString();

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
            gridViewUser.DataSource = studentBLL.StudentGetAllBLL();
            gridViewUser.DataBind();
        }
    }
}