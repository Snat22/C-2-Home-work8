using Domain;

namespace Infrastructure;

public class DepartmentServices
{
    List<Department> _departments = new List<Department>();

    public List<Department> GetDepartments()
    {
        return _departments;
    }

    public void AddDepartment(Department department)
    {
        _departments.Add(department);
    }

    public int CountDepartments()
    {
        return _departments.Count;
    }
}
