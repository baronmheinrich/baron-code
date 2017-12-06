using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using WebAuth.Models;
using System.Security.Cryptography;
using Microsoft.Owin.Security;

namespace WebAuth.Controllers
{
    public class AccountController : Controller
    {
        private static Dictionary<string, ClaimsIdentity> _UserStore = new Dictionary<string, ClaimsIdentity>();

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
        public ActionResult Register(Profile p)
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

                var id = new ClaimsIdentity(claims, "ApplicationCookie");
                

                _UserStore.Add(p.Email, id);

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
                var auth = Request.GetOwinContext().Authentication;
                var props = new AuthenticationProperties()
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTime.UtcNow.AddHours(1)
                };
                auth.SignIn(props, _UserStore[p.Email]);
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
                var req = Request.GetOwinContext().Authentication;
                req.SignOut();

                return RedirectToAction("Home");
            }

            return RedirectToAction("Error");

        }
    }


}