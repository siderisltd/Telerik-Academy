namespace Cosmetics.Products
{
    using Cosmetics.Contracts;

    using Cosmetics.Common;

    using System.Text;

    using System.Collections.Generic;

    using System.Linq;

    public class Categories : ICategory
    {
        public string Name { get; private set; }

        private IList<IProduct> products;


        public Categories(string name)
        {
            products = new List<IProduct>();
            this.Name = name;
        }


        public void AddCosmetics(IProduct cosmetics)
        {
            this.products.Add(cosmetics);
            SortProducts();
        }



        public void RemoveCosmetics(IProduct cosmetics)
        {
            bool isFound = false;

            isFound = CheckIfTheProductExist(cosmetics, isFound);

            if (isFound)
            {
                this.products.Remove(cosmetics);
            }
            else
            {
                System.Console.WriteLine("Product {0} does not exist in category {1}!",cosmetics.Name, this.Name);
            }
            SortProducts();
        }

        private bool CheckIfTheProductExist(IProduct cosmetics, bool isFound)
        {
            foreach (var product in this.products)
            {
                if (product == cosmetics)
                {
                    isFound = true;
                }
            }
            return isFound;
        }

        public string Print()
        {
            SortProducts();
            var isPlural = this.products.Count == 1 ? "product" : "products";
            StringBuilder result = new StringBuilder();
            result.Append(string.Format("{0} category - {1} {2} in total", this.Name, this.products.Count, isPlural));

            foreach (var product in this.products)
            {
                result.AppendLine();
                result.AppendLine(string.Format("- {0} - {1}:", product.Brand, product.Name));
                result.AppendLine(string.Format("  * Price: ${0}", product.Price));
                result.AppendLine(string.Format("  * For gender: {0}", product.Gender));

                if (product is Shampoos)
                {
                    var tempShampoo = product as Shampoos;
                    result.AppendLine(string.Format("  * Quantity: {0} ml", tempShampoo.Milliliters));
                    result.Append(string.Format("  * Usage: {0}", tempShampoo.Usage));
                }

                else if (product is Toothpastes)
                {
                    var tempToothPaste = product as Toothpastes;
                    result.Append(string.Format("  * Ingredients: {0}", tempToothPaste.Ingredients));
                }
            }
            return result.ToString().Trim();
        }

        private void SortProducts()
        {
            if (this.products.Count != 0)
            {
                this.products = products.OrderBy(x => x.Brand).ThenByDescending(x => x.Price).ToList();
            }
        }
    }
}
