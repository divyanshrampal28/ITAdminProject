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
        private readonly GlobalList _GobalList;

        public DashboardController(ItAdminContext login, GlobalList GobalList)
        {
            _login = login;
            _GobalList = GobalList;
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
            DateTime twentyFourHoursAgo = DateTime.Now.AddHours(-24);

            dash.glist = _GobalList.GlobalListofHistory
                .Where(i => i.UpdatedAtUtc >= twentyFourHoursAgo)
                .ToList();

            return View(dash);
        }
        public List<string> CalenderBefore(DateTime currentDate)
        {
            List<string> result = new List<string>();

            // Calculate the start date for the last 24 hours
            DateTime startDate = currentDate.AddHours(-24);

            // Assuming you're using Entity Framework, you can query your database
            // to retrieve data that falls within the specified time range.
            // using (YourDbContext dbContext = new YourDbContext())
            //{
            result = _login.Inventory
                .Where(item => item.UpdatedAtUtc >= startDate && item.UpdatedAtUtc <= currentDate)
                .Select(item => item.DeviceName)
                .ToList();
            //}

            return result;
        }

        public List<string> CalenderAfter(DateTime currentDate)
        {
            List<string> result = new List<string>();

            // Calculate the start date for the last 24 hours
            DateTime startDate = currentDate.AddHours(+24);

            // Assuming you're using Entity Framework, you can query your database
            // to retrieve data that falls within the specified time range.
            // using (YourDbContext dbContext = new YourDbContext())
            //{
            result = _login.Inventory
                .Where(item => item.UpdatedAtUtc <= startDate && item.UpdatedAtUtc >= currentDate)
                .Select(item => item.DeviceName)
                .ToList();
            //}

            return result;
        }
    }
}