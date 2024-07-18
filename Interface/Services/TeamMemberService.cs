using System.Collections.Generic;
using Mapster;
using OrganizationETMCreation.Dto;
using OrganizationETMCreation.Interface;
using OrganizationETMCreation.Models;

namespace OrganizationETMCreation.Services
{
    public class TeamMemberService : ITeamMemberServices 
    {
        private readonly ITeamMemberRepository _repository;

        public TeamMemberService(ITeamMemberRepository repository)
        {
            _repository = repository;
        }

        public void AddTeamMember(TeamMemberDto memberDto)
        {
            var member = memberDto.Adapt<TeamMember>();
            _repository.Add(member);
        }

        public void UpdateTeamMember(TeamMemberDto memberDto)
        {
            var member = memberDto.Adapt<TeamMember>();
            _repository.Update(member);
        }

        public void DeleteTeamMember(int id)
        {
            _repository.Delete(id);
        }

        public TeamMemberDto GetTeamMemberById(int id)
        {
            var member = _repository.GetById(id);
            return member.Adapt<TeamMemberDto>();
        }

        public IEnumerable<TeamMemberDto> GetAllTeamMembers()
        {
            var members = _repository.GetAll();
            return members.Adapt<IEnumerable<TeamMemberDto>>();
        }
    }
}

