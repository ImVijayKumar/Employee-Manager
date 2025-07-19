using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmployeeManager.Data;
using EmployeeManager.Models;

namespace EmployeeManager.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly AppDbContext _context;
    public EmployeesController(AppDbContext context) => _context = context;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Employee>>> Get()
    {
        var list = await _context.Employees.Include(e => e.State).ToListAsync();
        return Ok(list);
    }



    [HttpPost]
    public async Task<IActionResult> Post(Employee employee)
    {
        bool exists = _context.Employees.Any(e => e.Name == employee.Name && e.DOB == employee.DOB);
        if (exists) return Conflict("Duplicate employee found.");
        _context.Employees.Add(employee);
        await _context.SaveChangesAsync();
        return Ok(employee);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Employee employee)
    {
        if (id != employee.EmployeeID) return BadRequest();
        _context.Entry(employee).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var emp = await _context.Employees.FindAsync(id);
        if (emp == null) return NotFound();
        _context.Employees.Remove(emp);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
