using DocumentFormat.OpenXml.Wordprocessing;
using Mapster;
using OrganizationETMCreation.Interface;
using OrganizationETMCreation.Models;

namespace OrganizationETMCreation.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext _context;

        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Employee> GetAll()
        {
            try
            {
                return _context.Employees.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving all employees", ex);
            }
        }

        public Employee GetById(int id)
        {
            try
            {
                var employee = _context.Employees.Find(id);
                if (employee == null)
                {
                    throw new Exception("Employee not found");
                }
                return employee;  
            }
            catch (Exception ex) 
            {
                throw new Exception($"Error retrieving employee with ID {id}", ex);
            }
        }

        public Employee GetWithId(int id) 
        {
            try
            {
                var employee = _context.Employees.Find(id);
                return employee;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving employee with ID {id}", ex);
            }
        }

        public void Add(Employee employee)
        {
            try
            {
                _context.Employees.Add(employee);
                _context.SaveChanges(); 
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding employee", ex);
            }
        }

        //public void Add(Employee employee)
        //{
        //    try
        //    {
        //        _context.Employees.Add(employee);
        //        _context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error adding employee", ex);
        //    }
        //}

        public void Update(Employee employee)
        {
            try
            {
                var existingEmployee = _context.Employees.Find(employee.Id);
                if (existingEmployee == null)
                {
                    throw new Exception("Employee not found");
                }

                _context.Entry(existingEmployee).CurrentValues.SetValues(employee);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating employee", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var employee = _context.Employees.Find(id);
                if (employee != null)
                {
                    _context.Employees.Remove(employee);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("Employee not found");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting employee with ID {id}", ex);
            }
        }

        //public Employee GetByName(string name)
        //{
        //    try
        //    {
        //        _context.Employees.Adapt(name);
        //        _context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error adding employee", ex);
        //    }
        //}
    }
}

        //public IEnumerable<Employee> GetAll()
        //{
        //    return _context.Employees.ToList();
        //    //_context.SaveChanges();
        //}

        //public Employee GetById(int id) 
        //{
        //    return _context.Employees.Find(id);
        //    //_context.SaveChanges();
        //}

        //public void Add(Employee employee) 
        //{
        //    _context.Employees.Add(employee);
        //    _context.SaveChanges(); 
        //}

        //public void Update(Employee employee)
        //{
        //    _context.Employees.Update(employee);
        //    _context.SaveChanges();
        //}

        //public void Delete(int id)
        //{
        //    var employee = _context.Employees.Find(id);
        //    if (employee != null)
        //    {
        //        _context.Employees.Remove(employee);
        //        _context.SaveChanges();
        //    }
        //}
    //}
//}

