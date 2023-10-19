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
            List<Role> roles = _login.Role.ToList();
            List<SelectListItem> roleList = roles.Select(r => new SelectListItem
            {
                Text = r.RoleName,
                Value = r.Id.ToString()  
            }).ToList();

            roleList = roleList.Where(role => role.Value != "1").ToList();

            ViewBag.RoleList = roleList;

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