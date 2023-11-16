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
        private readonly GlobalList _GobalList;


        public DeviceController(ItAdminContext login, GlobalList GobalList)
        {
            _login = login;
            _GobalList = GobalList;
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
            Id = i.Id,
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
            Id = j.Id,
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
            Id = j.Id,
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
            var selectListItems = list.Where(c => c.IsArchived == false).Select(category => new SelectListItem
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
        public IActionResult Create(Inventory obj)
        {
            try
            {
                if (string.IsNullOrEmpty(obj.DeviceName) || string.IsNullOrEmpty(obj.SerialNumber) || obj.CategoryId == 0 || obj.StatusId == 0 || obj.AssignedTo == 0)
                {
                    return Json(new { errorMessage = "All fields are mandatory" });
                }

                if (_login.Inventory.Any(u => u.SerialNumber == obj.SerialNumber))
                {
                    return Json(new { errorMessage = "This serial number already exists" });
                }

                if (ModelState.IsValid)
                {
                    DateTime currentDateTime = DateTime.Now;
                    obj.CreatedAtUtc = currentDateTime;
                    obj.UpdatedAtUtc = currentDateTime;
                    obj.UpdatedBy = 1;
                    obj.CreatedBy = 1;

                    History child = new History();
                    child.CategoryName = "";
                    child.Action = "Added";
                    child.DeviceName = obj.DeviceName;
                    //DateTime currentDateTime = DateTime.Now;
                    child.UpdatedAtUtc = currentDateTime;
                    child.UpdatedBy = 1;
                    _GobalList.GlobalListofHistory.Add(child);

                    _login.Inventory.Add(obj);
                    _login.SaveChanges();

                    _login.History.Add(child);
                    _login.SaveChanges();

                    return RedirectToAction("Index");
                    
                }

                return View(obj);
            }
            catch (Exception ex)
            {
                return Json(new { errorMessage = "An error occurred: " + ex.Message });
            }

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
            Id = i.Id,
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
            Id = j.Id,
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
            Id = j.Id,
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

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return BadRequest("NOT FOUND");
            }

            var inventory = _login.Inventory.Find(id);
            if (inventory == null)
            {
                return BadRequest("NOT FOUND"); ;
            }
            ViewData["AssignedTo"] = new SelectList(_login.Employee, "Id", "Email", inventory.AssignedTo);
            ViewData["CategoryId"] = new SelectList(_login.Category, "Id", "CategoryName", inventory.CategoryId);
            ViewData["CreatedBy"] = new SelectList(_login.Employee, "Id", "Email", inventory.CreatedBy);
            ViewData["StatusId"] = new SelectList(_login.StatusTable, "Id", "StatusName", inventory.StatusId);
            ViewData["UpdatedBy"] = new SelectList(_login.Employee, "Id", "Email", inventory.UpdatedBy);
            return View(inventory);
        }

        [HttpPost]
        public IActionResult Edit(Inventory inventory)
        {
            try
            {
                if (string.IsNullOrEmpty(inventory.DeviceName) || string.IsNullOrEmpty(inventory.SerialNumber) || inventory.CategoryId == 0 || inventory.StatusId == 0 || inventory.AssignedTo == 0)
                {
                    return Json(new { errorMessage = "All fields are mandatory" });
                }

                var data = _login.Inventory.Where(x => x.Id == inventory.Id).FirstOrDefault();

                if (data.DeviceName != null && data.SerialNumber != null && data.CategoryId != 0 && data.AssignedTo != 0 && data.StatusId != 0)
                {
                    DateTime currentDateTime = DateTime.Now;
                    data.DeviceName = inventory.DeviceName;
                    data.SerialNumber = inventory.SerialNumber;
                    data.CategoryId = inventory.CategoryId;
                    data.AssignedTo = inventory.AssignedTo;
                    data.StatusId = inventory.StatusId;
                    data.UpdatedBy = 1;
                    data.UpdatedAtUtc = currentDateTime;
                    _login.SaveChanges();

                    History child = new History();
                    child.CategoryName = "";
                    child.Action = "Added";
                    child.DeviceName = inventory.DeviceName;
                    //DateTime currentDateTime = DateTime.Now;
                    child.UpdatedAtUtc = currentDateTime;
                    child.UpdatedBy = 7;
                    _GobalList.GlobalListofHistory.Add(child);
                    _login.History.Add(child);
                    _login.SaveChanges();

                  
                }

                return RedirectToAction("");

            }
            catch (Exception ex)
            {
                return Json(new { errorMessage = "An error occurred: " + ex.Message });
            }
        }

        [HttpPost]
        public IActionResult DeleteDevice(int id)
        {
            var data = _login.Inventory.Where(i => i.Id == id).FirstOrDefault();
            if (data != null)
            {
                History child = new History();
                child.CategoryName = "";
                child.Action = "Added";
                child.DeviceName = data.DeviceName;
                DateTime currentDateTime = DateTime.Now;
                child.UpdatedAtUtc = currentDateTime;
                child.UpdatedBy = 7;
                _GobalList.GlobalListofHistory.Add(child);
                
                _login.Inventory.Remove(data);
                _login.SaveChanges();
                _login.History.Add(child);
                _login.SaveChanges();
            }

            return RedirectToAction("");
        }

    }
}