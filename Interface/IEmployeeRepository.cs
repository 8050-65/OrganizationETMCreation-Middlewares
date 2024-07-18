using OrganizationETMCreation.Models;

namespace OrganizationETMCreation.Interface
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        Employee GetWithId(int name); 
        //Employee GetByName(string name);
        //Employee GetByName(string name);
    }

}
