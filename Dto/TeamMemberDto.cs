using OrganizationETMCreation.Models;

namespace OrganizationETMCreation.Dto
{
    public class TeamMemberDto
    {
        public int memberid { get; set; }
        public int TeamId { get; set; }
        //public Team? Team { get; set; }
        public int EmployeeId { get; set; }
        //public Employee? Employee { get; set; }
        public string? Name { get; set; }
        //public string? ReportsTo { get; set; }
        //public int TotalHoursWorked { get; set; }
        //public int TotalWorkload { get; set; }
        //public int WorkingHours { get; set; }
        ////public string? role { get; set; } 
        public string? memberrole { get; set; }
        //public int Id { get; set; }
       // public int memberid { get; set; } 
        //public int TeamId { get; set; }
        public string? TeamName { get; set; } // Example of nested property mapping
        //public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; } // Example of nested property mapping
        /// <summary>
        //public int TeamId { get; set; }
        /// </summary>

        //public string? Name { get; set; }
        public string? ReportsTo { get; set; }
        //public int TotalHoursWorked { get; set; }
        public int TotalWorkload { get; set; }
        public int WorkingHours { get; set; }
        //public string? MemberRole { get; set; }
        //public string? role { get; set; }
        //public int Id { get; set; } 
        //public string? Name { get; set; }
        //public int? memberid { get; set; }
        //public int MemberId { get; set; }
        //public int TeamId { get; set; }
        //public string? TeamName { get; set; } // Assuming you want the name of the team
        ////public int EmployeeId { get; set; }
        ////public string? EmployeeName { get; set; }

        ////public int EmployeeId { get; set; }
        ////public int TeamId { get; set; }
        ////public string? ReportsTo { get; set; }
        ////public int TotalHoursWorked { get; set; }
        ////public int TotalWorkload { get; set; } = 0;
        ////// Ensure TeamMemberDto is properly defined
        ////// Add other properties as needed
        ////public string memberrole { get; set; } 
        //// Add other properties as needed}
    }
} 