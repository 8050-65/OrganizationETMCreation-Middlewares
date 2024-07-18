//using Mapster;
//using OrganizationETMCreation.Data.Repositories;
//using OrganizationETMCreation.Dto;
//using OrganizationETMCreation.DTOs;
//using OrganizationETMCreation.Interface;
//using OrganizationETMCreation.Models;
//using OrganizationETMCreation.Services;
//using System.Collections.Generic;

//namespace OrganizationETMCreation.Service 
//{
//    public class TeamService : ITeamServices 
//    {
//        private readonly ITeamRepository _teamRepository;

//        public TeamService(ITeamRepository teamRepository)
//        {
//            _teamRepository = teamRepository;
//        }

//        public void AddTeam(TeamDTO teamDto)
//        {
//            var team = teamDto.Adapt<Team>();
//            _teamRepository.Add(team);
//        }

//        public void UpdateTeam(TeamDTO teamDto)
//        {
//            var team = teamDto.Adapt<Team>();
//            _teamRepository.Update(team);
//        }

//        public void DeleteTeam(int id)
//        {
//            _teamRepository.Delete(id);
//        }

//        public TeamDTO GetTeamById(int id)
//        {
//            var team = _teamRepository.GetById(id);
//            return team.Adapt<TeamDTO>();
//        }

//        public IEnumerable<TeamDTO> GetAllTeams()
//        {
//            var teams = _teamRepository.GetAll();
//            return teams.Adapt<IEnumerable<TeamDTO>>();
//        }

//        public void AddTeamMember(TeamMemberDTO teamMemberDto)
//        {
//            var teamMember = teamMemberDto.Adapt<TeamMember>();
//            _teamRepository.AddTeamMember(teamMember);
//        }

//        public void UpdateTeamMember(TeamMemberDTO teamMemberDto)
//        {
//            var teamMember = teamMemberDto.Adapt<TeamMember>();
//            _teamRepository.UpdateTeamMember(teamMember);
//        }

//        public void DeleteTeamMember(int id)
//        {
//            _teamRepository.DeleteTeamMember(id);
//        }

//        public TeamMemberDTO GetTeamMemberById(int id)
//        {
//            var teamMember = _teamRepository.GetTeamMemberById(id);
//            return teamMember.Adapt<TeamMemberDTO>();
//        }

//        public IEnumerable<TeamMemberDTO> GetAllTeamMembers()
//        {
//            var teamMembers = _teamRepository.GetAllTeamMembers();
//            return teamMembers.Adapt<IEnumerable<TeamMemberDTO>>();
//        }

//        public void InitializeTeams()
//        {
//            throw new NotImplementedException();
//        }

//        TeamDto ITeamService.GetTeamById(int id)
//        {
//            throw new NotImplementedException();
//        }

//        IEnumerable<TeamDto> ITeamService.GetAllTeams()
//        {
//            throw new NotImplementedException();
//        }

//        public EmployeeDto GetTeamManager(int teamId)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<EmployeeDto> GetTeamMembers(int teamId)
//        {
//            throw new NotImplementedException();
//        }

//        public void AddMemberToTeam(int memberId, int teamId)
//        {
//            throw new NotImplementedException();
//        }

//        public void RemoveMemberFromTeam(int memberId, int teamId)
//        {
//            throw new NotImplementedException();
//        }

//        public void ReassignMember(int memberId, int oldTeamId, int newTeamId)
//        {
//            throw new NotImplementedException();
//        }

//        public void ChangeMemberRole(int memberId, string newRole)
//        {
//            throw new NotImplementedException();
//        }

//        public int GetTotalTeamEfforts(int teamId)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}

