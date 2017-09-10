namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using ArmyOfCreatures.Logic.Battles;
    using Logic.Specialties;

    public class AddAttackWhenSkip : Specialty
    {
        private int attackPoints;

        public AddAttackWhenSkip(int attackPoints)
        {
            if (attackPoints <= 0 || attackPoints > 10)
            {
                throw new ArgumentOutOfRangeException("Attack points should be between 1 and 11");
            }

            this.attackPoints = attackPoints;
        }

        public override void ApplyOnSkip(ICreaturesInBattle skipCreature)
        {
            if (skipCreature == null)
            {
                throw new ArgumentNullException("skipCreature");
            }

            skipCreature.PermanentAttack += this.attackPoints;
        }

        public override string ToString()
        {
            return string.Format("AddAttackWhenSkip({0})", this.attackPoints);
        }
    }
}
