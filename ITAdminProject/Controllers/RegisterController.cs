using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITAdminProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ITAdminProject.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ItAdminContext _login;

        public RegisterController(ItAdminContext login)
        {
            _login = login;
        }

        public IActionResult Index()
        {
            ViewBag.RoleList = new List<SelectListItem>
    {
        new SelectListItem { Text = "1", Value = "1" },
        new SelectListItem { Text = "2", Value = "2" },
        // Add more items as needed
    };
            return View();
        }

        [HttpPost]
        public IActionResult Index(Employee obj)
        {
            //if (ModelState.IsValid)
            //{
            //var newpass = Hashing.ToSHA256(obj.Password);
            //obj.Password = newpass;
            _login.Employee.Add(obj);
            _login.SaveChanges();
            //return RedirectToAction("Index", "Home");
            //}

            return View(obj);
        }
    }
}