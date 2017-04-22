using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WithoutInterfaces.Controllers
{
    public class HomeController : Controller
    {
        private readonly OrderService orderService;

        public HomeController(OrderService orderService)
        {
            this.orderService = orderService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Order()
        {
            ViewBag.OrderStatus = await orderService.Order();
            return View();
        }
    }
}