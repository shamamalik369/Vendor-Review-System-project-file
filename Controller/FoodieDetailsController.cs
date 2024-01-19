using Microsoft.AspNetCore.Mvc;
using Vendor_Review_System.Models;

namespace Vendor_Review_System.Controllers
{
    public class FoodieDetailsController : Controller
    {
        public IActionResult foodet()
        {
            using (ProjectContext db = new ProjectContext())
            {
                TempData["foodies"] = db.FoodieModels.ToList();
            }
            return View();
        }
    }
}
