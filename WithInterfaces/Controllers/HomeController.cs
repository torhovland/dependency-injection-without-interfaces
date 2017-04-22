using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WithInterfaces.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOrderService orderService;

        public HomeController(IOrderService orderService)
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