namespace Dealership.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Dealership.Common;
    using Dealership.Common.Enums;
    using Dealership.Contracts;

    public class User : IUser
    {
        private string username;
        private string firstName;
        private string lastName;
        private string password;
        private Role role;
        private IList<IVehicle> vehicles;

        public User(string username, string firstName, string lastName, string password, Role role)
        {
            this.vehicles = new List<IVehicle>();
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.Role = role;
        }

        public string Username
        {
            get
            {
                return this.username;
            }

            set
            {
                Validator.ValidateNull(value, Constants.UserCannotBeNull);
                Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Username", Constants.MinNameLength, Constants.MaxNameLength));
                Validator.ValidateSymbols(value, Constants.UsernamePattern, string.Format(Constants.InvalidSymbols, "Username"));

                this.username = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                Validator.ValidateNull(value, "First name cannot be null!");
                Validator.ValidateIntRange(
                    value.Length, 
                    Constants.MinNameLength, 
                    Constants.MaxNameLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Firstname", Constants.MinNameLength, Constants.MaxNameLength));

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                Validator.ValidateNull(value, "Second name cannot be null!");
                Validator.ValidateIntRange(
                    value.Length,
                    Constants.MinNameLength, 
                    Constants.MaxNameLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Lastname", Constants.MinNameLength, Constants.MaxNameLength));

                this.lastName = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                Validator.ValidateNull(value, "Password cannot be null!");
                Validator.ValidateIntRange(value.Length, Constants.MinPasswordLength, Constants.MaxPasswordLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Password", Constants.MinPasswordLength, Constants.MaxPasswordLength));
                Validator.ValidateSymbols(value, Constants.PasswordPattern, string.Format(Constants.InvalidSymbols, "Password"));

                this.password = value;
            }
        }

        public Role Role
        {
            get
            {
                return this.role;
            }

            set
            {
                this.role = value;
            }
        }

        public IList<IVehicle> Vehicles
        {
            get
            {
                return this.vehicles;
            }

            set
            {
                this.vehicles = value;
            }
        }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            vehicleToAddComment.Comments.Add(commentToAdd);
        }

        public void AddVehicle(IVehicle vehicle)
        {
            if (this.role == Role.Normal && this.vehicles.Count < 5 || this.role == Role.VIP)
            {
                this.vehicles.Add(vehicle);
            }
            else if (this.role == Role.Admin)
            {
                throw new ArgumentException(Constants.AdminCannotAddVehicles);
            }
            else
            {
                throw new ArgumentException(string.Format(Constants.NotAnVipUserVehiclesAdd, Constants.MaxVehiclesToAdd));
            }
        }

        public string PrintVehicles()
        {
            StringBuilder st = new StringBuilder();
            for (int i = 0; i < this.vehicles.Count; i++)
            {
                st.AppendFormat("\n{0}. {1}", i + 1, this.vehicles[i]);
            }

            return string.Format("--USER {0}--\n{1}", this.Username, st.Length == 0 ? "--NO VEHICLES--" : st.ToString().Trim());
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            if (commentToRemove.Author == this.Username)
            {
                vehicleToRemoveComment.Comments.Remove(commentToRemove);
            }
            else
            {
                throw new ArgumentException(Constants.YouAreNotTheAuthor);
            }

        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            this.vehicles.Remove(vehicle);
        }

        public override string ToString()
        {
            return string.Format("Username: {0}, FullName: {1} {2}, Role: {3}", this.Username, this.FirstName, this.LastName, this.Role);
        }
    }
}