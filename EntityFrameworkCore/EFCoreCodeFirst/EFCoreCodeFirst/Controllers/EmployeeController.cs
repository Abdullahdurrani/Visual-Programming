using EFCoreCodeFirst.Models;
using EFCoreCodeFirst.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace EFCoreCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IDataRepository<Employee> _repo;

        public EmployeeController(IDataRepository<Employee> repo)
        {
            _repo = repo;
        }

        // GET: api/Employee
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Employee> employees = _repo.GetAll();
            return Ok(employees);
        }

        // GET: api/Employee/5
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            Employee employee = _repo.Get(id);

            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        // POST: api/Employee
        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest();
            }
            _repo.Add(employee);
            // returns employee object created with 201 status
            return CreatedAtAction("Get", new { Id = employee.EmployeeId }, employee);
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, Employee employee)
        {
            if (employee == null)
            {
                return BadRequest();
            }

            Employee employeeToUpdate = _repo.Get(id);
            if(employeeToUpdate == null)
            {
                return NotFound();
            }
            _repo.Update(employeeToUpdate, employee);
            return Ok(employeeToUpdate);
        }

        // DELETE: api/Employee/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Employee employee = _repo.Get(id);

            if (employee == null)
            {
                return NotFound();
            }

            _repo.Delete(employee);
            return Ok(employee);
        }
    } 
}
