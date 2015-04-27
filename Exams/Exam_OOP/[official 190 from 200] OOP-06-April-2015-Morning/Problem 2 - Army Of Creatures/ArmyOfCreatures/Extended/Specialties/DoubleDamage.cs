namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using System.Globalization;
    using System.Threading.Tasks;
    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Specialties;

    public class DoubleDamage : Specialty
    {
        private int rounds;


        public DoubleDamage(int rounds)
        {
            if (rounds <= 0 || rounds > 10)
            {
                throw new ArgumentOutOfRangeException("rounds", "The number of rounds should be greater than 0 or less than 10");
            }
            this.rounds = rounds;
        }


        public override decimal ChangeDamageWhenAttacking(
           ICreaturesInBattle attackerWithSpecialty,
           ICreaturesInBattle defender,
           decimal currentDamage)
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }

            if (this.rounds > 0)
            {
                this.rounds--;
                return currentDamage * 2m;
            }
            return currentDamage;
        }

        public override string ToString()
        {
            // TODO :  OR return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.Percentage);
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", this.GetType().Name, this.rounds);
        }
    }
}
