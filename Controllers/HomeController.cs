using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SpendSmart.Models;
using SpendSmart.Views.Home;

namespace SpendSmart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly SpendSmartDbContext _context;  //  save,move, change  things to data base

        public HomeController(ILogger<HomeController> logger, SpendSmartDbContext context)
        {
            _logger = logger;
            _context = context;
         
        }

        public IActionResult index()
        {
            return View();
        }
        public IActionResult Expenses()
        {
            var allExpenses= _context.Expenses.ToList();
            return View(allExpenses);
        }
        public IActionResult CreateEditExpense()
        {
            return View();
        }
        public IActionResult CreateEditExpenseForm(Expense model)
        {

            _context.Expenses.Add(model);  //  context thing in data base
            _context.SaveChanges();
            return RedirectToAction("Expenses");
        }

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
