using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreAngularJS.Models;

namespace DotNetCoreAngularJS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        List<Employee> listOfEmployee = new List<Employee>()
        {
            new Employee(){ empId=1, firstName="Tom", lastName="zuckerberg", age=11},
            new Employee(){ empId=2, firstName="Jenis", lastName="zuckerberg", age=22},
            new Employee(){ empId=3, firstName="Marry", lastName="zuckerberg", age=33},
            new Employee(){ empId=4, firstName="Carry", lastName="zuckerberg", age=44},
            new Employee(){ empId=5, firstName="June", lastName="zuckerberg", age=55}
        };
        // GET: api/Employee
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return listOfEmployee;
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Employee
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
