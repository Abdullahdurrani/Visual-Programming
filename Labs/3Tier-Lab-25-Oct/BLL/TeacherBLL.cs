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
    public class TeacherBLL
    {
        TeacherDAL teacherDAL = new TeacherDAL();

        public bool TeacherInsertBLL(Teacher teacher)
        {
            return teacherDAL.TeacherInsertDAL(teacher);
        }

        public bool TeacherDeleteBLL(Teacher teacher)
        {
            return teacherDAL.TeacherDeleteDAL(teacher);
        }

        public bool TeacherUpdateBLL(Teacher teacher)
        {
            return teacherDAL.TeacherUpdateDAL(teacher);
        }

        public DataTable TeacherSearchBLL(Teacher teacher)
        {
            return teacherDAL.TeacherSearchDAL(teacher);
        }

        public DataTable TeacherGetAllBLL()
        {
            return teacherDAL.TeacherGetAllDAL();
        }
    }
}
