using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using myfirstwebapp.Models;

namespace myfirstwebapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("/reserve", Name = "Reservation")]
        public IActionResult Reservation()
        {
            return View();
        }

        [HttpPost]
        [Route("/api/reserve")]
        public string Reserve()
        {
            var payload = HttpContext.Request.Form;
            var startTime = TimeSpan.Parse("10:00");
            var endTime = TimeSpan.Parse("19:00");
            var time = TimeSpan.Parse(payload["Time"]);
            bool isInRange = time >= startTime && time <= endTime;
            if (isInRange)
            {
                var js = JsonConvert.SerializeObject(new { FirstName = payload["FirstName"], LastName = payload["LastName"], Doctor = payload["Doctor"], Time = payload["Time"] });
                System.IO.File.AppendAllText("reserve.json", js);
                return "done";
            }
            else
            {
                return "Sorry You cant reserve Work Time is - 10:00/19:00 ";
            }
        

        }
        [Route("/reserved")]
        public IActionResult Reserved()
        {
            JsResearved js = JsonConvert.DeserializeObject<JsResearved>(System.IO.File.ReadAllText("Reserve.json").Replace("[", "").Replace("]", ""));
            return Json(js);
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
    }
    public class JsResearved
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Doctor { get; set; }
        public string Time { get; set; }
    }
}
    
