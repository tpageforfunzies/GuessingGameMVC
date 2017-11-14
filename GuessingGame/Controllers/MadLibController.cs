using GuessingGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuessingGame.Controllers
{
    public class MadLibController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        //POST: Index
        [HttpPost]
        public ActionResult Index(MadLib model)
        {
            ViewBag.Story = $"The {model.Adjective1} cat was about to {model.Verb1} but suddenly a {model.Noun1} interrupted! " +
                $"There's a giant feral {model.Noun2} coming and it will {model.Verb2} you up if you don't leave! " +
                $"Proud of themselves, the {model.Adjective2} {model.Noun1} watched you leave and didnt see the {model.Noun2} " +
                $"coming and promptly got wrecked.";
            return View();
        }

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }


    }
}