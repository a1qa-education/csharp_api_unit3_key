using Unit3Demo.PetStoreAPI.EndpointsSteps.PetEndpointsSteps;

namespace Unit3Demo.Tests
{
    public class ReadPetTests : BaseTest
    {
        private PetApiSteps _petApiSteps = new PetApiSteps();
        private PetByIdApiSteps _petByIdApiSteps = new PetByIdApiSteps();

        [Test]
        [Description("Get a pet by id - 200 Success")]
        public void GetPetByIdTests()
        {
            // TODO: Generate random pet data

            // TODO: Send PUT request to create pet
            // TODO: Assert status code is 200

            // TODO: Extract created pet from response
            // TODO: Register created pet for deletion

            // TODO: (Optional) Wait for pet to be saved before accessing it

            // TODO: Send GET request to retrieve pet by id
            // TODO: Assert status code is 200

            // TODO: Extract pet from response and assert name matches the original
        }


        [Test]
        [Description("Get a pet by non-existing id - 404 Not Found")]
        public void GetNonExistingPetById()
        {
            // TODO: Generate a non-existing pet id

            // TODO: Send GET request with non-existing id
            // TODO: Assert status code is 404

            // TODO: Extract error message from response
            // TODO: Assert error message is "Pet not found"
        }


        [Test]
        [Description("Get a pet by invalid id (string instead of int64) - 400 Bad Request")]
        [Ignore("DEFECT-001: status code 404 instead of 400 for invalid pet id")]
        public void GetPetByInvalidTypeOfId()
        {
            // TODO: Generate a random string to use as invalid id

            // TODO: Send GET request with invalid id
            // TODO: Assert status code is 400
        }
    }
}