using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaceGun.Web.Modules
{
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            Get["/"] = _ =>
            {
                return "Hello world";
            };
        }
    }
}