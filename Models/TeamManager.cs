namespace OrganizationETMCreation.Models
{
    public class TeamManager
    {
        public int id { get; set; } = int.MaxValue;
        public string? name { get; set; } = string.Empty;
        //public object Members { get; internal set; }
        // public decimal Salary { get; set; }
        //public int? memberId  { get; set; }
        //public string? Title { get; set; } = string.Empty;
        //public string? Address { get; set; } = string.Empty;
        //public string? City { get; set; } = string.Empty;
        //public int ManagerId { get; set; } = int.MaxValue;
        ////public Team? Team { get; set; } = null;
        ////public Team? Teams { get; set; } = null;
        //public int TotalHoursWorked { get; set; } = 0;
        //public int TotalWorkload { get; set; } = 0;
        public ICollection<TeamManager>? TeamManagers { get; set; }
        //public ICollection<Manager>? Managers { get; set; }
        //public TeamMember? TeamMembers { get; set; }
        //public Employee? Employees { get; set; } 
        //public int TeamId { get; internal set; }
    }
}
