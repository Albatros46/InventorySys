using Microsoft.AspNetCore.Mvc;

namespace InventorySys.Web.Controllers
{
    public class BillController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
