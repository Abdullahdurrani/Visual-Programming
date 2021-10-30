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
    public partial class SubjectForm : System.Web.UI.Page
    {
        SubjectBLL subjectBLL = new SubjectBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();

            subject.Id = int.Parse(txtId.Text);
            subject.Title = txtTitle.Text;
            subject.CreditHours = int.Parse(txtCreditHours.Text);
            subject.Department = txtDepartment.Text;
            subject.Teacher = txtTeacher.Text;


            if (subjectBLL.SubjectInsertBLL(subject))
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
            Subject subject = new Subject();

            subject.Id = int.Parse(txtId.Text);

            if (subjectBLL.SubjectDeleteBLL(subject))
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
            Subject subject = new Subject();

            subject.Id = int.Parse(txtId.Text);
            subject.Title = txtTitle.Text;
            subject.CreditHours = int.Parse(txtCreditHours.Text);
            subject.Department = txtDepartment.Text;
            subject.Teacher = txtTeacher.Text;

            if (subjectBLL.SubjectUpdateBLL(subject))
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
            Subject subject = new Subject();

            subject.Id = int.Parse(txtId.Text);

            if (subjectBLL.SubjectSearchBLL(subject) != null)
            {
                DataTable dataTable = subjectBLL.SubjectSearchBLL(subject);

                if (dataTable.Rows.Count > 0)
                {
                    txtTitle.Text = dataTable.Rows[0]["Title"].ToString();
                    txtCreditHours.Text = dataTable.Rows[0]["CreditHours"].ToString();
                    txtDepartment.Text = dataTable.Rows[0]["Department"].ToString();
                    txtTeacher.Text = dataTable.Rows[0]["Teacher"].ToString();

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
            gridViewUser.DataSource = subjectBLL.SubjectGetAllBLL();
            gridViewUser.DataBind();
        }
    }
}