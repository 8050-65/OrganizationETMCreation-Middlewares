using OrganizationETMCreation.Dto;

namespace OrganizationETMCreation.Services
{
    public interface IEmployeeServices 
    {
        void AddEmployee(EmployeeDto employeeDto);
        void UpdateEmployee(EmployeeDto employeeDto);
        void DeleteEmployee(int id);
        EmployeeDto GetEmployeeById(int id);
        IEnumerable<EmployeeDto> GetAllEmployees();
        decimal CalculateEmployeeSalary(int employeeId, int leaveDays);

    }
}

