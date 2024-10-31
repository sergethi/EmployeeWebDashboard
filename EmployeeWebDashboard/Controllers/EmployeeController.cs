using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace EmployeeWebDashboard.Controllers
{
    public class EmployeeController : Controller
    {
        // GET /Employee
        public IActionResult Index()
        {
            return Content("Employee controller");
        }

        // GET /Employee/Welcome
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}! Welcome  to the Employee dashboard!!... ID: {ID}");
        }
    }
}
