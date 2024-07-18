using Mapster;
using OrganizationETMCreation.Dto;
using OrganizationETMCreation.Interface;
using OrganizationETMCreation.Models;

namespace OrganizationETMCreation.Services
{
    public class EmployeeService : IEmployeeServices
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public void AddEmployee(EmployeeDto employeeDto)
        {
            var employee = employeeDto.Adapt<Employee>();

            var existingEmployee = _employeeRepository.GetWithId(employee.Id);  //GetById
            if (existingEmployee != null)
            {
                throw new Exception("Employee with the given ID already exists.");
            }

            _employeeRepository.Add(employee);
        }
        //public void AddEmployee(EmployeeDto employeeDto)
        //{
        //    var employee = employeeDto.Adapt<Employee>();

        //    if (_employeeRepository.GetById(employee.Id) != null)
        //    {
        //        throw new Exception("Employee with the given ID already exists.");
        //    }

        //    _employeeRepository.Add(employee);
        //}

        public void UpdateEmployee(EmployeeDto employeeDto)
        {
            var employee = employeeDto.Adapt<Employee>();

            if (_employeeRepository.GetById(employee.Id) == null)
            {
                throw new Exception("Employee with the given ID does not exist.");
            }
            _employeeRepository.Update(employee);
        }

        public void DeleteEmployee(int id)
        {
            if (_employeeRepository.GetById(id) == null)
            {
                throw new Exception("Employee with the given ID does not exist.");
            }

            _employeeRepository.Delete(id);
        }

        public EmployeeDto GetEmployeeById(int id)
        {
            var employee = _employeeRepository.GetById(id);

            if (employee == null)
            {
                throw new Exception("Employee with the given ID does not exist.");
            }

            return employee.Adapt<EmployeeDto>();
        }

        public IEnumerable<EmployeeDto> GetAllEmployees()
        {
            var employees = _employeeRepository.GetAll();
            return employees.Adapt<IEnumerable<EmployeeDto>>();
        }

        public decimal CalculateEmployeeSalary(int employeeId, int leaveDays)
        {
            var employee = _employeeRepository.GetById(employeeId);

            if (employee == null)
            {
                throw new ArgumentException($"Employee with ID {employeeId} not found.");
            }

            var dailySalary = employee.Salary / 30;
            var salary = employee.Salary - (dailySalary * leaveDays);
            return salary;
        }
    }
}

        //public void AddEmployee(EmployeeDto employeeDto)
        //{

//    var employee = employeeDto.Adapt<Employee>();
//    // Ensure that TeamId is set correctly
//    try
//    {
//        var t = _employeeRepository.GetById(employee.Id);
//        if (_employeeRepository.GetById(employee.Id) != null) 
//        {
//            throw new Exception("Invalid TeamId");
//        }
//        _employeeRepository.Add(employee);
//    }
//    catch (Exception ex) 
//    {

//    }
//}

//public void UpdateEmployee(EmployeeDto employeeDto) 
//{
//    var employee = employeeDto.Adapt<Employee>();
//    // Ensure that TeamId is set correctly 
//    if (_employeeRepository.GetById(employee.Id) == null)
//    {
//        throw new Exception("Invalid TeamId");
//    }
//    _employeeRepository.Update(employee);
//}

//public void DeleteEmployee(int id)
//{
//    _employeeRepository.Delete(id);
//}

//public EmployeeDto GetEmployeeById(int id)
//{
//    var employee = _employeeRepository.GetById(id);
//    return employee.Adapt<EmployeeDto>();
//}

//public IEnumerable<EmployeeDto> GetAllEmployees()
//{
//    var employees = _employeeRepository.GetAll();
//    return employees.Adapt<IEnumerable<EmployeeDto>>();
//}

//public decimal CalculateEmployeeSalary(int employeeId, int leaveDays)
//{
//    var employee = _employeeRepository.GetById(employeeId);
//    if (employee == null)
//    {
//        throw new ArgumentException($"Employee with ID {employeeId} not found.");
//    }

//    var dailySalary = employee.Salary / 30;
//    var salary = employee.Salary - (dailySalary * leaveDays);
//    return salary;


//public class EmployeeService : IEmployeeServices
//{
//    private readonly IEmployeeRepository _employeeRepository;

//    public EmployeeService(IEmployeeRepository employeeRepository)
//    {
//        _employeeRepository = employeeRepository;
//    }

//    public void AddEmployee(EmployeeDto employeeDto)
//    {
//        var employee = employeeDto.Adapt<Employee>();
//        _employeeRepository.Add(employee);
//    }

//    public void UpdateEmployee(EmployeeDto employeeDto)
//    {
//        var employee = employeeDto.Adapt<Employee>();
//        _employeeRepository.Update(employee);
//    }

//    public void DeleteEmployee(int id)
//    {
//        _employeeRepository.Delete(id);
//    }

//    public EmployeeDto GetEmployeeById(int id)
//    {
//        var employee = _employeeRepository.GetById(id);
//        return employee.Adapt<EmployeeDto>();
//    }

//    public IEnumerable<EmployeeDto> GetAllEmployees()
//    {
//        var employees = _employeeRepository.GetAll();
//        return employees.Adapt<IEnumerable<EmployeeDto>>();
//    }

//    public decimal CalculateEmployeeSalary(int employeeId, int leaveDays)
//    {
//        var employee = _employeeRepository.GetById(employeeId);
//        if (employee == null)
//        {
//            return 0;
//        }

//        var dailySalary = employee.Salary / 30;
//        var salary = employee.Salary - (dailySalary * leaveDays);
//        return salary;
//    }

//    //public void AddEmployee(EmployeeDto employeeDto)
//    //{
//    //    throw new NotImplementedException();
//    //}

//    //public void UpdateEmployee(EmployeeDto employeeDto)
//    //{
//    //    throw new NotImplementedException();
//    //}

//    //EmployeeDto IEmployeeServices.GetEmployeeById(int id)
//    //{
//    //    return _
//    //}

//    //IEnumerable<EmployeeDto> IEmployeeServices.GetAllEmployees()
//    //{
//    //    throw new NotImplementedException();
//    //}
//}

