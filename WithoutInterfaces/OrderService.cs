using System;
using System.Threading.Tasks;

namespace WithoutInterfaces
{
    public class OrderService
    {
        private readonly Logger logger;
        private readonly Storage storage;

        public OrderService(Logger logger, Storage storage)
        {
            this.logger = logger;
            this.storage = storage;
        }

        public async Task<OrderStatus> Order()
        {
            logger.Log("Doing some ordering logic here...\n");
            await storage.Save();
            return OrderStatus.Ok;
        }
    }
}