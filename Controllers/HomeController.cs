using System;
using Microsoft.AspNetCore.Mvc;
namespace portfolio.Controllers
{
    public class HomeController: Controller
    {
        //routes
        // localhost:5000
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
          return View("index");
        }

        // localhost:5000/projects
        [HttpGet]
        [Route("Projects")]
        public IActionResult Projects()
        {
          return View("projects");
        }

        // localhost:5000/contact
        [HttpGet]
        [Route("Contact")]
        public IActionResult contact(string name, string email, string message)
        {
          ViewBag.name = name;
          ViewBag.email = email;
          ViewBag.message = message;
          return View();
        }

        // localhost:5000/submitcontact
        [HttpPost]
        [Route("SubmitContact")]
        public IActionResult SubmitContact(string name, string email, string message)
        {
          return RedirectToAction("contact", new {Name = name, Email = email, Message = message});
        }
    }
}