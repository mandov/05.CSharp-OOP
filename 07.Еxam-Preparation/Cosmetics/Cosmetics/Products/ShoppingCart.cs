namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using Cosmetics.Contracts;

    public class ShoppingCart : IShoppingCart
    {
        private ICollection<IProduct> productsList;

        public ShoppingCart()
        {
            this.productsList = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            this.productsList.Add(product);
        }

        public bool ContainsProduct(IProduct product)
        {
           return this.productsList.Contains(product);
        }

        public void RemoveProduct(IProduct product)
        {
            this.productsList.Remove(product);
        }

        public decimal TotalPrice()
        {
            decimal totalPrice = 0;
            foreach (var product in this.productsList)
            {
                totalPrice += product.Price;
            }

            return totalPrice;
        }
    }
}
