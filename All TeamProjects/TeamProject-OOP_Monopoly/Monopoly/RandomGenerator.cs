namespace Monopoly
{
    using System;

    internal class RandomGenerator
    {

        private Random Rand { get; set; }

        public RandomGenerator(Random rand)
        {
            this.Rand = rand;
        }

        public int Next(int minValue, int maxValue)
        {
            return this.Rand.Next(minValue, maxValue);
        }       
    }
}
