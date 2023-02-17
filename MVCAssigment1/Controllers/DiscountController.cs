using Microsoft.AspNetCore.Mvc;

namespace MVCAssigment1.Controllers
{
    public class DiscountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DiscountCalculator(int a, double b)
        {
            double discount = b / 100;
            double discountamount = a * discount;
            double total = a - discountamount;
            total = Math.Round(total, 2);
            ViewData["total"] = total;
            ViewData["discount"] = b;
            return View();
        }
    }
}
