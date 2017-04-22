using System;
using System.Threading.Tasks;

namespace WithoutInterfaces
{
    public class OrderService
    {
        private readonly Storage storage;

        public OrderService(Storage storage)
        {
            this.storage = storage;
        }

        public async Task<OrderStatus> Order()
        {
            Console.WriteLine("Doing some ordering logic here...");
            await storage.Save();
            return OrderStatus.Ok;
        }
    }
}