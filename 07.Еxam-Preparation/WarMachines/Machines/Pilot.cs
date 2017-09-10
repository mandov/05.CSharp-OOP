namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private string name;
        private ICollection<IMachine> engagedMachines;

        public Pilot(string name)
        {
            this.engagedMachines = new List<IMachine>();
            this.name = name;
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
                    throw new ArgumentException("Name is null or empty !");
                }

                this.name = value;
            }
        }

        public ICollection<IMachine> EngagedMachines
        {
            get { return this.engagedMachines; }
            set { this.engagedMachines = value; }
        }

        public void AddMachine(IMachine machine)
        {
            if (machine == null)
            {
                throw new ArgumentNullException("Null reference exception !");
            }

            this.engagedMachines.Add(machine);
        }

        public string Report()
        {
            return string.Format(
                "{0} - {1} {2}{3}",
                this.name,
                this.engagedMachines.Count != 0 ? this.engagedMachines.Count.ToString() : "no",
                this.engagedMachines.Count != 1 ? "machines" : "machine",
                string.Join(string.Empty, this.engagedMachines.OrderBy(m => m.HealthPoints).ThenBy(m => m.Name)));
        }
    }
}
