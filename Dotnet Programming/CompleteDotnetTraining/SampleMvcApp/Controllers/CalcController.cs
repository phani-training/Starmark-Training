using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMvcApp.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View();
        }
        //Using Parameters collection
        //[HttpPost]
        //public ActionResult Index(string firstValue, string secondValue, string operand)
        //{
        //    string message = string.Empty;
        //    double v1 = double.Parse(firstValue);
        //    double v2 = double.Parse(secondValue);
        //    switch (operand)
        //    {
        //        case "Add": message = (v1 + v2).ToString(); break;
        //        case "Subtract": message = (v1 - v2).ToString(); break;
        //        case "Multiply": message = (v1 * v2).ToString(); break;
        //        case "Divide": message = (v1 / v2).ToString(); break;
        //        default: message = "Invalid Choice"; break;
        //    }
        //    ViewBag.Message = $"The Result: {message}";
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Index(FormCollection collection)
        //{
        //    string message = string.Empty;
        //    double v1 = double.Parse(collection["firstValue"]);
        //    double v2 = double.Parse(collection["secondValue"]);
        //    switch (collection["operand"])
        //    {
        //        case "Add": message = (v1 + v2).ToString(); break;
        //        case "Subtract": message = (v1 - v2).ToString(); break;
        //        case "Multiply": message = (v1 * v2).ToString(); break;
        //        case "Divide": message = (v1 / v2).ToString(); break;
        //        default: message = "Invalid Choice"; break;
        //    }
        //    //ViewBag.Message = $"The Result: {message}";
        //    ViewData["Message"] = $"The Result: {message}";
        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            string message = string.Empty;
            double v1 = double.Parse(collection["firstValue"]);
            double v2 = double.Parse(collection["secondValue"]);
            switch (collection["operand"])
            {
                case "Add": message = (v1 + v2).ToString(); break;
                case "Subtract": message = (v1 - v2).ToString(); break;
                case "Multiply": message = (v1 * v2).ToString(); break;
                case "Divide": message = (v1 / v2).ToString(); break;
                default: message = "Invalid Choice"; break;
            }
            //ViewBag.Message = $"The Result: {message}";
            ViewData["Message"] = $"The Result: {message}";
            TempData["Message"] = $"The Result: {message}";
            //return RedirectToAction("Index");
            return View("Index");
        }
    }
}