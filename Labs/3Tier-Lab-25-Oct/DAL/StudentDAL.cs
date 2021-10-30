using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProps;

namespace DAL
{
    public class StudentDAL
    {
        DbCon dbCon = new DbCon();

        public bool StudentInsertDAL(Student student)
        {
            string query = "INSERT INTO Students VALUES" +
                "(" + student.Id + ",'" + student.Name + "','" + student.Email + "','"
                + student.Degree + "','" + student.Department + "','"
                + student.Address + "'," + student.CGPA + ")";

            return dbCon.UDI(query);
        }

        public bool StudentDeleteDAL(Student student)
        {
            string query = "DELETE FROM Students WHERE Id='" + student.Id + "'";
            return dbCon.UDI(query);
        }

        public bool StudentUpdateDAL(Student student)
        {
            string query = "UPDATE Students SET Name='" + student.Name
                + "', Email='" + student.Email + "', Degree='" + student.Degree
                + "', Department='" + student.Department + "', Address='" + student.Address
                + "', CGPA='" + student.CGPA + "'WHERE Id='" + student.Id + "';";
            return dbCon.UDI(query);
        }

        public DataTable StudentSearchDAL(Student student)
        {
            string query = "SELECT * FROM Students WHERE Id='" + student.Id + "'";
            return dbCon.Search(query);
        }

        public DataTable StudentGetAllDAL()
        {
            string query = "SELECT * FROM Students";
            return dbCon.Search(query);
        }
    }
}
