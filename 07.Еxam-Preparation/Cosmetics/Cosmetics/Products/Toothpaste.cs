namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Toothpaste : Product, IToothpaste
    {
        private IList<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.Ingredients = ingredients;
        }

        public string Ingredient
        {
            get
            {
                return string.Join(", ", this.ingredients);
            }
        }

        public IList<string> Ingredients
        {
            get
            {
                return this.ingredients;
            }

            set
            {
              

                for (int i = 0; i < value.Count; i++)
                {
                    if (value[i].Length < 4 || value[i].Length > 12)
                    {
                        throw new ArgumentException("Each ingredient must be between 4 and 12 symbols long!");
                    }
                }

                this.ingredients = value;
            }
        }

        string IToothpaste.Ingredients => throw new NotImplementedException();

        public override string ToString()
        {
            return Print() + string.Format(
                "\n * Ingredients: {0}",              
                string.Join(", ", this.ingredients));
        }
    }
}