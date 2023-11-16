using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITAdminProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ITAdminProject.Controllers
{
    public class LogsController : Controller
    {
        private readonly ItAdminContext _login;
        private readonly GlobalList _GobalList;

        public LogsController(ItAdminContext login, GlobalList GobalList)
        {
            _login = login;
            _GobalList = GobalList;
        }
        public IActionResult Index()
        {
            List<History> list1 = _login.History.Where(l => l.DeviceName != null && l.DeviceName.Length > 0).ToList();
            var selectListItems1 = list1.Select(dev => new SelectListItem
            {
                Text = dev.DeviceName,
                Value = dev.DeviceName,
            }).ToList();
            ViewBag.DeviceName = selectListItems1;

            Dashboard dash = new Dashboard();
            //DateTime twentyFourHoursAgo = DateTime.Now.AddHours(-24);

            _GobalList.GlobalListofHistory = _login.History.ToList();
            dash.glist = _GobalList.GlobalListofHistory;
            //  .Where(i => i.UpdatedAtUtc >= twentyFourHoursAgo)
            //.ToList();

            return View(dash);
            //Dashboard dash = new Dashboard();
            //DateTime twentyFourHoursAgo = DateTime.Now.AddHours(-24);

            //_GobalList.GlobalListofHistory = _login.History.ToList();
            //dash.glist = _GobalList.GlobalListofHistory
            //    .Where(i => i.UpdatedAtUtc >= twentyFourHoursAgo)
            //    .ToList();

            //return View(dash);
        }

        [HttpPost]
        public List<string> GetUserName(List<int> userlist)
        {
            List<string> name = new List<string>();
            foreach(var id in userlist)
            {
                var employeeInfo = _login.Employee.FirstOrDefault(e => e.Id == id);
                name.Add(employeeInfo.FirstName);
            }


            return name;
            

        }
        [HttpPost]
        public List<History> Filter(FilterLogs data)
        {
            List<History> list = _login.History.ToList();
            if (data.Type == "Device")
            {
                list = list.Where(l => !string.IsNullOrEmpty(l.DeviceName)).ToList();
            }
            else if (data.Type == "Category")
            {
                list = list.Where(l => !string.IsNullOrEmpty(l.CategoryName)).ToList();
            }

            if (data.DeviceName != "All")
            {
                list = list.Where(l => String.Equals(l.DeviceName, data.DeviceName, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (data.Action != "All")
            {
                list = list.Where(l => String.Equals(l.Action, data.Action, StringComparison.OrdinalIgnoreCase)).ToList();
            }


            switch (data.Duration)
            {
                case "24":
                    // Filter for the last 24 hours
                    list = list.Where(l => l.UpdatedAtUtc >= DateTime.Now.AddHours(-24)).ToList();
                    break;
                case "week":
                    // Filter for the last week
                    list = list.Where(l => l.UpdatedAtUtc >= DateTime.Now.AddDays(-7)).ToList();
                    break;
                case "month":
                    // Filter for the last month
                    list = list.Where(l => l.UpdatedAtUtc >= DateTime.Now.AddMonths(-1)).ToList();
                    break;
                case "year":
                    // Filter for the last year
                    list = list.Where(l => l.UpdatedAtUtc >= DateTime.Now.AddYears(-1)).ToList();
                    break;
                default:
                    // No specific duration selected, return the entire list
                    break;
            }
            //if (data.Type != null && String.Equals(data.Type, "DeviceName", StringComparison.OrdinalIgnoreCase))
            //{
            //    list = list.Where(l => !string.IsNullOrEmpty(l.DeviceName)).ToList();
            //}
            //else
            //{
            //    list = list.Where(l => !string.IsNullOrEmpty(l.CategoryName)).ToList();
            //}

            //if (!String.Equals(data.DeviceName, "All", StringComparison.OrdinalIgnoreCase))
            //{
            //    list = list.Where(l => String.Equals(l.DeviceName, data.DeviceName, StringComparison.OrdinalIgnoreCase)).ToList();
            //}

            return list;
        }
    }
}