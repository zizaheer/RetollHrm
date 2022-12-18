using RetollHrm.Models;

namespace RetollHrm.Data;

    public class MockEmployeeRepo : IEmployeeRepo
    {
        public IEnumerable<Employee> GetAllEmployees()
        {
            var employees = new List<Employee>{
                new Employee{Id=1, FirstName = "Kazi", LastName = "Islam", dateOfBirth =  Convert.ToDateTime("05-Feb-1980")},
                new Employee{Id=2, FirstName = "Zayir", LastName = "Kazi", dateOfBirth =  Convert.ToDateTime("29-Nov-2017")},
                new Employee{Id=3, FirstName = "Zarisha", LastName = "Kazi", dateOfBirth =  Convert.ToDateTime("08-Jul-2020")}
            };

            return employees;
        }

        public Employee GetEmployeeById(int id)
        {
           return new Employee {Id=3, FirstName = "Zarisha", LastName = "Kazi", dateOfBirth =  Convert.ToDateTime("08-Jul-2020")};
        }
    }

