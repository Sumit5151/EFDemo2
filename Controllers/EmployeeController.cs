using EFDemo2.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFDemo2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {

            BrightDb1Context DB = new BrightDb1Context();
            var employees = DB.Employees.ToList();
            return View(employees);
        }
    }
}
