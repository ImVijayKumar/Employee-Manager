using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManager.Data;
using EmployeeManager.Models;

[Route("api/[controller]")]
[ApiController]
public class StatesController : ControllerBase
{
    private readonly AppDbContext _context;

    public StatesController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult> GetStates()
    {
        try
        {
            var connection = _context.Database.GetDbConnection();
            await connection.OpenAsync();
            var dbName = connection.Database;
            Console.WriteLine($"🔍 Connected to DB: {dbName}");

            var states = await _context.States.ToListAsync();
            Console.WriteLine($"✅ States fetched: {states.Count}");

            return Ok(states);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ DB Error: {ex.Message}");
            return StatusCode(500, "Database connection failed.");
        }
    }
    [HttpGet("debug-db")]
    public IActionResult CheckDatabase()
    {
        var dbName = _context.Database.GetDbConnection().Database;
        return Ok($"Connected to: {dbName}");
    }


}
