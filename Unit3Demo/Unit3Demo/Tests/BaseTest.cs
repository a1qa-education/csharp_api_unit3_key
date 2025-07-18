using System.Collections.Concurrent;
using Unit3Demo.PetStoreAPI.EndpointsSteps.PetEndpointsSteps;
using Unit3Demo.PetStoreAPI.Models;

namespace Unit3Demo.Tests
{
    public abstract class BaseTest
    {
        private ConcurrentBag<long> _createdPetsIds = new();

        protected void RegisterPetForDelete(Pet pet)
        {
            _createdPetsIds.Add(pet.Id!.Value);
        }

        [TearDown]
        public void DeleteCreatedPets()
        {
            var petByIdApiSteps = new PetByIdApiSteps();
            foreach (long id in _createdPetsIds)
            {
                // TODO: Implement delete of the pet
            }
        }
    }
}