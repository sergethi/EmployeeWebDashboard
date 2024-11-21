using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EmployeeWebDashboard.Data;
using System;
using System.Linq;

namespace EmployeeWebDashboard.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new EmployeeWebDashboardContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<EmployeeWebDashboardContext>>()))
        {
            // Look for any movies.
            if (context.Employee.Any())
            {
                return;   // DB has been seeded
            }
            context.Employee.AddRange(
                new Employee
                {
                    FullName = "Elvis cart",
                    Title = "Manager",
                    StartDate = DateTime.Parse("1989-2-12"),
                    Team= "Product",
                    Location = "chicago",
                    PhoneNumber = "2123568974",
                    Email = "elv@product.com",
                    Picture = ""
                },
                new Employee
                {
                    FullName = "Madi kabore",
                    Title = "Manager assistant",
                    StartDate = DateTime.Parse("2020-2-12"),
                    Team = "Sells",
                    Location = "New York",
                    PhoneNumber = "2123568974",
                    Email = "madika@sells.com",
                    Picture = ""
                },
                new Employee
                {
                    FullName = "Serge A Nikiema",
                    Title = "Software Engineer",
                    StartDate = DateTime.Parse("2025-1-1"),
                    Team = "Cloud",
                    Location = "Remote",
                    PhoneNumber = "6468525930",
                    Email = "serge@cloud.com",
                    Picture = ""
                },
                new Employee
                {
                    FullName = "Titi Tassembedo",
                    Title = "Web developer",
                    StartDate = DateTime.Parse("2020-2-12"),
                    Team = "E-commerce",
                    Location = "New York",
                    PhoneNumber = "6468523214",
                    Email = "titiTass@product.com",
                    Picture = ""
                }
            );
            context.SaveChanges();
        }
    }
}
