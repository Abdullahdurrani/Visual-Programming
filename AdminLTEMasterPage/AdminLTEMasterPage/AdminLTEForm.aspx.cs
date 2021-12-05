using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace AdminLTEMasterPage
{
    public partial class AdminLTEForm : System.Web.UI.Page
    {
        XDocument xDocument;
        protected void Page_Load(object sender, EventArgs e)
        {
            xDocument = XDocument.Load(Server.MapPath("Employees.xml"));
            LoadGridView();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            XElement employee = xDocument.Descendants("Employee").FirstOrDefault(x => x.Attribute("Id").Value.Equals(txtId.Text));
            if (employee == null)
            {
                xDocument.Element("Employees").Add(
                    new XElement("Employee",
                        new XAttribute("Id", txtId.Text),
                        new XElement("FirstName", txtFirstName.Text),
                        new XElement("LastName", txtLastName.Text),
                        new XElement("Education", txtEducation.Text),
                        new XElement("Department", txtDepartment.Text),
                        new XElement("Salary", txtSalary.Text),
                        new XElement("Role", txtRole.Text)
                        )
                    );
                xDocument.Save(Server.MapPath("Employees.xml"));
                lblInfo.Text = "Employee data added!";
                LoadGridView();
            }
            else
            {
                lblInfo.Text = "Employee Id Already exists!";
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            XElement employee = xDocument.Descendants("Employee").FirstOrDefault(x => x.Attribute("Id").Value.Equals(txtId.Text));
            employee.Element("FirstName").Value = txtFirstName.Text;
            employee.Element("LastName").Value = txtLastName.Text;
            employee.Element("Education").Value = txtEducation.Text;
            employee.Element("Department").Value = txtDepartment.Text;
            employee.Element("Salary").Value = txtSalary.Text;
            employee.Element("Role").Value = txtRole.Text;
            xDocument.Save(Server.MapPath("Employees.xml"));
            LoadGridView();
            lblInfo.Text = "Employee Data Updated!";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            XElement employee = xDocument.Descendants("Employee").FirstOrDefault(x => x.Attribute("Id").Value.Equals(txtId.Text));
            if (employee != null)
            {
                employee.Remove();
                xDocument.Save(Server.MapPath("Employees.xml"));
                LoadGridView();
                lblInfo.Text = "Employee Data Deleted!";
            }
            else
            {
                lblInfo.Text = "Employee Not Found!";
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            XElement employee = xDocument.Descendants("Employee").FirstOrDefault(x => x.Attribute("Id").Value.Equals(txtId.Text));
            if (employee != null)
            {
                txtFirstName.Text = employee.Element("FirstName").Value;
                txtLastName.Text = employee.Element("LastName").Value;
                txtEducation.Text = employee.Element("Education").Value;
                txtDepartment.Text = employee.Element("Department").Value;
                txtSalary.Text = employee.Element("Salary").Value;
                txtRole.Text = employee.Element("Role").Value;
                lblInfo.Text = "Employee Record Found!";
            }
            else
            {
                lblInfo.Text = "Employee Record Not Found!";
            }
        }

        private void LoadGridView()
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(Server.MapPath("Employees.xml"));
            if (dataSet.Tables.Count > 0)
            {
                dataGridView.DataSource = dataSet;
                dataGridView.DataBind();
            }
        }
    }
}