using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITAdminProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ITAdminProject.Controllers
{
    public class DeviceController : Controller
    {
        private readonly ItAdminContext _login;


        public DeviceController(ItAdminContext login)
        {
            _login = login;
        }
        public IActionResult Index()
        {
            IEnumerable<Inventory> obj = _login.Inventory;
            return View(obj);
        }

        public IActionResult Create()
        {
            List<Category> list = _login.Category.ToList();
            var selectListItems = list.Select(category => new SelectListItem
            {
                Text = category.CategoryName,
                Value = category.Id.ToString()
            }).ToList();

            ViewBag.CategoryId = selectListItems;
            //        ViewBag.CategoryId = new List<SelectListItem>

            //{

            //            new SelectListItem { Text = "Laptop", Value = "1" },
            //            new SelectListItem { Text = "Mobile", Value = "2" },
            //            new SelectListItem { Text = "Tablet", Value = "3" },
            //            new SelectListItem { Text = "Mouse", Value = "4" },
            //            // Add more items as needed
            //        };
            List<StatusTable> list2 = _login.StatusTable.ToList();
            var selectListItems2 = list2.Select(category => new SelectListItem
            {
                Text = category.StatusName,
                Value = category.Id.ToString()
            }).ToList();
            ViewBag.StatusId = selectListItems2;
            return View();
        }

        [HttpPost]
        public IActionResult Send(Inventory obj)
        {
            DateTime currentDateTime = DateTime.Now;
            obj.CreatedAtUtc = currentDateTime;
            obj.UpdatedAtUtc = currentDateTime;
            obj.UpdatedBy = 1;
            obj.CreatedBy = 1;

            _login.Inventory.Add(obj);
            _login.SaveChanges();
            //currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            return RedirectToAction("Index");
        }


    }
}