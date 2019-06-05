using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        private SignInManager<IdentityUser> userManager;

        public HomeController(SignInManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var a = 1;


            return View();
        }

        //private async Task DoSomething()
        //{
        //    var range = Enumerable.Range(0, 3);

        //    for (int i = 0; i < range.Count(); i++)
        //    {
        //        var a = 1;
        //        var b = 2;

        //        var result = await TestAsync();

        //        Console.WriteLine(result);
        //    }


        //    var value = new Person();

        //    switch (value)
        //    {
        //        case Student s when s.Name == "ABC":
        //            break;
        //        case Student r when !r.Name.Equals("ABC"):
        //            break;
        //        case null:
        //            Console.WriteLine("faf");
        //            break;
        //        default:
        //            Console.WriteLine("adsas");
        //            break;
        //    }
        //}

        //public class Person
        //{
        //    public string Name { get; set; }
        //}

        //public class Student : Person
        //{

        //}

        //private async Task<string> TestAsync()
        //{
        //    await Task.Delay(2 * 1000);

        //    return "1";
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
