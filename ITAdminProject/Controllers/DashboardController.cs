﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITAdminProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Highsoft.Web.Mvc.Charts;

namespace ITAdminProject.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ItAdminContext _login;

        public DashboardController(ItAdminContext login)
        {
            _login = login;
        }
        // public List<Pie> Pie { get; set; }
        public IActionResult Index()
        {
            Dashboard dash = new Dashboard();
            //dash.pielist = new List<Pie>();

            //dash.barlist = _login.Inventory
            //    .GroupBy(e => e.AssignedToNavigation.FirstName)
            //    .Select(g => new Bar
            //    {
            //        Category = g.Key,
            //        CategoryCount = g.Count(),
            //    }).ToList();

            dash.barlist = _login.Category.Select(c => new Bar
            {
                Category = c.CategoryName,
                CategoryCount = c.Inventory.Count(),
            }).ToList();


            dash.pielist = _login.Inventory
             .GroupBy(i => i.AssignedToNavigation.FirstName)
             .Select(g => new Pie
             {
                 FirstName = g.Key,
                 DeviceCount = g.Count()
             })
             .ToList();

            dash.emp = _login.Employee.Count();
            dash.dev = _login.Inventory.Count();
            dash.unalottedcount = _login.Inventory.Where(s => s.StatusId == 2).Count();

            return View(dash);
        }
    }
}