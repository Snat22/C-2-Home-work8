using Domain;

namespace Infrastructure;

public class EmployeeServices
{
    List<Employee> _employees = new List<Employee>();

    public List<Employee> GetEmployees()
    {

        return _employees;
    }

    public void AddEmployees(Employee employee)
    {
        _employees.Add(employee);
    }

    public int CountEmployees()
    {
     return _employees.Count;
    }
}

