using Microsoft.AspNetCore.Mvc;

namespace Vendor_Review_System.Controllers
{
    public class ViewReviewController : Controller
    {
        public IActionResult viewrev()
        {
            return View();
        }
    }
}
