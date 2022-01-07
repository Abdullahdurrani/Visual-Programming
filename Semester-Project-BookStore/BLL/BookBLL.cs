using AppProps;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BookBLL
    {
        BookDAL bookDAL = new BookDAL();

        public bool BookInsertBLL(Book book)
        {
            return bookDAL.BookInsertDAL(book);
        }

        public bool BookDeleteBLL(Book book)
        {
            return bookDAL.BookDeleteDAL(book);
        }

        public bool BookUpdateBLL(Book book)
        {
            return bookDAL.BookUpdateDAL(book);
        }

        public DataTable BookSearchBLL(Book book)
        {
            return bookDAL.BookSearchDAL(book);
        }

        public DataTable BookGetAllBLL()
        {
            return bookDAL.BookGetAllDAL();
        }
    }
}
