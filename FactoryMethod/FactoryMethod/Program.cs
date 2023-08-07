using FactoryMethod;

public class Program
{
    static void Main()
    {
        ShippingProviderFactory factory;


        string userChoice = "ML";
        if (userChoice == "FedEx")
            factory = new FedExShippingProviderFactory();
        else if(userChoice == "ML")
            factory = new MLShippingProviderFactory(DateTime.Now);
        else
            factory = new DHLShippingProviderFactory();



        //CORE
        IShippingProvider shippingProvider = factory.CreateShippingProvider();
        shippingProvider.Ship();
    }
}