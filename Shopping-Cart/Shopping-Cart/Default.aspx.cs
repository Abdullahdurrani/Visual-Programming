using AppProps;
using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping_Cart
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ProductBLL productBLL = new ProductBLL();
                DataTable dataTable = productBLL.GetAllProducts();
                DataListProducts.DataSource = dataTable;
                DataListProducts.DataBind();
            }
        }

        protected void btnAddtoCart_Command(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            Product product = new Product();
            product.Id = id;
            ProductBLL productBLL = new ProductBLL();
            DataTable dataTable = productBLL.SearchProduct(product);
            product.Name = dataTable.Rows[0]["Name"].ToString();
            product.Image = dataTable.Rows[0]["Image"].ToString();
            product.Price = float.Parse(dataTable.Rows[0]["Price"].ToString());
            product.Description = dataTable.Rows[0]["Description"].ToString();

            // if there is some value in cart beforehand, 
            // intialize the newCart object with previous state
            Cart cart = null;
            if (Session["cart"] != null)
            {
                cart = (Cart)Session["cart"];
            }
            Cart newCart = new Cart(cart);
            if (newCart.AddToCart(product, 1))
            {
                Session["cart"] = newCart;
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                Response.Write(@"<script language='javascript'>alert('Item not Added');</script>");
            }

        }
    }
}