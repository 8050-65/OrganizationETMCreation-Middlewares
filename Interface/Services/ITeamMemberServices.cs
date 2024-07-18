using System.Collections.Generic;
using OrganizationETMCreation.Dto;
using OrganizationETMCreation.Models;

namespace OrganizationETMCreation.Interface
{
    public interface ITeamMemberServices 
    {
        void AddTeamMember(TeamMemberDto memberDto);
        void UpdateTeamMember(TeamMemberDto memberDto);
        void DeleteTeamMember(int id);
        TeamMemberDto GetTeamMemberById(int id);
        IEnumerable<TeamMemberDto> GetAllTeamMembers();
    }
}

