namespace ProductManagementAPI.Helper
{
    public static class ProductIdGenerator
    {
        private static readonly Random Random = new Random();

        public static int GenerateUniqueId()
        {
            return Random.Next(100000, 999999); // Generates a 6-digit number
        }
    }
}
