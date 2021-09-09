using GasStation_Tran.Models;
using GasStation_Tran.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GasStation_Tran.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUser _user;

        [BindProperty]
        public User user { get; set; }

        public HomeController(ILogger<HomeController> logger, IUser user)
        {
            _logger = logger;
            _user = user;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Login()
        {
            if(user != null)
            {
                if (ModelState.IsValid)
                {
                    var result = _user.Login(user);
                    if(result != null)
                    {
                        var session = HttpContext.Session;
                        SessionModel sessionModel = new SessionModel()
                        {
                            UserName = result.Email,
                            Id = result.UserId
                        };
                        string jsonUser = JsonConvert.SerializeObject(sessionModel);
                        session.SetString(KeySession.KeyAccess, jsonUser);
                        return RedirectToAction("Index", "GasStation");
                    }
                    else
                    {
                        return View();
                    }
                }
            }
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Feedback()
        {
            
            return View();
        }

    }
}
