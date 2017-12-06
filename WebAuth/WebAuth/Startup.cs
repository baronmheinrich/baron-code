using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAuth
{
    public class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            var opt = new CookieAuthenticationOptions()
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                CookieHttpOnly = true,
                CookieName = "Lana-Token",
                LoginPath = new PathString("/account/login")

            };


            app.UseCookieAuthentication(opt);
        }
    }
}