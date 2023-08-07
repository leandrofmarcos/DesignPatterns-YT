using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class FedExShippingProviderFactory : ShippingProviderFactory
    {
        public override IShippingProvider CreateShippingProvider() => new FedExShippingProvider();
    }
}
