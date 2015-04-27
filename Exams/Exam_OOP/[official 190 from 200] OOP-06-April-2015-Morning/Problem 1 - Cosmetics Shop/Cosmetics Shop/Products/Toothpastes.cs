namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using Cosmetics.Common;
    using System.Collections.Generic;
    using System.Text;

    public class Toothpastes : Products, IToothpaste, IProduct
    {
        public string Ingredients { get; private set; }

        public Toothpastes(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
             this.Ingredients = string.Join(", ", ingredients);
        }
    }
}
