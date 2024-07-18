//using OrganizationCreation.Data;
//using OrganizationCreation.Models;
//using Mapster;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using OrganizationETMCreation.Data;
//using OrganizationETMCreation.Models;

//namespace OrganizationCreation
//{
//    public class Seed
//    {
//        private readonly DataContext _dataContext;
//        public Seed(DataContext dataContext)
//        {
//            _dataContext = dataContext;
//        }

//        public void SeedDataContext()
//        {
//            if (!_dataContext.Employees.Any())
//            {
//                var employees = new List<Employee>
//                {
//                    new Employee { Name = "John Doe", Salary = 60000, Age = 30, JoiningDate = DateTime.Now.AddYears(-5) },
//                    new Employee { Name = "Jane Smith", Salary = 80000, Age = 35, JoiningDate = DateTime.Now.AddYears(-8) },
//                    new Employee { Name = "Alice Johnson", Salary = 70000, Age = 28, JoiningDate = DateTime.Now.AddYears(-3) },
//                    new Employee { Name = "Bob Brown", Salary = 50000, Age = 40, JoiningDate = DateTime.Now.AddYears(-10) },
//                    new Employee { Name = "Eve White", Salary = 90000, Age = 45, JoiningDate = DateTime.Now.AddYears(-15) },
//                    // Add more employees if needed
//                };

//                _dataContext.Employees.AddRange(employees);
//                _dataContext.SaveChanges();
//            }

//            if (!_dataContext.Teams.Any())
//            {
//                var teams = new List<Team>
//                {
//                    new Team { Name = "Dev" },
//                    new Team { Name = "QA" },
//                    new Team { Name = "Product" },
//                    new Team { Name = "Marketing" },
//                    new Team { Name = "HR" }
//                    // Add more teams if needed
//                };

//                _dataContext.Teams.AddRange(teams);
//                _dataContext.SaveChanges();
//            }

//            if (!_dataContext.TeamMembers.Any())
//            {
//                var members = new List<Member>
//                {
//                    new Member { Name = "John Doe", Salary = 60000, Age = 30, JoiningDate = DateTime.Now.AddYears(-5), TeamId = 1, ReportsTo = 0, TotalHoursWorked = 0, TotalWorkload = 40 },
//                    new Member { Name = "Jane Smith", Salary = 80000, Age = 35, JoiningDate = DateTime.Now.AddYears(-8), TeamId = 1, ReportsTo = 0, TotalHoursWorked = 0, TotalWorkload = 40 },
//                    new Member { Name = "Alice Johnson", Salary = 70000, Age = 28, JoiningDate = DateTime.Now.AddYears(-3), TeamId = 2, ReportsTo = 0, TotalHoursWorked = 0, TotalWorkload = 40 },
//                    new Member { Name = "Bob Brown", Salary = 50000, Age = 40, JoiningDate = DateTime.Now.AddYears(-10), TeamId = 2, ReportsTo = 0, TotalHoursWorked = 0, TotalWorkload = 40 },
//                    new Member { Name = "Eve White", Salary = 90000, Age = 45, JoiningDate = DateTime.Now.AddYears(-15), TeamId = 3, ReportsTo = 0, TotalHoursWorked = 0, TotalWorkload = 40 },
//                    // Add more members if needed
//                };

//                _dataContext.TeamMembers.AddRange(teamMembers); 
//                _dataContext.SaveChanges();
//            }
//        }
//    }
//}

