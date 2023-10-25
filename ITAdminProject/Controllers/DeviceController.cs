using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITAdminProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;


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
            var inv = _login.Inventory;
            var cat = _login.Category;
            var stat = _login.StatusTable;
            var emp = _login.Employee;
            IEnumerable<Jnd> jnd = inv
    .Join(cat,
        i => i.CategoryId,
        c => c.Id,
        (i, c) => new Jnd
        {
            DeviceName = i.DeviceName,
            SerialNumber = i.SerialNumber,
            cname = c.CategoryName,
            CreatedAtUtc = i.CreatedAtUtc,
            CreatedBy = i.CreatedBy,
            AssignedTo = i.AssignedTo,
            StatusId = i.StatusId,
            UpdatedAtUtc = i.UpdatedAtUtc,
            UpdatedBy = i.UpdatedBy,
            CategoryId = i.CategoryId
        }).Join(stat,
        j => j.StatusId, s => s.Id,
        (j, s) => new Jnd
        {
            DeviceName = j.DeviceName,
            SerialNumber = j.SerialNumber,
            cname = j.cname,
            CreatedAtUtc = j.CreatedAtUtc,
            CreatedBy = j.CreatedBy,
            AssignedTo = j.AssignedTo,
            StatusId = j.StatusId,
            UpdatedAtUtc = j.UpdatedAtUtc,
            UpdatedBy = j.UpdatedBy,
            StatusName = s.StatusName,
            CategoryId = j.CategoryId
        }).Join(emp,
        j => j.AssignedTo, e => e.Id,
        (j, e) => new Jnd
        {
            DeviceName = j.DeviceName,
            SerialNumber = j.SerialNumber,
            cname = j.cname,
            CreatedAtUtc = j.CreatedAtUtc,
            CreatedBy = j.CreatedBy,
            AssignedTo = j.AssignedTo,
            StatusId = j.StatusId,
            UpdatedAtUtc = j.UpdatedAtUtc,
            UpdatedBy = j.UpdatedBy,
            StatusName = j.StatusName,
            FirstName = e.FirstName,
            CategoryId = j.CategoryId
        });
            List<Inventory> list4 = _login.Inventory.ToList();
            var selectListItems4 = list4.Select(dev => new SelectListItem
            {
                Text = dev.DeviceName,
                Value = dev.DeviceName,
            }).ToList();
            ViewBag.DeviceName = selectListItems4;

            List<Category> list = _login.Category.ToList();
            var selectListItems = list.Select(category => new SelectListItem
            {
                Text = category.CategoryName,
                Value = category.Id.ToString()
            }).ToList();
            ViewBag.CategoryId = selectListItems;


            List<Employee> list2 = _login.Employee.ToList();
            var selectListItems2 = list2.Select(emply => new SelectListItem
            {
                Text = emply.FirstName,
                Value = emply.Id.ToString()
            }).ToList();
            ViewBag.AssignedTo = selectListItems2;

            List<StatusTable> list3 = _login.StatusTable.ToList();
            var selectListItems3 = list3.Select(status => new SelectListItem
            {
                Text = status.StatusName,
                Value = status.Id.ToString()
            }).ToList();
            ViewBag.StatusId = selectListItems3;


            var objjndmodel2 = new Jndmodel2
            {
                listofJnd = jnd,

            };
            return View(objjndmodel2);
        }

        public IActionResult Filter([FromQuery] JsonResult data)
        {
            string json = data.Value.ToString();
            Inventory inv = JsonConvert.DeserializeObject<Inventory>(json);
            return Ok(inv);

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

            List<Employee> list3 = _login.Employee.ToList();
            var selectListItems3 = list3.Select(emp => new SelectListItem
            {
                Text = emp.FirstName,
                Value = emp.Id.ToString()
            }).ToList();

            ViewBag.AssignedTo = selectListItems3;

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
            obj.UpdatedBy = 4;
            obj.CreatedBy = 4;

            _login.Inventory.Add(obj);
            _login.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Index(Jndmodel2 obj)
        {
            var catId = obj.CategoryId;
            var assTo = obj.AssignedTo;
            var statId = obj.StatusId;
            var dname = obj.DeviceName;



            var inv = _login.Inventory;
            var cat = _login.Category;
            var stat = _login.StatusTable;
            var emp = _login.Employee;
            IEnumerable<Jnd> jnd = inv
    .Join(cat,
        i => i.CategoryId,
        c => c.Id,
        (i, c) => new Jnd
        {
            DeviceName = i.DeviceName,
            SerialNumber = i.SerialNumber,
            cname = c.CategoryName,
            CreatedAtUtc = i.CreatedAtUtc,
            CreatedBy = i.CreatedBy,
            AssignedTo = i.AssignedTo,
            StatusId = i.StatusId,
            UpdatedAtUtc = i.UpdatedAtUtc,
            UpdatedBy = i.UpdatedBy,
            CategoryId = i.CategoryId
        }).Join(stat,
        j => j.StatusId, s => s.Id,
        (j, s) => new Jnd
        {
            DeviceName = j.DeviceName,
            SerialNumber = j.SerialNumber,
            cname = j.cname,
            CreatedAtUtc = j.CreatedAtUtc,
            CreatedBy = j.CreatedBy,
            AssignedTo = j.AssignedTo,
            StatusId = j.StatusId,
            UpdatedAtUtc = j.UpdatedAtUtc,
            UpdatedBy = j.UpdatedBy,
            StatusName = s.StatusName,
            CategoryId = j.CategoryId
        }).Join(emp,
        j => j.AssignedTo, e => e.Id,
        (j, e) => new Jnd
        {
            DeviceName = j.DeviceName,
            SerialNumber = j.SerialNumber,
            cname = j.cname,
            CreatedAtUtc = j.CreatedAtUtc,
            CreatedBy = j.CreatedBy,
            AssignedTo = j.AssignedTo,
            StatusId = j.StatusId,
            UpdatedAtUtc = j.UpdatedAtUtc,
            UpdatedBy = j.UpdatedBy,
            StatusName = j.StatusName,
            FirstName = e.FirstName,
            CategoryId = j.CategoryId
        });



            if (dname != null)
            {
                jnd = jnd.Where(item => item.DeviceName == dname);
            }

            if (catId > 1)
            {
                jnd = jnd.Where(item => item.CategoryId == catId);
            }

            if (assTo > 1)
            {
                jnd = jnd.Where(item => item.AssignedTo == assTo);
            }

            if (statId > 1)
            {
                jnd = jnd.Where(item => item.StatusId == statId);
            }

            List<Inventory> list4 = _login.Inventory.ToList();
            var selectListItems4 = list4.Select(dev => new SelectListItem
            {
                Text = dev.DeviceName,
                Value = dev.DeviceName,
            }).ToList();
            ViewBag.DeviceName = selectListItems4;


            List<Category> list = _login.Category.ToList();
            var selectListItems = list.Select(category => new SelectListItem
            {
                Text = category.CategoryName,
                Value = category.Id.ToString()
            }).ToList();
            ViewBag.CategoryId = selectListItems;

            List<Employee> list2 = _login.Employee.ToList();

            var selectListItems2 = list2.Select(emply => new SelectListItem
            {
                Text = emply.FirstName,
                Value = emply.Id.ToString()
            }).ToList();
            ViewBag.AssignedTo = selectListItems2;

            List<StatusTable> list3 = _login.StatusTable.ToList();
            var selectListItems3 = list3.Select(status => new SelectListItem
            {
                Text = status.StatusName,
                Value = status.Id.ToString()
            }).ToList();
            ViewBag.StatusId = selectListItems3;

            var objjndmodel2 = new Jndmodel2
            {
                listofJnd = jnd,

            };

            //var items = Jnd.Where
            //var items = _login.Inventory.Where(item => item.DeviceName == "Dell123").ToList();
            return View(objjndmodel2);
        }

    }
}