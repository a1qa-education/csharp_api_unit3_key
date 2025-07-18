using Bogus;
using Unit3Demo.PetStoreAPI.Models;

namespace Unit3Demo.PetStoreAPI.Data
{
    internal static class CategoryDataGenerator
    {
        public static Category GenerateCategoryWithRandomName()
        {
            var category = new Category
            {
                Name = new Faker().Commerce.Categories(1).First()
            };
            return category;
        }
    }
}
