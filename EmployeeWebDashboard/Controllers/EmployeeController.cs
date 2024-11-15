using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace EmployeeWebDashboard.Controllers
{
    public class EmployeeController : Controller
    {
        // GET /Employee
        public IActionResult Index()
        {
            return View();
        }

        // GET /Employee/Welcome
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["message"] = "Hello" + name + "! Welcome  to the Employee dashboard";
            ViewData["numTimes"] = numTimes;
            return View();
        }
    }
}
