namespace WarMachines.Machines
{
    using System;
    using WarMachines.Interfaces;

    public class Fighter : Machine, IFighter
    {
        private bool isStealthMode;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            : base(name, attackPoints, defensePoints)
        {
            this.StealthMode = stealthMode;
            this.HealthPoints = 200;
        }

        public bool StealthMode
        {
            get { return this.isStealthMode; }
            set { this.isStealthMode = value; }
        }

        public void ToggleStealthMode()
        {
            this.isStealthMode = !this.isStealthMode;
        }

        public override string ToString()
        {
            return base.ToString() + (this.isStealthMode == true ? "\n *Stealth: ON" : "\n *Stealth: OFF");
        }
    }
}