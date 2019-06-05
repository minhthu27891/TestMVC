using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication6.Controllers
{
    public class HelloController : Controller
    {
        public string Index()
        {
            return "Hello";
        }

        public string Welcome()
        {
            return "Welcome";
        }
    }
}