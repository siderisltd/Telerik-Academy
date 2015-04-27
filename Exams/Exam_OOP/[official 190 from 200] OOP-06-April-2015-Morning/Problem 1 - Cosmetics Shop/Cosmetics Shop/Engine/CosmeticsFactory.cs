namespace Cosmetics.Engine
{
    using System.Collections.Generic;

    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using Cosmetics.Products;

    public class CosmeticsFactory : ICosmeticsFactory
    {
        public ICategory CreateCategory(string name)
        {
            ValidateCategory(name);
            return new Categories(name);
            
        }

        private static void ValidateCategory(string name)
        {
            Validator.CheckIfStringLengthIsValid(name, 15, 2, "Category name must be between 2 and 15 symbols long!");
        }

        public IShampoo CreateShampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
        {
            ValidateProducts(name, brand);
            return new Shampoos(name, brand, price, gender, milliliters, usage);
        }

        public IToothpaste CreateToothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
        {
            ValidateProducts(name, brand);
            foreach (var ingredient in ingredients)
            {
                Validator.CheckIfStringLengthIsValid(ingredient, 12, 4, "Each ingredient must be between 4 and 12 symbols long!");
            }
            return new Toothpastes(name, brand, price, gender, ingredients);
        }

        private static void ValidateProducts(string name, string brand)
        {
            Validator.CheckIfStringLengthIsValid(name, 10, 3, "Product name must be between 3 and 10 symbols long!");
            Validator.CheckIfStringLengthIsValid(brand, 10, 2, "Product brand must be between 2 and 10 symbols long!");
        }

        public IShoppingCart ShoppingCart()
        {
            return new ShoppingCart();
        }
    }
}
