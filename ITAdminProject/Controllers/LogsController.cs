using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITAdminProject.Models;
using Microsoft.AspNetCore.Mvc;

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
            Dashboard dash = new Dashboard();
            DateTime twentyFourHoursAgo = DateTime.Now.AddHours(-24);

            _GobalList.GlobalListofHistory = _login.History.ToList();
            dash.glist = _GobalList.GlobalListofHistory
                .Where(i => i.UpdatedAtUtc >= twentyFourHoursAgo)
                .ToList();

            return View(dash);
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

    }
}