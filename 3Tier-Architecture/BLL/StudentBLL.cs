using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProps;
using DAL;

namespace BLL
{
    public class StudentBLL
    {
        StudentDAL studentDAL = new StudentDAL();

        public bool StudentInsertBLL(Student student)
        {
            return studentDAL.StudentInsertDAL(student);
        }

        public bool StudentDeleteBLL(Student student)
        {
            return studentDAL.StudentDeleteDAL(student);
        }

        public bool StudentUpdateBLL(Student student)
        {
            return studentDAL.StudentUpdateDAL(student);
        }

        public DataTable StudentSearchBLL(Student student)
        {
            return studentDAL.StudentSearchDAL(student);
        }

        public DataTable StudentGetAllBLL()
        {
            return studentDAL.StudentGetAllDAL();
        }
    }
}
