using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class MLShippingProviderFactory : ShippingProviderFactory
    {
        private DateTime date;

        public MLShippingProviderFactory(DateTime date)
        {
            this.date = date;   
        }

        public override IShippingProvider CreateShippingProvider() => new MLShippingProvider(date);
    }
}
