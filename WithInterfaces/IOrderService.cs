using System.Threading.Tasks;

namespace WithInterfaces
{
    public interface IOrderService
    {
        Task<OrderStatus> Order();
    }
}