using GuessingGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace FizzBuzzMVC.Controllers
{
    public class FizzBuzzController : Controller
    {
        private string ToFizzBuzz(int value)
        {
            var isDivisibleBy5 = value % 5 == 0;
            var isDivisibleBy3 = value % 3 == 0;

            if (isDivisibleBy5 && isDivisibleBy3) return "FizzBuzz";
            if (isDivisibleBy5) return "Buzz";
            if (isDivisibleBy3) return "Fizz";

            return $"{value}";
        }
        // GET: FizzBuzz
        public ActionResult Index()
        {
            var model = Enumerable.Range(1, 100).Select(ToFizzBuzz);

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(FizzBuzz input)
        {
            var model = Enumerable.Range(1, input.FizzBuzzNumber).Select(ToFizzBuzz);
            return View(model);
        }

        // GET: Edit
        public ActionResult Edit()
        {
            return View();
        }

        // GET: SingleNumber
        public ActionResult SingleNumber()
        {
            return View();
        }
        
        // POST: SingleNumber
        [HttpPost]
        public ActionResult SingleNumber(FizzBuzz input)
        {
            ViewBag.SingleNumber = ToFizzBuzz((int)input.FizzBuzzNumber);
            return View();
        }
    }
}