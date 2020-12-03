using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication26.Models;

namespace WebApplication26.Controllers
{
    public class Login : Controller
    {

       


        public IActionResult Index()
        {

            return PartialView();
        }
        [HttpPost]
        public ActionResult Index(Logincs objs)

        {

            if (!ModelState.IsValid) { return View(); }
            else
            {
                if ((objs.Username == "Admin") && (objs.Password == "Admin123"))
               
                {

                    HttpContext.Session.SetString("name", "Jignesh Trivedi");
                    //this.Session.SetString("TransId", "x001");
                    //Session["UserId"] = Guid.NewGuid();

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Failed");
                    return PartialView(objs);
                }


            }
        }
    }
}
