﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITAdminProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.DependencyInjection;

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

            // List<Employee> users = _login.Employee.ToList();
            List<EmployeeRoleModel> users = _login.Employee
        .Join(
            _login.Role,
            e => e.RoleId,
            r => r.Id,
            (e, r) => new EmployeeRoleModel
            {
                Id = e.Id,
                FirstName = e.FirstName,
                LastName = e.LastName,
                Email = e.Email,
                Password = e.Password,
                RoleId = e.RoleId,
                RoleName = r.RoleName
            })
        .ToList();

            ViewBag.users = users;

            return View();
        }

        

        [HttpPost]
        public IActionResult Index(Employee obj)
        {
            try
            {
                if (string.IsNullOrEmpty(obj.FirstName) || string.IsNullOrEmpty(obj.LastName) || string.IsNullOrEmpty(obj.Email) || string.IsNullOrEmpty(obj.Password) || obj.RoleId == 0)
                {
                    return Json(new { errorMessage = "All fields are mandatory" });
                }
                //if (ModelState.IsValid)
                //{
                //var newpass = Hashing.ToSHA256(obj.Password);
                //obj.Password = newpass;
                _login.Employee.Add(obj);
                _login.SaveChanges();
                //return RedirectToAction("Index", "Home");
                //}

                return RedirectToAction("");
            }
            catch (Exception ex)
            {
                return Json(new { errorMessage = "An error occurred: " + ex.Message });
            }
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var data = _login.Employee.Where(i => i.Id == id).FirstOrDefault();
            if(data == null)
            {
                return BadRequest("User not found");
            }

            return View(data);
        }

        [HttpPost]
        public IActionResult Update(Employee emp)
        {
            try {
                    if (string.IsNullOrEmpty(emp.FirstName) || string.IsNullOrEmpty(emp.LastName) || string.IsNullOrEmpty(emp.Email))
                    {
                        return Json(new { errorMessage = "All fields are mandatory" });
                    }

                var data = _login.Employee.FirstOrDefault(i => i.Id == emp.Id);
                    if (data.FirstName != null && data.LastName != null && data.Email != null)
                    {
                        data.FirstName = emp.FirstName;
                        data.LastName = emp.LastName;
                        data.Email = emp.Email;
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
        public IActionResult Delete(int id)
        {
            var data = _login.Employee.FirstOrDefault(i => i.Id == id);
            if (data != null)
            {
                var empinvdata = _login.Inventory.Where(i => i.AssignedTo == data.Id);
                foreach (var dev in empinvdata)
                {
                    var targetController = ActivatorUtilities.CreateInstance<DeviceController>(HttpContext.RequestServices);
                    //RedirectToAction("DeleteDevice", "Device",dev.Id);
                    var result = targetController.DeleteDevice(dev.Id); 
                    if (result is RedirectToActionResult redirectToAction && redirectToAction.ActionName == "Index")
                    {
                    }
                    else
                    {
                    }
                }

                _login.Employee.Remove(data);
                _login.SaveChanges();

            }
            return RedirectToAction("");
        }
    }
}