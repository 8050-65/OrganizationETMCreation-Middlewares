using Mapster;
using OrganizationETMCreation.Dto;
using OrganizationETMCreation.Interface;
using OrganizationETMCreation.Models;
using Newtonsoft.Json.Linq;
using System.Linq;
using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Office2010.Excel;
using OrganizationETMCreation.Data.Repositories;

namespace OrganizationETMCreation.Services
{
    public class TeamService : ITeamServices
    {
        private readonly ITeamRepository _teamRepository;

        public int managerId { get; private set; }

        public TeamService(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public void AddTeam(TeamDto teamDto)
        {
            var team = teamDto.Adapt<Team>();
            _teamRepository.Add(team);
        }

        public void UpdateTeam(TeamDto teamDto)
        {
            var team = teamDto.Adapt<Team>();
            _teamRepository.Update(team);
        }

        public void DeleteTeam(int id)
        {
            _teamRepository.Delete(id);
        }

        public TeamDto GetTeamById(int id) 
        {
            var team = _teamRepository.GetById(id);
            return team.Adapt<TeamDto>();
        }

        public IEnumerable<TeamDto> GetAllTeams()
        {
            var teams = _teamRepository.GetAll();
            return teams.Adapt<IEnumerable<TeamDto>>();
        }

        public void AddTeamMember(TeamMemberDto teamMemberDto)
        {
            var teamMember = teamMemberDto.Adapt<TeamMember>();
            _teamRepository.AddTeamMember(teamMember);
        }

        public void UpdateTeamMember(TeamMemberDto teamMemberDto)
        {
            var teamMember = teamMemberDto.Adapt<TeamMember>();
            _teamRepository.UpdateTeamMember(teamMember);
        }

        public void DeleteTeamMember(int id)
        {
            _teamRepository.DeleteTeamMember(id);
        }

        public TeamMemberDto GetTeamMemberById(int id)
        {
            var teamMember = _teamRepository.GetTeamMemberById(id);
            return teamMember.Adapt<TeamMemberDto>();
        }

        public IEnumerable<TeamMemberDto> GetAllTeamMembers()
        {
            var teamMembers = _teamRepository.GetAllTeamMembers();
            return teamMembers.Adapt<IEnumerable<TeamMemberDto>>();
        }

        public void InitializeTeams()
        {
            var teams = new List<Team>
            {
                new Team { Name = "Development" },
                new Team { Name = "QA" },
                new Team { Name = "Product" },
                new Team { Name = "Marketing" },
                new Team { Name = "HR" }
            };

            foreach (var team in teams)
            {
                _teamRepository.Add(team);
            }
            return;
        }

        public EmployeeDto GetTeamManager(int teamId)
        {
            var teamManager = _teamRepository.GetTeamManager(managerId);  

            //var manager = _teamRepository.GetTeamManager(teamId); 
            if (teamManager != null)
            { 
                return teamManager.Adapt<EmployeeDto>();
            }
            return null;  
        }
        //public IEnumerable<TeamMemberDto> GetTeamMembers()
        //{
        //    List<TeamMember> teamMembers = _teamRepository.TeamMembers.();
        //    return teamMembers.Adapt<IEnumerable<TeamMemberDto>>();
        //}

        public List<EmployeeDto> GetTeamMembers()
        {
            var teamMembers = _teamRepository.GetAll();
            if (teamMembers == null)
            {
                return new List<EmployeeDto>(); // or throw exception/handle error
            }

            return teamMembers.Select(m => m.Adapt<EmployeeDto>()).ToList();
        }

        //public EmployeeDto GetTeamManager(int teamId)
        //{
        //    var manager = _teamRepository.GetTeamManager(teamId);
        //    return manager?.Adapt<EmployeeDto>();
        //}

        public void AddMemberToTeam(int teamId, int memberId)
        {
            // Check if memberId exists in employees
            var employee = _teamRepository.GetById(teamId);
            if (employee == null)
            {
                throw new ArgumentException("Invalid memberId");
            }

            // Add member to team
            var teammember = new TeamMember
            {
                //EmployeeId = memberId,
                TeamId = teamId
            };
            _teamRepository.Add(employee); 
        }


        public void RemoveMemberFromTeam(int teamId, int memberId)
        {
            var teamMember = _teamRepository.GetByTeamAndMemberId(teamId, memberId);
            if (teamMember != null)
            {
                _teamRepository.Delete(teamMember);
            }
        }


        public void ReassignMember(int memberId, int oldTeamId, int teamId) 
        {
            var teamMember = _teamRepository.GetByTeamAndMemberId(oldTeamId, memberId);
            if (teamMember != null)
            {
                //teamMember = teamId; 
                _teamRepository.Update(teamMember);
            }
        } 


        public void ChangeMemberRole(int memberId, string newRole)
        {
            var employee = _teamRepository.GetById(memberId);
            if (employee != null)
            {
                employee.memberrole = newRole; 
                _teamRepository.Update(employee);
            }
        }


        public int GetTotalTeamEfforts(int teamId)
        {
            var teamMembers = _teamRepository.GetAll();
            return teamMembers.Sum(m => m.WorkingHours);
        }

        public void AddMember(TeamDto teamDto)
        {
            if (teamDto.EmployeeId == 0)
            {
                throw new ArgumentException("EmployeeId must be provided");
            } 
            var employee = _teamRepository.GetById(teamDto.EmployeeId);
            if (employee == null)
            {
                throw new ArgumentException("Invalid EmployeeId");
            }
            var teamMember = new TeamMember
            { 
                EmployeeId = teamDto.EmployeeId,
                TeamId = teamDto.Id  
            };

            _teamRepository.AddTeamMember(teamMember);
        }


        //public void AddMemberToTeam(int teamId, int memberId)
        //{
        //    throw new NotImplementedException();
        //}

        //public void AddMember(int teamId, int memberId)
        //{
        //    throw new NotImplementedException();
        //}

        //public void AddMember(int memberid) 
        //{ 
        //    var teamMember = _teamRepository.Adapt<TeamMember>();
        //    _teamRepository.AddTeamMember(teamMember);
        //}

        //public List<EmployeeDto> GetTeamMembers()
        //{
        //    throw new NotImplementedException();
        //}

        //public void AddMemberToTeam(int teamId)
        //{
        //    throw new NotImplementedException();
        //}


        //public List<EmployeeDto> GetTeamMembers(int teamId)
        //{
        //    throw new NotImplementedException();
        //}

        //public void AddMemberToTeam(int teamId, int memberId)
        //{
        //    throw new NotImplementedException();
        //}

        //public void RemoveMemberFromTeam(int teamId, int memberId)
        //{
        //    throw new NotImplementedException();
        //}

        //public void ReassignMember(int memberId, int oldTeamId, int newTeamId)
        //{
        //    throw new NotImplementedException();
        //}

        //public int GetTotalTeamEfforts(int teamId)
        //{
        //    throw new NotImplementedException();
        //}


    }
}

