﻿using AuthCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AuthCore.Controllers
{
    public class AccountController : Controller
    {
        private static Dictionary<string, ClaimsPrincipal> _UserStore = new Dictionary<string, ClaimsPrincipal>();

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Register()
        {
            return View(new Profile());
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Manager")]
        [HttpGet]
        public ActionResult Home()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Error()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult SignIn()
        {
            return View(new Profile());
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Register([FromForm]Profile p)
        {
            if (ModelState.IsValid)
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, p.Name, ClaimValueTypes.String),
                    new Claim(ClaimTypes.Role, p.Role, ClaimValueTypes.String),
                    new Claim(ClaimTypes.Email, p.Email, ClaimValueTypes.Email),
                    new Claim("username", p.Username),
                    new Claim("password", p.Password)
                };

                var id = new ClaimsIdentity(claims, "supercookie");
                var user = new ClaimsPrincipal(id);


                _UserStore.Add(p.Email, user);

                return RedirectToAction("SignIn");
            }
            return RedirectToAction("Register");
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult SignIn(Profile p)
        {
            if (ModelState.IsValid && _UserStore.ContainsKey(p.Email))
            {
                var auth = Request.HttpContext.Authentication;
                var props = new AuthenticationProperties()
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTime.UtcNow.AddHours(1)
                };
                auth.SignInAsync("supercookie",_UserStore[p.Email],props);
                return RedirectToAction("Home");
            }

            return RedirectToAction("Error");
        }

        [Authorize]
        [HttpGet]
        public ActionResult Signout()
        {
            if (ModelState.IsValid)
            {
                var req = Request.HttpContext.Authentication;
                req.SignOutAsync("supercookie");

                return RedirectToAction("Home");
            }

            return RedirectToAction("Error");

        }
    }
}
