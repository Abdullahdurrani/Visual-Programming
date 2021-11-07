using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProps;

namespace DAL
{
    public class UserDAL
    {
        DbCon dbCon = new DbCon();

        public bool UserInsertDAL(User user)
        {
            string query = "INSERT INTO Users VALUES " + "(" + user.Id + ",'" + user.FirstName
                + "','" + user.LastName + "','" + user.Email + "','" + user.Password + "',"
                + user.AccessLevel + ",'" + user.Address + "','" + user.PhoneNumber + "','"
                + user.Salary + "','" + user.Age + "','" + user.Balance + "','" + user.City
                + "'," + user.Orders + ",'" + user.Department + "','" + user.Position + "')";
            return dbCon.UDI(query);
        }

        public bool UserDeleteDAL(User user)
        {
            string query = "DELETE FROM Users WHERE Id='" + user.Id + "'";
            return dbCon.UDI(query);
        }

        public bool UserUpdateDAL(User user)
        {
            string query = "UPDATE Users SET FirstName='" + user.FirstName + "', LastName='" + user.LastName
                            + "', Email='" + user.Email + "', Password='" + user.Password + "', AccessLevel=" + user.AccessLevel
                            + ", Address='" + user.Address + "', PhoneNumber='" + user.PhoneNumber
                            + "', Salary=" + user.Salary + ", Age=" + user.Age + ", Balance=" + user.Balance + ", City='" + user.City + "', Orders=" + user.Orders + ", Department='" + user.Department + "', Position='" + user.Position + "'WHERE Id=" + user.Id + ";";
            return dbCon.UDI(query);
        }

        public DataTable UserSearchDAL(User user)
        {
            string query = "SELECT * FROM Users WHERE Id=" + user.Id + "and Password='" + user.Password + "'";
            return dbCon.Search(query);
        }

        public DataTable UserGetAllDAL()
        {
            string query = "SELECT * FROM Users";
            return dbCon.Search(query);
        }
    }
}
