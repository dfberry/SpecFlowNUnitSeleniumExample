using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        //
        // GET: /Calculator/

        public ActionResult Index()
        {
            // DFB: view should contain two textboxes for each number then an "add" button
            return View();
        }
        
        public ActionResult Result()
        {
            // DFB: view should contain two textboxes for each number then an "add" button
            ViewData["result"] = "130";
            return View();
        }
    }
}
