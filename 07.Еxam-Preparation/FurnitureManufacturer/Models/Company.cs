namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FurnitureManufacturer.Interfaces;

    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            this.furnitures = new List<IFurniture>();
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("•	Name cannot be empty or null !");
                }

                if (value.Length < 5)
                {
                    throw new ArgumentException("Name cannot be less than 5 symbols !");
                }

                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length != 10)
                {
                    throw new ArgumentException("Registration number must be exactly 10 symbols ");
                }

                foreach (var num in value)
                {
                    if (!char.IsDigit(num))
                    {
                        throw new ArgumentException("Registration number must contain only digits !");
                    }
                }

                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get { return this.furnitures; }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public string Catalog()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine(
            string.Format("{0} - {1} - {2} {3}",
            this.Name,
            this.RegistrationNumber,
            this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
            this.Furnitures.Count != 1 ? "furnitures" : "furniture"));

            foreach (var item in this.furnitures.OrderBy(f => f.Price).ThenBy(f => f.Model))
            {
                st.AppendLine(item.ToString());
            }

            return st.ToString().TrimEnd();
        }

        public IFurniture Find(string model)
        {
            return this.furnitures.FirstOrDefault(f => f.Model.ToLower() == model.ToLower());
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }
    }
}
