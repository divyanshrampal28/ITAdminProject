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
            List<Category> categories = _login.Category.OrderBy(c => c.Id).ToList();
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

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = _login.Category.Where(x => x.Id == id).FirstOrDefault();

            return View(data);

        }

        [HttpPost]
        public IActionResult Edit(Category Model)
        {
            // Find the category by ID
            var data = _login.Category.Where(x => x.Id == Model.Id).FirstOrDefault();

            if (data != null)
            {
                data.CategoryName = Model.CategoryName;
                _login.SaveChanges();
            }

            return RedirectToAction("");
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            var data = _login.Category.FirstOrDefault(x => x.Id == id);
            if (data != null)
            {
                _login.Category.Remove(data);
                _login.SaveChanges();
            }

            return RedirectToAction(""); 
        }


    }
}