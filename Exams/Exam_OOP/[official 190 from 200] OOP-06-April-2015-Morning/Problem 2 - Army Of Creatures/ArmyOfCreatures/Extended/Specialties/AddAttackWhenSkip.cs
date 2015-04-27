namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using System.Globalization;
    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Specialties;

    public class AddAttackWhenSkip : Specialty
    {
        private readonly int attackToAdd;

        public AddAttackWhenSkip(int attackToAdd)
        {
            if (attackToAdd <= 0 || attackToAdd > 10)
            {
                throw new ArgumentOutOfRangeException("attackAdding", "The number of attack to add should be between 1 and 10 inclusive");
            }
            this.attackToAdd = attackToAdd;
        }


        public override void ApplyOnSkip(ICreaturesInBattle skipCreature)
        {
            if (skipCreature == null)
            {
                throw new ArgumentNullException("skipCreature cannot be null");
            }

            skipCreature.PermanentAttack += this.attackToAdd;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", this.GetType().Name, this.attackToAdd);
        }
    }
}
