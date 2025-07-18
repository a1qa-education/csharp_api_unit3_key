using RestSharp;
using System.Net;
using Unit3Demo.PetStoreAPI.Data;
using Unit3Demo.PetStoreAPI.EndpointsSteps.PetEndpointsSteps;
using Unit3Demo.PetStoreAPI.Extensions;
using Unit3Demo.PetStoreAPI.Models;

namespace Unit3Demo.Tests
{
    public class UpdatePetTests : BaseTest
    {
        private PetApiSteps _petApiSteps = new PetApiSteps();
        private PetByIdApiSteps _petByIdApiSteps = new PetByIdApiSteps();

        [Test]
        [Description("Update a pet - 200 Success")]
        public void UpdatePetTest()
        {
            // TODO: Generate random pet data

            // TODO: Send POST request to create pet
            // TODO: Assert status code is 200

            // TODO: Extract created pet from response
            // TODO: Register created pet for deletion

            // TODO: (Optional) Wait for pet to be saved before updating it

            // TODO: Generate new category for update
            // TODO: Create updated pet object with new category

            // TODO: Send PUT request to update pet
            // TODO: Assert status code is 200
            // TODO: Extract updated pet from response
            // TODO: Assert category name is updated correctly

            // TODO: (Optional) Wait for pet to be updated before accessing it

            // TODO: Send GET request to retrieve updated pet by id
            // TODO: Assert status code is 200
            // TODO: Extract pet from response and assert category name matches updated value
        }
    }
}