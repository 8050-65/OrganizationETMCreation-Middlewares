using OrganizationETMCreation.Mapper;

namespace OrganizationETMCreation.Dto
{
    public class TeamDto
    {
        //public ManagerMapper? Manager { get; set; }
        //public string? manager { get; set; }
        public int Id { get; set; }
        public string? Name { get; set; }
        public int EmployeeId { get; set; }  
        public string? memberrole { get; set; }
        public int WorkingHours { get; set; }
    }
}
