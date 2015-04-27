namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using Cosmetics.Common;
    using System.Collections.Generic;

    public class ShoppingCart : IShoppingCart
    {
        private IList<IProduct> addedProducts;

        private decimal totalPrice;

        public ShoppingCart()
        {
            this.addedProducts = new List<IProduct>();
        }


        public void AddProduct(IProduct product)
        {
            addedProducts.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            // TODO : Shopping cart should implement the IShoppingCart interface. Adding the same product more than once is allowed. !!! Do not check if the product exists, when removing it from the shopping cart. !!!
            addedProducts.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            foreach (var products in addedProducts)
            {
                if (product == products)
                {
                    return true;
                }
            }
            return false;
        }

        public decimal TotalPrice()
        {
            foreach (var product in addedProducts)
            {
                this.totalPrice += product.Price;
            }
            return this.totalPrice;
        }
    }
}
