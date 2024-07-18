using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrganizationETMCreation.Models
{
    public class Employee
    {
        public Employee() { } 
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
        public string? memberrole {  get; set; } 
        public DateTime JoiningDate { get; set; }
        //public int EmployeeId { get; set; } 
        /// <summary>
        //public int employeeid { get; set; } 
        /// </summary>
        //public ICollection<TeamMember> TeamMembers { get; set; } = new List<TeamMember>();
        //public int SalaryId { get; set; } = int.MaxValue;
        public string? ReportsTo { get; set; }
        //public int ReportsToId { get; set; } = int.MaxValue;
        public int TotalHoursWorked { get; set; } = 0;
        public int TotalWorkload { get; set; } = 0;
        //public Team? Team { get; set; } = null;
        //public int TeamId { get; set; }

        public ICollection<TeamMember>? TeamMembers  { get; set; } = null;
        //public bool IsManager { get; internal set; }
        //public ICollection<Team>? Teams { get; set; } = null;


        // Navigation property not needed for EF Core
        //[NotMapped]
        //public Team Team { get; set; }
    }
}

