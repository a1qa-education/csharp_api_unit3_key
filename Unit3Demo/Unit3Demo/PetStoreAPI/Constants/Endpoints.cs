namespace Unit3Demo.PetStoreAPI.Constants
{
    public static class Endpoints
    {
        public const string PetIdParameter = "petId";
        public const string OrderIdParameter = "orderId";

        public const string Pet = "/pet";
        public const string Store = "/store";
        public const string Order = Store + "/order";

        public static readonly string PetById = Pet + UrlSegmentParameter(PetIdParameter);
        public static readonly string OrderById = Order + UrlSegmentParameter(OrderIdParameter);

        private static string UrlSegmentParameter(string parameterName) => "/{" + parameterName + "}";
    }
}
