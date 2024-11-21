using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
namespace EmployeeWebDashboard.Models
{
    public class EmployeeTeamViewModel
    {
        public List<Employee>? Employees { get; set; }
        public SelectList? Teams { get; set; }
        public string? EmployeeTeam { get; set; }
        public string? SearchString { get; set; }
    }
}
