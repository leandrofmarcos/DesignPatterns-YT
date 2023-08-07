using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class DHLShippingProviderFactory : ShippingProviderFactory
    {
        public override IShippingProvider CreateShippingProvider() => new DHLShippingProvider();
    }
}
