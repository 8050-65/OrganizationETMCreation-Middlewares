using Microsoft.AspNetCore.Mvc;
using OrganizationETMCreation.Dto;
using OrganizationETMCreation.Services;

namespace OrganizationETMCreation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices _employeeService;

        public EmployeeController(IEmployeeServices employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("GetAllEmployees")]
        public IActionResult GetAllEmployees()
        {
            var employees = _employeeService.GetAllEmployees();
            return Ok(employees);
        }

        [HttpGet("{id}GetEmployeeById")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);
            return Ok(employee);
        }

        [HttpGet("{id}/CalculateEmployeeSalary")]
        public IActionResult CalculateEmployeeSalary(int id, int leaves)
        {
            var salary = _employeeService.CalculateEmployeeSalary(id, leaves);
            return Ok(salary);
        }

        [HttpPost("AddEmployee")]
        public IActionResult AddEmployee(EmployeeDto employeeDto)
        {
            try
            {
                _employeeService.AddEmployee(employeeDto);
                return Ok("Employee added successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } 

        //[HttpPost("AddEmployee")]
        //public IActionResult AddEmployee(EmployeeDto employee)
        //{
        //    var employeeService = _employeeService;
        //    _employeeService.AddEmployee(employee); 
        //    return Ok(employeeService);  
        //}

        [HttpPut("UpdateEmployee")]
        public IActionResult UpdateEmployee(EmployeeDto employee)
        {
            var employeeService = _employeeService; 
            _employeeService.UpdateEmployee(employee);
            return Ok();
        }

        [HttpDelete("DeleteEmployee")]
        public IActionResult DeleteEmployee(int id)
        {
            var employeeService = _employeeService;
            _employeeService.DeleteEmployee(id);
            return Ok(employeeService);
        }

        
    }

}
