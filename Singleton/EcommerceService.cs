using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class EcommerceService
    {
        private Logger logger;

        public EcommerceService()
        {
            logger = Logger.GetInstance();

            var logger2 = Logger.GetInstance();
        }

        public void ProccessOrder(string orderId)
        {
            logger.Log($"Order {orderId} prcessed successfully.");
        }
    }
}
