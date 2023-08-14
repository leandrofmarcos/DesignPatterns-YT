using Singleton;

public class Program
{
    static void Main()
    {
        EcommerceService ecommerce = new EcommerceService();
        ecommerce.ProccessOrder("12345");
    }
}