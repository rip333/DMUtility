using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DungeonMasterUtilityWebApp.Controllers
{
    public class DefaultController : Controller
    {
        [Route("")]
        public string Index()
        {
            return "Welcome to my website.  It is currently UNDER CONSTRUCTION.  Shoutout to Ben Robertshaw!";
        }

        [Route("Error")]
        public string Error()
        {
            return "Error";
        }
    }
}