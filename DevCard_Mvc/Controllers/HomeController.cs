using System;
using DevCard_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly List<Service> _services = new List<Service>
        {
            new Service(1,"نقره ای"),
            new Service(2,"طلایی "),
            new Service(3,"پلاتین"),
            new Service(4,"الماسی"),
        };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact();
            {
                SelectList Services = new SelectList(_services, "Id", "Name");
            }
	        return View(model);
        }
        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    return Json(Ok());
        //}
        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            model.Services = new SelectList(_services, "Id", "Name");
            //if(!ModelState.IsValid==false)
	            if (!ModelState.IsValid)
	            {
		            ViewBag.error = "اطلاعات وارد شده صحیح تیست لظفا دوباره تلاش کتید ";
		            return View(model);
	            }
            // return RedirectToAction("Index");
           ModelState.Clear();
            model = new Contact()
            {
	            Services = new SelectList(_services, "Id", "Name")
			};
           
            
            ViewBag.success = "پیغام شما با موفقیت ارسال شد با تشکر";
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
