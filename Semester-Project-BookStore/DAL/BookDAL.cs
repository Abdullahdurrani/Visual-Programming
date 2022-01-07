using AppProps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BookDAL
    {
        DbCon dbCon = new DbCon();

        public bool BookInsertDAL(Book book)
        {
            string query = "INSERT INTO Books VALUES" +
                "(" + book.Id + ",'" + book.Name + "','" + book.Genre + "','"
                + book.Author + "','" + book.Description + "'," + book.Price + ",'" + book.Image + "')";

            return dbCon.UDI(query);
        }

        public bool BookDeleteDAL(Book book)
        {
            string query = "DELETE FROM Books WHERE Id='" + book.Id + "'";
            return dbCon.UDI(query);
        }

        public bool BookUpdateDAL(Book book)
        {
            string query = "UPDATE Books SET Name='" + book.Name
                + "', Genre='" + book.Genre + "', Author='" + book.Author
                + "', Description='" + book.Description + "', Price=" + book.Price + ", Image='" + book.Image + "'WHERE Id='" + book.Id + "';";
            return dbCon.UDI(query);
        }

        public DataTable BookSearchDAL(Book book)
        {
            string query = "SELECT * FROM Books WHERE Id='" + book.Id + "'";
            return dbCon.Search(query);
        }

        public DataTable BookGetAllDAL()
        {
            string query = "SELECT * FROM Books";
            return dbCon.Search(query);
        }
    }
}
