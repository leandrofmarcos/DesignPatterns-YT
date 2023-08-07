using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class DHLShippingProvider : IShippingProvider
    {
        public void Ship() => Console.WriteLine("Enviando via DHL...");
    }
}
