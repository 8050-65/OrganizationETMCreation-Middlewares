using System.Collections.Generic;
using OrganizationETMCreation.Dto;

namespace OrganizationETMCreation.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<TeamMember> TeamMembers { get; set; } = new List<TeamMember>();
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        //public int EmployeeId { get; set; } 
        public int EmployeeId { get; set; }  
        public string? memberrole { get; internal set; }
        public int WorkingHours { get; internal set; }
        //public int TeamId { get; set; }
        //public Employee? employeeId { get; set; }
        //public Employee? Employee { get; set; }
        //public TeamMember? TeamMember { get; set; }
        //public String? Members { get; set; }
        //public Member? Member { get; set; }
        //public int? MemberId { get; set; }
        //public int ManagerId { get; set; }
        //public Member? memberId { get; set; }
        //public string? MemberName { get; set; }
        //public string? Role { get; set; } = string.Empty;
        //public int Salary { get; set; } = int.MaxValue;
        //public DateTime JoiningDate { get; set; }
        //public int SalaryId { get; set; } = int.MaxValue;
        //public string? ReportsTo { get; set; } = string.Empty;
        //public int ReportsToId { get; set; } = int.MaxValue;
        //public int TotalHoursWorked { get; set; } = 0;
        //public int TotalWorkload { get; set; } = 0;
        //public Team Teams { get; set; } = null;
        //public ICollection<TeamManager>? TeamManagers { get; set; } = null;
        //public TeamManager? TeamManager { get; set; }
        //public Manager? Manager { get; set; }

        //public object? TeamMemberships { get; internal set; } = null;
    }
}

