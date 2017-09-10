namespace WarMachines.Machines
{
    using WarMachines.Interfaces;

    public class Tank : Machine, ITank
    {
        private bool isDefenseMode = true;

        public Tank(string name, double attackPoints, double defensivePoints)
            : base(name, attackPoints, defensivePoints)
        {
            this.HealthPoints = 100;
            if (this.isDefenseMode)
            {
                this.DefensePoints += 30;
                this.AttackPoints -= 40;
            }
        }

        public bool DefenseMode
        {
            get
            {
                return this.isDefenseMode;
            }
        }

        public void ToggleDefenseMode()
        {
            this.isDefenseMode = !this.isDefenseMode;

            if (this.isDefenseMode)
            {
                this.DefensePoints += 30;
                this.AttackPoints -= 40;
            }
            else
            {
                this.DefensePoints -= 30;
                this.AttackPoints += 40;
            }
        }

        public override string ToString()
        {
            return base.ToString() + (this.isDefenseMode == true ? "\n *Defense: ON" : "\n *Defense: OFF");
        }
    }
}
