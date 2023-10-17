using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITAdminProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITAdminProject.Controllers
{
    public class welcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly ItAdminContext _login;

        public welcomeController(ItAdminContext login)
        {
            _login = login;
        }

                [HttpPost]
                public IActionResult Index(Employeechk obj)
                {
                    if (ModelState.IsValid)
                    {
                        //var chkpass = Hashing.ToSHA256(obj.Password);
                        List<Employee> lofusers = _login.Employee.ToList();
                        Employee send = new Employee();
                        bool f = false;
                        lofusers.ForEach(u =>
                        {
                            if (u.Email == obj.Email && u.Password == obj.Password)
                            {
                                f = true;
                                send = u;
                            }
                       });
                       if (f)
                        {
                            if (send.RoleId == 1)
                            {
                        
                        return View();
                            }
                            else
                            {
                        
                                return RedirectToAction("Index", "IsAdmin");
                            }

                            //return RedirectToAction("welcome", "Index");
                        }
                    }
                    //return RedirectToAction("Index", "Home");
                    return RedirectToAction("Index", "Register"); 
                }
        //public IActionResult Create()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Create(Category req)
        //{
        //    if (_login.Category.Any(u => u.CategoryName == req.CategoryName))
        //    {
        //        return BadRequest("this category already exists");
        //    }
        //    _login.Category.Add(req);
        //    _login.SaveChanges();

        //    TempData["SuccessMessage"] = "Category created successfully"; // Add success message to TempData

        //    return RedirectToAction("");
        //}

    }

        


}

           