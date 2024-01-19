using Microsoft.AspNetCore.Mvc;

namespace Vendor_Review_System.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
