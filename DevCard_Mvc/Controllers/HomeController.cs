using System;
using DevCard_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using DevCard_Mvc.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_Mvc.Controllers
{
    
   // [Route("/inventory/products")]
   // [Route("/inventory/products/{action}")]
    //localhost:5001/inventory/products/index
    //localhost:5001/inventory/products/contact
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

        //[Route("MyIndex/{name?}/{model?}")]
        // localhost:5001/inventory/products/MyIndex
        public IActionResult Index( string name,string model)
        {
            
            return View();
        }

        public IActionResult ProjectDetails(long id)
        {
            var project = ProjectStore.GetProjectBy(id);
            return View(project);
        }

        //[HttpGet("ContactPage")]
       // [Route("ContactPage")]
       //localhost:5001/inventory/products/ContactPage
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
