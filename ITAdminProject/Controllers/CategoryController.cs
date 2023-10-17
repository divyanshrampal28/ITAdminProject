using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITAdminProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITAdminProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ItAdminContext _login;

        public CategoryController(ItAdminContext login)
        {
            _login = login;
        }
        public IActionResult Index()
        {
            List<Category> categories = _login.Category.ToList();
            ViewBag.Category = categories;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category req)
        {
            if (_login.Category.Any(u => u.CategoryName == req.CategoryName))
            {
                return BadRequest("this category already exists");
            }
            _login.Category.Add(req);
            _login.SaveChanges();

            TempData["SuccessMessage"] = "Category created successfully"; // Add success message to TempData

            return RedirectToAction("");
        }

        [HttpPost]
        public IActionResult Edit(Category req)
        {

            var cat = _login.Category.Find(req.Id);

            if(cat == null)
            {
                return BadRequest("Invalid Id");
            }

            _login.Category.Update(cat);

            _login.SaveChanges();

            TempData["SuccessMessage"] = "Category created successfully"; // Add success message to TempData

            return RedirectToAction("");
        }


    }
}