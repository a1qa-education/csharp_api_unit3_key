using RestSharp;
using System.Net;
using Unit3Demo.PetStoreAPI.Constants;
using Unit3Demo.PetStoreAPI.Data;
using Unit3Demo.PetStoreAPI.EndpointsSteps.PetEndpointsSteps;
using Unit3Demo.PetStoreAPI.Extensions;
using Unit3Demo.PetStoreAPI.Models;

namespace Unit3Demo.Tests
{
    public class CreatePetTests : BaseTest
    {
        private PetApiSteps _petApiSteps = new PetApiSteps();
        private PetByIdApiSteps _petByIdApiSteps = new PetByIdApiSteps();

        [Test]
        [Description("Create a pet - 200 Success")]
        public void CreatePetTest()
        {
            // TODO: Generate random pet data

            // TODO: Send POST request to create pet
            // TODO: Assert status code is 200
            // TODO: Assert content type is JSON
            // TODO: Assert AllowMethods header contains DELETE

            // TODO: Extract created pet from response
            // TODO: Register created pet for deletion

            // TODO: Assert pet name matches the generated name
        }


        [Test]
        [Description("Create a pet using PUT - 200 Success")]
        public void CreatePetUsingPut()
        {
            // TODO: Generate random pet data

            // TODO: Send PUT request to create pet
            // TODO: Assert status code is 200

            // TODO: Extract created pet from response
            // TODO: Register created pet for deletion

            // TODO: Assert pet name matches the generated name

            // TODO: (Optional) Wait for pet to be saved before accessing it

            // TODO: Send GET request to retrieve pet by id
            // TODO: Assert status code is 200
            // TODO: Extract pet from response and assert name matches the original
        }

    }
}