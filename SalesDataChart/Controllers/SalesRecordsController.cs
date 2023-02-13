using Microsoft.AspNetCore.Mvc;
using SalesDataChart.DataLayer;
using System.Data.Common;

namespace SalesDataChart.Controllers
{
    public class SalesRecordsController : Controller
    {
        private readonly DbContextSales _context;

        public SalesRecordsController(DbContextSales context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowSalesData() 
        { 
            return View();
        }

        [HttpPost]

        public List<object> GetSalesData()
        {
            List<object> data = new List<object>();

            List<string> labels = _context.SalesData.Select(p=>p.Monthname).ToList();

            data.Add(labels);

            List<int> SalesNumber = _context.SalesData.Select(p => p.TotalSales).ToList();

            data.Add(SalesNumber);
            
            return data;
        }
    }
}
