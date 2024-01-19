using Microsoft.AspNetCore.Mvc;
using Vendor_Review_System.Models;

namespace Vendor_Review_System.Controllers
{
    public class VenregController : Controller
    {
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signup(venmol vm)
        {
            using (ProjectContext db = new ProjectContext())
            {
                db.Venmols.Add(vm);
                if(db.SaveChanges()>0)
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
        public IActionResult pay()
        {
            return View();
        }
    }
}
