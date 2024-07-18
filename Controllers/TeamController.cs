using Microsoft.AspNetCore.Mvc;
using OrganizationETMCreation.Dto;
using OrganizationETMCreation.Models;
using OrganizationETMCreation.Services;

namespace OrganizationETMCreation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamController : ControllerBase
    {
        private readonly ITeamServices _teamServices; 

        public TeamController(ITeamServices teamService)
        {
            _teamServices = teamService;
        }

        //[HttpGet("initialize")]
        //public IActionResult InitializeTeams()
        //{
        //    _teamServices.InitializeTeams();
        //    return Ok("Teams initialized successfully");
        //}

        [HttpGet("initialize")]
        public IActionResult GetAllTeams()
        {
            var teams = _teamServices.GetAllTeams();
            return Ok(teams);
        }

        //[HttpGet("teammanager/{id}")]
        //public IActionResult GetTeamManager(int id)
        //{

        //    var manager = _teamServices.GetTeamManager(id);
        //    if (manager == null) 
        //    {
        //        return NotFound();
        //    }
        //    return Ok(manager);
        //}
        [HttpGet("GetTeamManager/{id}")] 
        public IActionResult GetTeamById(int id)
        {
            var team = _teamServices.GetTeamById(id);
            return Ok(team);
        }

        [HttpGet("{teamId}/GetTotalTeamEfforts")]
        public IActionResult GetTotalTeamEfforts(int teamId)
        {
            var totalEfforts = _teamServices.GetTotalTeamEfforts(teamId);
            return Ok(totalEfforts);
        }

        [HttpGet("/GetTeamMembers")]
        public IActionResult GetTeamMembers()
        {
            var members = _teamServices.GetTeamMembers();
            return Ok(members);
        }

        [HttpPost("{teamId}/AddMember/{memberId}")]
        public IActionResult AddMemberToTeam(int teamId, int memberId)
        {
            _teamServices.AddMemberToTeam(teamId,memberId);
            return Ok();
        } 

        [HttpPost("{teamId}/AddMemberToTeam/{memberId}")]
        public IActionResult AddMember(TeamDto teamDto) 
        {
            var addmember = _teamServices; 
            _teamServices.AddMember(teamDto);
            return Ok(addmember);
        }


        [HttpPut("{teamId}/ReassignMember/{memberId}")]
        public IActionResult ReassignMember(int memberId, int oldTeamId, int newTeamId)
        {
            _teamServices.ReassignMember(memberId, oldTeamId, newTeamId);
            return Ok();
        }

        [HttpPut("{teamId}/ChangeMemberRole/{memberId}/")]
        public IActionResult ChangeMemberRole(int memberId, string newRole)
        {
            _teamServices.ChangeMemberRole(memberId, newRole);
            return Ok();
        }

        [HttpDelete("{teamId}/RemoveMemberFromTeam/{memberId}")]
        public IActionResult RemoveMemberFromTeam(int memberId, int teamId)
        {
            _teamServices.RemoveMemberFromTeam(memberId, teamId);
            return Ok();
        }
       
    }

}
