namespace OrganizationETMCreation.Models
{
    public class Member
    {
        public int Id { get; set; } = int.MaxValue;
        public int memberid { get; set; } = int.MaxValue;    
        public string? Name { get; set; } = string.Empty;
        //public string? memberrole { get; set; } = string.Empty; 
        //public int Salary { get; set; } = int.MaxValue;
        //public DateTime JoiningDate { get; set; }
        //public int SalaryId { get; set; } = int.MaxValue;
        //public string? ReportsTo { get; set; } = string.Empty;
        //public int ReportsToId { get; set; } = int.MaxValue;
        //public int TotalHoursWorked { get; set; } = 0;
        //public Team? Team { get; set; } 
        // public Team? Teams { get; set; }
        //public int TotalWorkload { get; set; } = 0;
        //public  TeamManager? TeamManager { get; set; } 
        //public int? TeamManagerId  { get; set; } 

        public ICollection<TeamManager>? TeamManagers { get; set; } = null;
        public ICollection<TeamMember>? TeamMembers { get; set; } = null;
        //public object? TeamMemberships { get; internal set; } = null;
        //public ICollection<Member> Members  { get; set; } = new List<Member>();
    }
}
