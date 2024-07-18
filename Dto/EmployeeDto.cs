using OrganizationETMCreation.Models;

namespace OrganizationETMCreation.Dto
{
    public class EmployeeDto
    {
        public int Id { get; set; } 
        public string? memberrole { get; set; }
        //public string? role { get; set; } 
        public string? Name { get; set; }
        public int? Age { get; set; }
        public int? Salary  { get; set; }
        public DateTime? JoiningDate { get; set; }
        //public int EmployeeId { get; set; }  
        //public int employeeid { get; set; }
        //public int TeamId { get; set; } 
        //public Team? Team { get; set; }
        public string? ReportsTo { get; set; } = string.Empty;
        //public int TotalHoursWorked { get; set; }
        //public int TotalWorkload { get; set; }
    }

}
