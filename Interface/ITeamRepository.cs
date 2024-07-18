using Microsoft.AspNetCore.Mvc;
using OrganizationETMCreation.Dto;
using OrganizationETMCreation.Models;

namespace OrganizationETMCreation.Interface
{
    public interface ITeamRepository
    {
        //object TeamMembers { get; set; }

        void Add(Team team);
        void Update(Team team);
        void Delete(int id);
        IEnumerable<Team> GetAll();
        Team? GetById(int id);
        //Team GetId(int Id);
        // AddMember(TeamMember teamMember);
        //void RemoveMember(TeamMember teamMember);
       // TeamMember GetMemberById(int id);
        void AddTeamMember(TeamMember teamMember);
        void UpdateTeamMember(TeamMember teamMember);
        void DeleteTeamMember(int id);
        object? GetTeamMemberById(int id);
        object GetAllTeamMembers();
        //Team GetTeamById(int id);
        //object GetAllTeams(); 
        TeamManager? GetTeamManager(int Id);
        //TeamManager GetManager(int Id); 
        //Team GetTeamMembers(int Teamid);      
        //object UpdateTeamManager(TeamManager teamManager);
        //object  GetByTeamAndMemberId (int teamId, int memberId);
        TeamMember? GetTeamMemberById(int teamId, int memberId);

        // Other method declarations

        TeamMember? GetByTeamAndMemberId(int teamId, int memberId);
      


        void InitializeTeams();
        //List<EmployeeDto> GetTeamMembers(int teamId);
        void AddMemberToTeam(int teamId, int memberId);
        void RemoveMemberFromTeam(int teamId, int memberId);
        void ReassignMember(int memberId, int oldTeamId, int newTeamId);
        void ChangeMemberRole(int memberId, string newRole);
        int GetTotalTeamEfforts(int teamId);
        void Delete(object teamMember);
        void Update(object teamMember);
        void Delete(TeamMember teamMember);
        void Update(TeamMember teamMember);
        //TeamMember GetTeamMemberById(int teamId, int memberId);
        TeamMember? TeamMemberById(int teamid, int memberId);  
    } 

}
