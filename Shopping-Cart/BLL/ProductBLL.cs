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
    public class ProductBLL
    {
        ProductDAL productDAL = new ProductDAL();
        public DataTable GetAllProducts()
        {
            return productDAL.GetAllProductsDAL();
        }

        public DataTable SearchProduct(Product product)
        {
            return productDAL.SearchProductDAL(product);
        }
    }
}
