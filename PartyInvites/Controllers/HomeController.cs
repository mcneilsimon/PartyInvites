using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    /// <summary>
    /// Home controllers are were we store all of our related actions together.s
    /// </summary>
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            //greeting can be anything we want to define, note we don't use this in the final demo
            ViewBag.Greeting = hour < 12 ? "Goor Morning" : "Good Afternoon"; //we reference the ViewbBag now in MyView
            return View("MyView");
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            } else
            {
                //there is a validation error
                return View();
            }
        }

        public ViewResult ListResponses()
        {
            //calls the static method Responses in the Repository controller
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}
