using Microsoft.AspNetCore.Mvc;
using Vendor_Review_System.Models;

namespace Vendor_Review_System.Controllers
{
    public class UsersLoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UsersLoginScreen lc)
        {
            using (ProjectContext db = new ProjectContext())
            {
                var users = db.UserMasters.Where(x => x.UserID == lc.UserID && x.Password == lc.Password);
                if (users.Count() > 0)
                {
                    var user = users.FirstOrDefault();

                    HttpContext.Session.SetInt32("role", user.RoleID);
                    HttpContext.Session.SetString("name", user.Name);
                    
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    TempData["msg"] = "InCorrectUserID/Password";
                }
                return View();
            }

        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "UsersLogin");
        }
    }
}
