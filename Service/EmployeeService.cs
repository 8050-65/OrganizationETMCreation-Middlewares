//using Mapster;
//using OrganizationETMCreation.Data.Repositories;
//using OrganizationETMCreation.Dto;
//using OrganizationETMCreation.DTOs;
//using OrganizationETMCreation.Interface;
//using OrganizationETMCreation.Models;
//using System.Collections.Generic;
//using OrganizationETMCreation.Services;

//namespace OrganizationETMCreation.Services
//{
//    public class EmployeeService : IEmployeeServices 
//    {
//        private readonly IEmployeeRepository _employeeRepository;

//        public EmployeeService(IEmployeeRepository employeeRepository)
//        {
//            _employeeRepository = employeeRepository;
//        }

//        public void AddEmployee(EmployeeDTO employeeDto)
//        {
//            var employee = employeeDto.Adapt<Employee>();
//            _employeeRepository.Add(employee);
//        }

//        public void UpdateEmployee(EmployeeDTO employeeDto)
//        {
//            var employee = employeeDto.Adapt<Employee>();
//            _employeeRepository.Update(employee);
//        }

//        public void DeleteEmployee(int id)
//        {
//            _employeeRepository.Delete(id);
//        }

//        public EmployeeDTO GetEmployeeById(int id)
//        {
//            var employee = _employeeRepository.GetById(id);
//            return employee.Adapt<EmployeeDTO>();
//        }

//        public IEnumerable<EmployeeDTO> GetAllEmployees()
//        {
//            var employees = _employeeRepository.GetAll();
//            return employees.Adapt<IEnumerable<EmployeeDTO>>();
//        }

//        public decimal CalculateEmployeeSalary(int employeeId, int leaveDays)
//        {
//            var employee = _employeeRepository.GetById(employeeId);
//            if (employee == null)
//            {
//                return 0;
//            }

//            var dailySalary = employee.Salary / 30;
//            var salary = employee.Salary - (dailySalary * leaveDays);
//            return salary;
//        }

//        public void AddEmployee(EmployeeDto employee)
//        {
//            throw new NotImplementedException();
//        }

//        public void UpdateEmployee(EmployeeDto employee)
//        {
//            throw new NotImplementedException();
//        }

//        IEnumerable<EmployeeDto> IEmployeeService.GetAllEmployees()
//        {
//            throw new NotImplementedException();
//        }

//        EmployeeDto IEmployeeService.GetEmployeeById(int id)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
//using Mapster;
//using Microsoft.AspNetCore.Mvc;
//using OrganizationETMCreation.Dto;
//using OrganizationETMCreation.Interface;
//using OrganizationETMCreation.Models;
//using OrganizationETMCreation.Services;
//using System.Collections.Generic;

//namespace OrganizationETMCreation.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class MemberController : ControllerBase
//    {
//        private readonly IMemberService _memberService;
//        private readonly ITeamService _teamService;

//        public MemberController(IMemberService memberService, ITeamService teamService)
//        {
//            _memberService = memberService;
//            _teamService = teamService;
//        }

//        [HttpPost("add")]
//        public ActionResult AddMember([FromBody] TeamMemberDto memberDto)
//        {
//            var member = memberDto.Adapt<TeamMember>();
//            _memberService.AddMember(member);
//            return Ok();
//        }

//        [HttpGet("all")]
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

//        [HttpPost("add-team-member")]
//        public ActionResult AddTeamMember([FromBody] TeamMemberDto teamMemberDto)
//        {
//            var member = teamMemberDto.Adapt<TeamMember>();
//            _teamService.AddTeamMember(member);
//            return CreatedAtAction(nameof(GetTeamMemberById), new { id = member.Id }, member);
//        }

//        [HttpDelete("{id}")]
//        public ActionResult DeleteTeamMember(int id)
//        {
//            _teamService.DeleteTeamMember(id);
//            return NoContent();
//        }
//    }
//}










//using OrganizationETMCreation.Models;
//using OrganizationETMCreation.Interface;
//using OrganizationETMCreation.Dto;

//namespace OrganizationETMCreation.Service 
//{
//    public class EmployeeService : IEmployeeService
//    {
//        private readonly IEmployeeRepository _employeeRepository;

//        public EmployeeService(IEmployeeRepository employeeRepository)
//        {
//            _employeeRepository = employeeRepository;
//        }

//        public void AddEmployee(EmployeeDto employee)
//        {
//            var newEmployee = new Employee
//            {
//                Name = employee.Name,
//                Salary = employee.Salary,
//                Age = employee.Age,
//                JoiningDate = employee.JoiningDate,
//                TotalHoursWorked = employee.TotalHoursWorked,
//                TotalWorkload = employee.TotalWorkload
//            };

//            _employeeRepository.Add(newEmployee);
//        }

//        public void UpdateEmployee(EmployeeDto employee)
//        {
//            var existingEmployee = _employeeRepository.GetById(employee.Id);
//            if (existingEmployee != null)
//            {
//                existingEmployee.Name = employee.Name;
//                existingEmployee.Salary = employee.Salary;
//                existingEmployee.Age = employee.Age;
//                existingEmployee.JoiningDate = employee.JoiningDate;
//                existingEmployee.TotalHoursWorked = employee.TotalHoursWorked;
//                existingEmployee.TotalWorkload = employee.TotalWorkload;

//                _employeeRepository.Update(existingEmployee);
//            }
//        }

//        public void DeleteEmployee(int id)
//        {
//            _employeeRepository.Delete(id);
//        }

//        public IEnumerable<EmployeeDto> GetAllEmployees()
//        {
//            var employees = _employeeRepository.GetAll()
//                .Select(e => new EmployeeDto
//                {
//                    Id = e.Id,
//                    Name = e.Name,
//                    Salary = e.Salary,
//                    Age = e.Age,
//                    JoiningDate = e.JoiningDate,
//                    TotalHoursWorked = e.TotalHoursWorked,
//                    TotalWorkload = e.TotalWorkload
//                })
//                .ToList();

//            return employees;
//        }

//        public EmployeeDto GetEmployeeById(int id)
//        {
//            var employee = _employeeRepository.GetById(id);
//            if (employee == null)
//                return null;

//            var employeeDTO = new EmployeeDto
//            {
//                Id = employee.Id,
//                Name = employee.Name,
//                Salary = employee.Salary,
//                Age = employee.Age,
//                JoiningDate = employee.JoiningDate,
//                TotalHoursWorked = employee.TotalHoursWorked,
//                TotalWorkload = employee.TotalWorkload
//            };

//            return employeeDTO;
//        }

//        public void AddEmployee(EmployeeDto employee)
//        {
//            throw new NotImplementedException();
//        }

//        public void UpdateEmployee(EmployeeDto employee)
//        {
//            throw new NotImplementedException();
//        }

//        IEnumerable<EmployeeDto> IEmployeeService.GetAllEmployees()
//        {
//            throw new NotImplementedException();
//        }

//        EmployeeDto IEmployeeService.GetEmployeeById(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public decimal CalculateEmployeeSalary(int id, int leaves)
//        {
//            throw new NotImplementedException();
//        }

//        public decimal CalculateEmployeeSalary(int employeeId, int leaveDays)
//        {
//            var employee = _employeeRepository.GetById(employeeId);
//            if (employee == null)
//            {
//                return 0;
//            }

//            var dailySalary = employee.Salary / 30;
//            var salary = employee.Salary - (dailySalary * leaveDays);
//            return salary;
//        }
//    }
//}

