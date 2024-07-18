using System.Collections.Generic;
using OrganizationETMCreation.Models;

namespace OrganizationETMCreation.Interface
{
    public interface ITeamMemberRepository
    {
        void Add(TeamMember member);
        void Update(TeamMember member);
        void Delete(int id);
        TeamMember GetById(int id); 
        IEnumerable<TeamMember> GetAll();
    }
}
