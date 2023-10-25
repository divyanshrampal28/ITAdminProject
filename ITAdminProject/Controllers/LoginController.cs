using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITAdminProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITAdminProject.Controllers
{
    public class LoginController : Controller
    {
        private readonly ItAdminContext _login;

        public LoginController(ItAdminContext login)
        {
            _login = login;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetloginDetails(User user)
        {

            var res = _login.Employee.FirstOrDefault(emp => emp.Email == user.Email);

            if (res == null)
            {
                return Json("User not found"); // You can customize this message
            }
            var ans = res.RoleId.ToString();
            return Json(ans);
        }


        [HttpPost]
        public int Id(string id)
        {
            // Decode and parse the JSON data
            //string decodedData = Uri.UnescapeDataString(id);
            //EmailModel emailModel = JsonConvert.DeserializeObject<EmailModel>(decodedData);
            var res = _login.Employee.Where(emp => emp.Email == id).FirstOrDefault().RoleId;
            // Your further processing logic here

            return res;
        }

        public IActionResult Logout()
        {

            return RedirectToAction("Index", "Home");
        }
    }
}