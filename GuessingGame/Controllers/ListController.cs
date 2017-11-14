using GuessingGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuessingGame.Controllers
{
    public class ListController : Controller
    {
        // GET: List
        public ActionResult Index(ListModel model)
        {
            return View(model);
        }

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ListModel model)
        {
            return RedirectToAction("Index", model);
        }
    }
}