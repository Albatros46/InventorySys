using Microsoft.AspNetCore.Mvc;

namespace InventorySys.Web.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
