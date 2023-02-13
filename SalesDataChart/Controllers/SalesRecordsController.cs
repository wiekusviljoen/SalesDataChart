using Microsoft.AspNetCore.Mvc;

namespace SalesDataChart.Controllers
{
    public class SalesRecordsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowSalesData() 
        { 
            return View();
        }
    }
}
