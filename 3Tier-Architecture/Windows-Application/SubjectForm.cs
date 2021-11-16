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
    public partial class SubjectForm : Form
    {
        SubjectBLL subjectBLL = new SubjectBLL();
        public SubjectForm()
        {
            InitializeComponent();
            LoadGridView();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
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
            gridViewSubject.DataSource = subjectBLL.SubjectGetAllBLL();
        }

        private void btnSubjectForm_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
            this.Close();
        }

        private void btnTeacherForm_Click(object sender, EventArgs e)
        {
            TeacherForm teacherForm = new TeacherForm();
            teacherForm.Show();
            this.Close();
        }
    }
}
