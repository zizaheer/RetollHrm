using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RetollHrm.Data;
using RetollHrm.Models;
using Microsoft.AspNetCore.Mvc;

namespace RetollHrm.Controllers;

    [ApiController]
    //api/employee
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
    private readonly IEmployeeRepo _repository;

    public EmployeesController(IEmployeeRepo empRepo)
        {
            _repository = empRepo;
        }

        // GET api/employees
        [HttpGet]
        public ActionResult <IEnumerable<Employee>> GetAllEmployees()
        {
            var employees = _repository.GetAllEmployees();
            return Ok(employees);
        }

        // GET api/employees/5
        [HttpGet("{id}")]
        public ActionResult GetEmployeeById(int id)
        {
            var employee = _repository.GetEmployeeById(id);
            return Ok(employee);
        }

        
    }
