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
    public partial class TeacherForm : Form
    {
        TeacherBLL teacherBLL = new TeacherBLL();
        public TeacherForm()
        {
            InitializeComponent();
            LoadGridView();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
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
            gridViewTeacher.DataSource = teacherBLL.TeacherGetAllBLL();
        }

        private void btnSubjectForm_Click(object sender, EventArgs e)
        {
            SubjectForm subjectForm = new SubjectForm();
            subjectForm.Show();
            this.Close();
        }

        private void btnStudentForm_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
            this.Close();
        }
    }
}
