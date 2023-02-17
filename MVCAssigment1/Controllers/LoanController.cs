using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCAssigment1.Controllers
{
    public class LoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoanCalculator(int a, double b, int c)
        {
            double percent = b / 100;
            double totalpay = a * (Math.Pow(percent + 1, c));
            totalpay = Math.Round(totalpay, 2);
            ViewData["totalpay"] = totalpay;
            ViewData["Years"] = c;
            return View();
        }


    }
}
