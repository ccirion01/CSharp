namespace NamedOptionalParameters
{
    public class Named
    {
        public static void PrintOrderDetails(string sellerName, int orderNo, string productName)
        {
            Console.WriteLine($"Seller: {sellerName}, order: {orderNo}, product: {productName}");
        }

    }
}
