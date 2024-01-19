using Microsoft.AspNetCore.Mvc;
using Vendor_Review_System.Models;

namespace Vendor_Review_System.Controllers
{
    public class VendorRequestController : Controller
    {
        public IActionResult venreq()
        {
            using(ProjectContext db=new ProjectContext())
            {
                TempData["vendors"] = db.Venmols.ToList();
            }
            return View();
        }
        public IActionResult accept()
        {
            return View();
        }
        public IActionResult reject()
        {
            
            return View();
        }
        public IActionResult home()
        {

            return View();
        }
    }
}
