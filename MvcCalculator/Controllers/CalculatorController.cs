using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculator;

namespace MvcCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        //
        // GET: /Calculator/
        Calculator.Calculator mycalculator = new Calculator.Calculator();

        public ActionResult Index()
        {
            // DFB: view should contain two textboxes for each number then an "add" button
            return View();
        }

        public ActionResult Result(FormCollection formCollection)
        {
            // DFB: view should contain two textboxes for each number then an "add" button
            mycalculator.Add(int.Parse(formCollection["first"].Trim()));
            mycalculator.Add(int.Parse(formCollection["second"].Trim()));
            mycalculator.Sum();
            
            ViewData["result"] = mycalculator.Total();
            return View();
        }
    }
}
