using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{
    public class Cart
    {
        public List<MyProduct> items = null;
        public int totalQuantity = 0;
        public float totalPrice = 0;

        public Cart(Cart OldCart)
        {
            if(OldCart != null)
            {
                items = OldCart.items;
                totalQuantity = OldCart.totalQuantity; 
                totalPrice = OldCart.totalPrice;
            }
        }

        public bool RemoveFromCart(Book book, int quantity)
        {
            MyProduct previousItem = items.FirstOrDefault(x => x.book.Id == book.Id);
            if (previousItem!=null)
            {
                // to remove the whole product and its quantity
                if (previousItem.subQuantity == quantity || quantity == -1)
                {
                    totalPrice = totalPrice - (previousItem.subQuantity * previousItem.book.Price);
                    totalQuantity--;
                    items.Remove(previousItem);
                    return true;
                }
                // to remove some quantity of a product
                else
                {
                    totalPrice = totalPrice - (previousItem.book.Price * quantity);
                    previousItem.subTotal = previousItem.subTotal - (previousItem.book.Price * quantity);
                    previousItem.subQuantity = previousItem.subQuantity - quantity;
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public bool AddToCart(Book book, int quantity)
        {
            // 
            if(items == null)
            {
                MyProduct myProduct = new MyProduct();
                myProduct.book = book;
                myProduct.subQuantity = quantity;
                myProduct.subTotal = book.Price * quantity;
                items = new List<MyProduct>();
                items.Add(myProduct);
                totalQuantity++;
                totalPrice = myProduct.subTotal;
                return true;
            }
            else
            {
                MyProduct previousItem = items.FirstOrDefault(x => x.book.Id == book.Id);
                if(previousItem != null)
                {
                    totalPrice = quantity * previousItem.book.Price + totalPrice;
                    previousItem.subQuantity = previousItem.subQuantity + quantity;
                    previousItem.subTotal = previousItem.subTotal + quantity * previousItem.book.Price;
                    return true;
                }
                else
                {
                    MyProduct myProduct = new MyProduct();
                    myProduct.book = book;
                    myProduct.subQuantity = quantity;
                    myProduct.subTotal= book.Price * quantity;
                    items.Add(myProduct);
                    totalQuantity++;
                    totalPrice = myProduct.subTotal + totalPrice;
                    return true;
                }
            }
        }
    }
}
