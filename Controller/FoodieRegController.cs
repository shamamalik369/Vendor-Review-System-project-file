using Microsoft.AspNetCore.Mvc;
using Vendor_Review_System.Models;

namespace Vendor_Review_System.Controllers
{
    public class FoodieRegController : Controller
    {
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signup(FoodieModel FM)
        {
            using (ProjectContext db = new ProjectContext())
            {
                db.FoodieModels.Add(FM);
                if (db.SaveChanges() > 0)
                {
                    TempData["status"] = "1";
                }
                else
                {
                    TempData["status"] = "0";
                }
            }
            return View();
        }
    }
}
