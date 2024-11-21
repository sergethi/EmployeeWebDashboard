using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeWebDashboard.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Display(Name = "Full Name")]
        public string? FullName { get; set; }
        public string? Title { get; set; }
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        public string? Team { get; set; }
        public string? Location { get; set; }
        [Display(Name = "Phone Number")]
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Picture { get; set; }
    }
}
