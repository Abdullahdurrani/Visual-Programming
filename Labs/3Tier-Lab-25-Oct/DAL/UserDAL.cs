using AppProps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDAL
    {
        DbCon dbCon = new DbCon();
        public bool UserInsertDAL(User user)
        {
            string query = "INSERT INTO Users (FirstName, LastName, Email) VALUES ('" + user.FirstName + "','" + user.LastName + "','" + user.Email + "')";
            return dbCon.UDI(query);
        }

        public bool UserDeleteDAL(User user)
        {
            string query = "DELETE FROM Users WHERE Email='" + user.Email + "'";
            return dbCon.UDI(query);
        }

        public bool UserUpdateDAL(User user)
        {
            string query = "UPDATE Users SET FirstName='" + user.FirstName + "', LastName='" + user.LastName + "'WHERE Email='" + user.Email + "';";
            return dbCon.UDI(query);
        }

        public DataTable UserSearchDAL(User user)
        {
            string query = "SELECT * FROM Users WHERE Email='" + user.Email + "'";
            return dbCon.Search(query);
        }

        public DataTable UserGetAllDAL()
        {
            string query = "SELECT * FROM Users";
            return dbCon.Search(query);
        }
    }
}
