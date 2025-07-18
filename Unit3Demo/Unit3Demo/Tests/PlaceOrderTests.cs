using RestSharp;
using System.Net;
using Unit3Demo.PetStoreAPI.Data;
using Unit3Demo.PetStoreAPI.EndpointsSteps.PetEndpointsSteps;
using Unit3Demo.PetStoreAPI.EndpointsSteps.StoreEndpointsSteps;
using Unit3Demo.PetStoreAPI.Extensions;
using Unit3Demo.PetStoreAPI.Models;

namespace Unit3Demo.Tests
{
    public class PlaceOrderTests : BaseTest
    {
        private PetApiSteps _petApiSteps = new PetApiSteps();
        private OrderApiSteps _orderApiSteps = new OrderApiSteps();
        private OrderByIdApiSteps _orderByIdApiSteps = new OrderByIdApiSteps();

        [Test]
        [Description("Place an order - 200 Success")]
        public void PlaceOrderTest()
        {
            // TODO: Generate random pet data

            // TODO: Send PUT request to create pet
            // TODO: Assert status code is 200

            // TODO: Extract created pet from response
            // TODO: Register created pet for deletion

            // TODO: (Optional) Wait for pet to be saved before placing an order

            // TODO: Prepare order object with expected values

            // TODO: Send POST request to place an order
            // TODO: Extract placed order from response
            // TODO: Assert content type is JSON
            // TODO: Assert order fields match expected values

            // TODO: (Optional) Wait for order to be saved before retrieving it

            // TODO: Send GET request to retrieve order by id
            // TODO: Assert status code is 200
            // TODO: Extract order from response and assert it matches the placed order
        }

    }
}