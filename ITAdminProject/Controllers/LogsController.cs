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
    }
}