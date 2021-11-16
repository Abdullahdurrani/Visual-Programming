using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProps;

namespace DAL
{
    public class SubjectDAL
    {
        DbCon dbCon = new DbCon();

        public bool SubjectInsertDAL(Subject subject)
        {
            string query = "INSERT INTO Subjects VALUES" +
                "(" + subject.Id + ",'" + subject.Title + "'," + subject.CreditHours + ",'"
                + subject.Department + "','" + subject.Teacher + "')";

            return dbCon.UDI(query);
        }

        public bool SubjectDeleteDAL(Subject subject)
        {
            string query = "DELETE FROM Subjects WHERE Id=" + subject.Id + "";
            return dbCon.UDI(query);
        }

        public bool SubjectUpdateDAL(Subject subject)
        {
            string query = "UPDATE Subjects SET Title='" + subject.Title
                + "', CreditHours=" + subject.CreditHours + ", Department='" + subject.Department
                + "', Teacher='" + subject.Teacher + "'WHERE Id=" + subject.Id + ";";
            return dbCon.UDI(query);
        }

        public DataTable SubjectSearchDAL(Subject subject)
        {
            string query = "SELECT * FROM Subjects WHERE Id=" + subject.Id + "";
            return dbCon.Search(query);
        }

        public DataTable SubjectGetAllDAL()
        {
            string query = "SELECT * FROM Subjects";
            return dbCon.Search(query);
        }
    }
}
