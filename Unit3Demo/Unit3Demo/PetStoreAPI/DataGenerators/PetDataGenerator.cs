using Bogus;
using Unit3Demo.PetStoreAPI.Models;

namespace Unit3Demo.PetStoreAPI.Data
{
    internal static class PetDataGenerator
    {
        public static Pet GeneratePetWithRandomName()
        {
            return new Pet
            {
                Name = new Faker().Name.FullName()
            };
        }

        /// <summary>
        /// // Using only second half of the long values to be sure id is not occupied
        /// </summary>
        /// <returns> Random long id of pet </returns>
        public static long GenerateNonExistingPetId()
        {
            return new Faker().Random.Long(long.MaxValue / 2, long.MaxValue);
        }
    }
}
