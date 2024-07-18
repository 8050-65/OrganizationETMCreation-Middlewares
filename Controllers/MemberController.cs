//using Mapster;
//using Microsoft.AspNetCore.Mvc;
//using OrganizationETMCreation.Dto;
//using OrganizationETMCreation.Interface;
//using OrganizationETMCreation.Models;
//using OrganizationETMCreation.Services;
////using OrganizationETMCreation.Dtos;


//namespace OrganizationETMCreation.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class MemberController : ControllerBase
//    {
//        private readonly IMemberService _memberService;

//        public MemberController(IMemberService memberService)
//        {
//            _memberService = memberService;
//        }

//        [HttpPost]
//        public ActionResult AddMember([FromBody] TeamMemberDto memberDto)
//        {
//            var member = memberDto.Adapt<TeamMember>();
//            _memberService.AddMember(member);
//            return Ok();
//        }
//        //[ApiController]
//        //[Route("api/[controller]")]
//        //public class MemberController : ControllerBase
//        //{
//        //    private readonly IMemberService _memberService;

//        //    public MemberController(IMemberService memberService)
//        //    {
//        //        _memberService = memberService;
//        //    }

//        [HttpPost]
//        public ActionResult AddMember([FromBody] TeamMemberDto memberDto)
//        {
//            var member = memberDto.Adapt<TeamMember>();
//            _memberService.AddMember(member);
//            return Ok();
//        }



//        [HttpGet]
//        public ActionResult<IEnumerable<TeamMemberDto>> GetAllTeamMembers()
//        {
//            var teamMembers = _teamService.GetAllTeamMembers();
//            return Ok(teamMembers);
//        }

//        [HttpGet("{id}")]
//        public ActionResult<TeamMemberDto> GetTeamMemberById(int id)
//        {
//            var teamMember = _teamService.GetTeamMemberById(id);
//            if (teamMember == null)
//            {
//                return NotFound();
//            }
//            return Ok(teamMember);
//        }

//        [HttpPost]
//        public ActionResult AddTeamMember([FromBody] MemberDto MemberDto)
//        {
//            _teamService.AddTeamMember(MemberDto);
//            return CreatedAtAction(nameof(GetTeamMemberById), new { id = TeamMemberDto.Id }, TeamMemberDto);
//        }

//        [HttpPost]
//        public ActionResult AddMember([FromBody] TeamMemberDto memberDto)
//        {
//            var member = memberDto.Adapt<TeamMember>();
//            _memberService.AddMember(member);
//            return Ok();
//        }


//        // Example usage of TeamMemberDto in MemberController
//        //[HttpGet("{id}")]
//        //public ActionResult<TeamMemberDto> GetMember(int id)
//        //{
//        //    var member = _memberService.GetMemberById(id);
//        //    if (member == null) return NotFound();
//        //    var memberDto = member.Adapt<TeamMemberDto>();
//        //    return Ok(memberDto);
//        //}


//        [HttpDelete("{id}")]
//        public ActionResult DeleteTeamMember(int id)
//        {
//            _teamService.DeleteTeamMember(id);
//            return NoContent();
//        }
//    }
//}
