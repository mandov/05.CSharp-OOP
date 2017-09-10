namespace ArmyOfCreatures.Extended.Creatures
{
    using Extended.Specialties;
    using Logic.Creatures;

    public class CyclopsKing : Creature
    {
        public CyclopsKing()
            : base(17, 13, 70, 18)
        {
            this.AddSpecialty(new AddAttackWhenSkip(3));
            this.AddSpecialty(new DoubleAttackWhenAttacking(4));
            this.AddSpecialty(new DoubleDamage(1));
        }
    }
}
