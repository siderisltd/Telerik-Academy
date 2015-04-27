namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    public class AncientBehemoth : Creature
    {
        public AncientBehemoth()
            :base(19, 19, 300, 40m)
        {
            this.AddSpecialty(new ReduceEnemyDefenseByPercentage(80m));
            this.AddSpecialty(new DoubleDefenseWhenDefending(5));

        }
    }
}
