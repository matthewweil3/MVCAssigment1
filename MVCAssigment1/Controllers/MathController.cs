using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCAssigment1.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Tax (double a)
        {
            double taxpercent = 0.06;
            double taxes = taxpercent * a;

            double total = taxes + a;

            ViewData["total"] = total;
            return View();

        }

        
    }
}
