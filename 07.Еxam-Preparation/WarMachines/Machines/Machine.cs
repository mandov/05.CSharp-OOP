namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private double healthPoints;
        private double defensivePoints;
        private List<string> targets;
        private double attackPoints;

        public Machine(string name, double attackPoints, double defensivePoints)
        {
            this.targets = new List<string>();
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensivePoints;
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
                    throw new ArgumentException("Name shouldn't be null or empty !");
                }

                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Object must not be empty !");
                }

                this.pilot = value;
            }
        }

        public virtual double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }

            set
            {             
                this.healthPoints = value;
            }
        }

        public virtual double AttackPoints
        {
            get
            {
                return this.attackPoints;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Attack points value must be greater than 0 !");
                }

                this.attackPoints = value;
            }
        }

        public virtual double DefensePoints
        {
            get
            {
                return this.defensivePoints;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Defense points value must be greater than 0 !");
                }

                this.defensivePoints = value;
            }
        }

        public IList<string> Targets
        {
            get
            {
                return this.targets;
            }       
        }

        public virtual void Attack(string target)
        {
            if (string.IsNullOrEmpty(target))
            {
                throw new ArgumentException("Target must not be null or empty !");
            }

            this.targets.Add(target);
        }

        public override string ToString()
        {
            return string.Format(
                "\n- {0}\n *Type: {1}\n *Health: {2}\n *Attack: {3}\n *Defense: {4}\n *Targets: {5}",
                 this.name,
                 GetType().Name, 
                 this.healthPoints,
                 this.attackPoints, 
                 this.defensivePoints,
                 this.targets.Count > 0 ? string.Join(", ", this.targets) : "None");
        }
    }
}