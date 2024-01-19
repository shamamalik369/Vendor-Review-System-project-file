using Microsoft.AspNetCore.Mvc;
using Vendor_Review_System.Models;

namespace Vendor_Review_System.Controllers
{
    public class VendorDetailsController : Controller
    {
        public IActionResult vendet()
        {
            using (ProjectContext db = new ProjectContext())
            {
                TempData["vendors"] = db.Venmols.ToList();
            }
            return View();
        }
        public IActionResult activate()
        {
            return View();
        }
        public IActionResult deactivate()
        {
            return View();
        }
        public IActionResult delete(int Id)
        {
            venmol vv = new venmol();
            using (ProjectContext db = new ProjectContext())
            {
                vv = db.Venmols.Where(x => x.ID == Id).FirstOrDefault();
                db.Venmols.Remove(vv);
                int count = db.SaveChanges();
                if(count>0)
                {
                    TempData["DeleteMsg"] = "1";
                    ModelState.Clear();
                }
            }
            return View();
        }
    }
}
