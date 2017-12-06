using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContactApp.Client.Models;

namespace ContactApp.Client.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Contact());
        }

        [HttpPost]
        public IActionResult Create([FromForm] Contact contact)
        {
            if (contact == null)
            {
                return RedirectToAction("Create");
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        [IgnoreAntiforgeryToken]
        public IActionResult GetCreate(Contact contact)
        {
            if (contact == null)
            {
                return RedirectToAction("Create");
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        [IgnoreAntiforgeryToken]
        public IActionResult GetCreate([Bind(include:"ContactId,Name")]Contact contact)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Create");
        }


    }
}