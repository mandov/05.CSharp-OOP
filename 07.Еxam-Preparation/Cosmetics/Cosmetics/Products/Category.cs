namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Cosmetics.Contracts;

    public class Category : ICategory
    {
        private string name;
        private ICollection<IProduct> products;

        public Category(string name)
        {
            this.products = new List<IProduct>();
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length < 2 || value.Length > 15)
                {
                    throw new ArgumentException("Category name must be between 2 and 15 symbols long!");
                }

                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            if (cosmetics == null)
            {
                throw new ArgumentNullException();
            }

            this.products.Add(cosmetics);
        }

        public string Print()
        {
            return string.Format(
                "{0} category – {1} {2} in total \n{3}",
                this.name,
                this.products.Count,
                this.products.Count == 1 ? "product" : "products",
                string.Join("\n", this.products.OrderBy(p => p.Brand).ThenByDescending(p => p.Price))).Trim();
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            this.products.Remove(cosmetics);
        }
    }
}