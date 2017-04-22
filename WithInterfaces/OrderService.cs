using System;
using System.Threading.Tasks;

namespace WithInterfaces
{
    public class OrderService : IOrderService
    {
        private readonly IStorage storage;

        public OrderService(IStorage storage)
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