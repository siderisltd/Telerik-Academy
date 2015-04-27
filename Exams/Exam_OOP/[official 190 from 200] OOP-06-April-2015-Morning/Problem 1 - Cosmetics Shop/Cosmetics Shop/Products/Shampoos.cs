namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Shampoos : Products, IShampoo, IProduct
    {
        public uint Milliliters { get; private set; }

        public UsageType Usage { get; private set; }

        public Shampoos(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            :base(name,brand,price,gender)
        {
            this.Milliliters = milliliters;
            this.Price = price * milliliters;
            this.Usage = usage;
        }
    }
}
