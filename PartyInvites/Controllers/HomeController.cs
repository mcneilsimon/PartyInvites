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
        public ViewResult RsvpForm(CompetitionInvite guestResponse)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FullName = "Simon McNeil";
                ViewBag.ID = 991426860;

                if (Request.Form["buttonValue"].Equals("accept"))
                {
                    guestResponse.WillAttend = true;
                    GuestResponse.AddResponse(guestResponse);
                }
                else
                {
                    guestResponse.WillAttend = false;
                }

                return View("Thanks", guestResponse);

            }
            else
            {
                //there is a validation error
                return View();
            }
        }

        public ViewResult ListResponses()
        {
            //calls the static method UserResponses in the Repository controller
            return View(GuestResponse.UserResponses.Where(r => r.WillAttend == true));
        }
    }
}
