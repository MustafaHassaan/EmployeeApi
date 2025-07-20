using EmployeeApi.Data;
using EmployeeApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : Controller
    {
        private readonly Empapicontext _CDb;

        public EmployeesController(Empapicontext CDb)
        {
            _CDb = CDb;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            return await _CDb.Employees.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            var emp = await _CDb.Employees.FindAsync(id);
            if (emp == null) return NotFound();
            return emp;
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
        {
            _CDb.Employees.Add(employee);
            await _CDb.SaveChangesAsync();
            return CreatedAtAction(nameof(GetEmployee), new { id = employee.Id }, employee);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(int id, Employee employee)
        {
            if (id != employee.Id) return BadRequest();
            _CDb.Entry(employee).State = EntityState.Modified;
            await _CDb.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var emp = await _CDb.Employees.FindAsync(id);
            if (emp == null) return NotFound();
            _CDb.Employees.Remove(emp);
            await _CDb.SaveChangesAsync();
            return NoContent();
        }
    }
}
