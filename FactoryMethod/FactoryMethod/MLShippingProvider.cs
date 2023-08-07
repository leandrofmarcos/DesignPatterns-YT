using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class MLShippingProvider : IShippingProvider
    {
        private DateTime date;

        public MLShippingProvider(DateTime date)
        {
            this.date = date;
        }

        public void Ship() => Console.WriteLine($"Enviando via MERCADO LIVRE... - Entregue as {date.ToString()}");
    }
}
