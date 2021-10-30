using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProps;

namespace DAL
{
    public class TeacherDAL
    {
        DbCon dbCon = new DbCon();

        public bool TeacherInsertDAL(Teacher teacher)
        {
            string query = "INSERT INTO Teachers VALUES" +
                "(" + teacher.Id + ",'" + teacher.Name + "','" + teacher.Email + "','" 
                + teacher.Education + "','" + teacher.Department + "','" 
                + teacher.Address + "','" + teacher.Designation + "')";

            return dbCon.UDI(query);
        }

        public bool TeacherDeleteDAL(Teacher teacher)
        {
            string query = "DELETE FROM Teachers WHERE Id='" + teacher.Id + "'";
            return dbCon.UDI(query);
        }

        public bool TeacherUpdateDAL(Teacher teacher)
        {
            string query = "UPDATE Teachers SET Name='" + teacher.Name 
                + "', Email='" + teacher.Email + "', Education='" + teacher.Education
                + "', Department='" + teacher.Department + "', Address='" + teacher.Address
                + "', Designation='" + teacher.Designation + "'WHERE Id='" + teacher.Id + "';";
            return dbCon.UDI(query);
        }

        public DataTable TeacherSearchDAL(Teacher teacher)
        {
            string query = "SELECT * FROM Teachers WHERE Id='" + teacher.Id + "'";
            return dbCon.Search(query);
        }

        public DataTable TeacherGetAllDAL()
        {
            string query = "SELECT * FROM Teachers";
            return dbCon.Search(query);
        }
    }
}
