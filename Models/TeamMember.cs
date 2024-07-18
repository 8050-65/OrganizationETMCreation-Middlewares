namespace OrganizationETMCreation.Models
{
    public class TeamMember
    {
        //public int Id { get; set; }
        public int memberid { get; set; }
        public int TeamId { get; set; }
        public Team? Team { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public string? Name { get; set; }
        public string? ReportsTo { get; set; }
        public int TotalHoursWorked { get; set; }
        public int TotalWorkload { get; set; }
        public int WorkingHours { get; set; }
        //public string? role { get; set; } 
        public string? memberrole { get; set; } 
        ////public int Id { get; set; } 
        //public int memberid { get; set; }
        ////public int? MemberId { get; internal set; }
        //public int EmployeeId { get; set; }
        //public int TeamId { get; set; }
        //public String? ReportsTo { get; set; }
        //public int TotalHoursWorked { get; set; }
        //public int TotalWorkload { get; set; } = 0;
        //public string? Name { get; set; }
        //public Team? Team { get; set; }
        //public string? memberrole { get; set; }
        ////public bool IsManager { get; internal set; }
        //public Employee Employee { get; internal set; }
        //public int WorkingHours { get; internal set; }
        //public int MemberId { get; set; } // Ensure this matches your database column type
        ////public int MemberId { get; set; }
        ////public int TeamId { get; set; }
        ////public int EmployeeId { get; set; }
        ////public string MemberRole { get; set; }
        ////public int WorkingHours { get; set; }
        ////public Team Team { get; set; }
        ////public Employee Employee { get; set; }
        //////public TeamMember?  teamMember { get; set;} 

    }
}

