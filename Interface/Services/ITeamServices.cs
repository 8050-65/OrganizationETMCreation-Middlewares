using OrganizationETMCreation.Dto;

namespace OrganizationETMCreation.Services
{
    public interface ITeamServices 
    {
        void AddTeam(TeamDto teamDto);
        void UpdateTeam(TeamDto teamDto);
        void DeleteTeam(int id);
        TeamDto GetTeamById(int id);
        IEnumerable<TeamDto> GetAllTeams();
        void AddTeamMember(TeamMemberDto teamMemberDto); 
        void UpdateTeamMember(TeamMemberDto teamMemberDto);
        void DeleteTeamMember(int id);
        TeamMemberDto GetTeamMemberById(int id);
        IEnumerable<TeamMemberDto> GetAllTeamMembers();
        void InitializeTeams();
        EmployeeDto GetTeamManager(int teamId);

        List<EmployeeDto> GetTeamMembers(); 
        void AddMember(TeamDto teamDto); 
        void AddMemberToTeam(int teamId, int memberId);
        //void AddMember(int teamId, int memberId);
        // void AddEmployee (int  id, EmployeeDto employeeDto);
        //void AddMember(int memberid);  
        void RemoveMemberFromTeam(int teamId, int memberId);
        void ReassignMember(int memberId, int oldTeamId, int newTeamId);
        void ChangeMemberRole(int memberId, string newRole);
        int GetTotalTeamEfforts(int teamId);
        //void InitializeTeams();
        //EmployeeDto GetTeamManager(int teamId);
        //List<EmployeeDto> GetTeamMembers(int teamId);
        //void AddMemberToTeam(int teamId, int memberId);
        //void RemoveMemberFromTeam(int teamId, int memberId);
        //void ReassignMember(int memberId, int oldTeamId, int newTeamId);
        //void ChangeMemberRole(int memberId, string newRole);
        //int GetTotalTeamEfforts(int teamId);
    }
}
