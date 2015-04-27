namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using Cosmetics.Common;
    using System.Text;

    public abstract class Products : IProduct
    {
        public string Name { get; protected set; }

        public string Brand { get; protected set; }

        public decimal Price { get; protected set; }

        public GenderType Gender { get; protected set; }

        public Products(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Print()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("- {0} - {1}:", this.Brand, this.Name));
            result.AppendLine(string.Format("  * Price: ${0}", this.Price));
            result.AppendLine(string.Format("  * For gender: {0}", this.Gender));

            if (this is Shampoos)
            {
                var tempShampoo = this as Shampoos;
                result.AppendLine(string.Format("  * Quantity: {0} ml", tempShampoo.Milliliters));
                result.Append(string.Format("  * Usage: {0}", tempShampoo.Usage));
            }

            else if (this is Toothpastes)
            {
                var tempToothPaste = this as Toothpastes;
                result.Append(string.Format("  * Ingredients: {0}", tempToothPaste.Ingredients));
            }
            return result.ToString();
        }
    }
}
