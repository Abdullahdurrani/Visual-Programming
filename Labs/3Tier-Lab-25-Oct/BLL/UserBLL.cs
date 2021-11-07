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
    public class UserBLL
    {
        UserDAL userDAL = new UserDAL();

        public bool UserInsertBLL(User user)
        {
            return userDAL.UserInsertDAL(user);
        }

        public bool UserDeleteBLL(User user)
        {
            return userDAL.UserDeleteDAL(user);
        }

        public bool UserUpdateBLL(User user)
        {
            return userDAL.UserUpdateDAL(user);
        }

        public DataTable UserSearchBLL(User user)
        {
            return userDAL.UserSearchDAL(user);
        }

        public DataTable UserGetAllBLL()
        {
            return userDAL.UserGetAllDAL();
        }
    }
}
