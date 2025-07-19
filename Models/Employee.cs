namespace EmployeeManager.Models;

public class Employee
{
    public int EmployeeID { get; set; }
    public string? Name { get; set; }
    public string? Designation { get; set; }
    public DateTime DOB { get; set; }
    public DateTime DOJ { get; set; }
    public decimal Salary { get; set; }
    public string? Gender { get; set; }
    public int StateID { get; set; }
    public State? State { get; set; }
}