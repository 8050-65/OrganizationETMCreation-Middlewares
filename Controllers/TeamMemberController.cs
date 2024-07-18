using Microsoft.AspNetCore.Mvc;
using OrganizationETMCreation.Dto;
using OrganizationETMCreation.Interface;

namespace OrganizationETMCreation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamMemberController : ControllerBase
    {
        private readonly ITeamMemberServices _service;

        public TeamMemberController(ITeamMemberServices service)
        {
            _service = service;
        }

        [HttpGet("GetAllTeamMembers")]
        public ActionResult<IEnumerable<TeamMemberDto>> GetAllTeamMembers()
        {
            var members = _service.GetAllTeamMembers();
            return Ok(members);
        }

        [HttpGet("GetTeamMemberById/{id}")]
        public ActionResult<TeamMemberDto> GetTeamMemberById(int id)
        {
            var member = _service.GetTeamMemberById(id);
            if (member == null)
            {
                return NotFound();
            }
            return Ok(member);
        }

        [HttpPost("AddTeamMember")]
        public ActionResult AddTeamMember([FromBody] TeamMemberDto memberDto)
        {
            _service.AddTeamMember(memberDto);
            return Ok();
        }

        [HttpPut("UpdateTeamMember")]
        public ActionResult UpdateTeamMember([FromBody] TeamMemberDto memberDto)
        {
            _service.UpdateTeamMember(memberDto);
            return Ok();
        }


        [HttpDelete("DeleteTeamMember/{id}")]
        public ActionResult DeleteTeamMember(int id)
        {
            _service.DeleteTeamMember(id);
            return NoContent();
        }
    }
}
