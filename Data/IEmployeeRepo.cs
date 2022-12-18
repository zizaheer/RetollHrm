
using RetollHrm.Models;

namespace RetollHrm.Data;

    public interface IEmployeeRepo
    
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);

    }

