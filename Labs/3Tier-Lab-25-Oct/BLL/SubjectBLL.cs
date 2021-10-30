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
    public class SubjectBLL
    {
        SubjectDAL subjectDAL = new SubjectDAL();

        public bool SubjectInsertBLL(Subject subject)
        {
            return subjectDAL.SubjectInsertDAL(subject);
        }

        public bool SubjectDeleteBLL(Subject subject)
        {
            return subjectDAL.SubjectDeleteDAL(subject);
        }

        public bool SubjectUpdateBLL(Subject subject)
        {
            return subjectDAL.SubjectUpdateDAL(subject);
        }

        public DataTable SubjectSearchBLL(Subject subject)
        {
            return subjectDAL.SubjectSearchDAL(subject);
        }

        public DataTable SubjectGetAllBLL()
        {
            return subjectDAL.SubjectGetAllDAL();
        }
    }
}
