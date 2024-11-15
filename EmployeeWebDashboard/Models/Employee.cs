using System.ComponentModel.DataAnnotations;

namespace EmployeeWebDashboard.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        public string? Team { get; set; }
        public string? Location { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Picture { get; set; }
    }
}
