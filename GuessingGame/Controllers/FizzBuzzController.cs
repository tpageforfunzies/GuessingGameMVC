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
    }
}