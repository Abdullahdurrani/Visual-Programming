using AppProps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDAL
    {
        DbCon dbCon = new DbCon();
        public DataTable GetAllProductsDAL()
        {
            string query = "SELECT * FROM SCProducts";
            return dbCon.Search(query);
        }

        public DataTable SearchProductDAL(Product product)
        {
            string query = "SELECT * FROM SCProducts WHERE Id=" + product.Id + "";
            return dbCon.Search(query);
        }
    }
}
