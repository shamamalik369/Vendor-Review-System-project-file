using Microsoft.AspNetCore.Mvc;
using Vendor_Review_System.Models;

namespace Vendor_Review_System.Controllers
{
    public class GenerateReportController : Controller
    {
        public IActionResult report()
        {
            using (ProjectContext db = new ProjectContext())
            {
                TempData["vendors"] = db.Venmols.ToList();
            }
            using (ProjectContext db = new ProjectContext())
            {
                TempData["foodies"] = db.FoodieModels.ToList();
            }
            return View();
        }
    }
}
