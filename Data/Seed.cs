using OrganizationETMCreation.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrganizationETMCreation.Data
{
    public class Seed
    {
        private readonly DataContext _context;

        public Seed(DataContext context)
        {
            _context = context;
        }

        public void SeedDataContext()
        {
            if (!_context.Employees.Any())
            {
                var employees = new List<Employee>
                {
                    new Employee { Name = "John Doe", Salary = 60000, Age = 30, JoiningDate = DateTime.Now.AddYears(-5) },
                    new Employee { Name = "Jane Smith", Salary = 80000, Age = 35, JoiningDate = DateTime.Now.AddYears(-8) },
                    new Employee { Name = "Mike Johnson", Salary = 75000, Age = 40, JoiningDate = DateTime.Now.AddYears(-10) },
                    new Employee { Name = "Emily Davis", Salary = 70000, Age = 32, JoiningDate = DateTime.Now.AddYears(-6) }
                };

                _context.Employees.AddRange(employees);
                _context.SaveChanges();
            }

            if (!_context.Teams.Any())
            {
                var teams = new List<Team>
                {
                    new Team { Name = "Dev" ,EmployeeId = 1},
                    new Team { Name = "QA" ,EmployeeId = 3},
                    new Team { Name = "Product",EmployeeId = 1},
                    new Team { Name = "Marketing",EmployeeId = 3},
                    new Team { Name = "HR" ,EmployeeId = 1}
                };

                _context.Teams.AddRange(teams);
                _context.SaveChanges();
            }

            if (!_context.TeamMembers.Any())
            {
                var teamMembers = new List<TeamMember>
                {
                    new TeamMember {memberid = 1,EmployeeId = 1, TeamId = 1, ReportsTo = "Manager", TotalHoursWorked = 0, TotalWorkload = 40 },
                    new TeamMember {memberid = 2, EmployeeId = 2, TeamId = 1, ReportsTo = "Team Manager", TotalHoursWorked = 0, TotalWorkload = 40 },
                    new TeamMember {memberid = 3, EmployeeId = 3, TeamId = 2, ReportsTo = "Tech Manager", TotalHoursWorked = 0, TotalWorkload = 40 },
                    new TeamMember {memberid = 4,EmployeeId = 4, TeamId = 3, ReportsTo = "Lead", TotalHoursWorked = 0, TotalWorkload = 40 }
                };

                _context.TeamMembers.AddRange(teamMembers);
                _context.SaveChanges();
            }
        }
    }
}

